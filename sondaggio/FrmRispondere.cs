using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace sondaggio
{
    public partial class FrmRispondere : Form
    {
        ClsDomanda _domandaCorrente;
        ClsSondaggio _sondaggio;
        int _indiceDomandaCorrente;
        int _numeroDomandeSondaggio;

        List<ClsDomanda> _domande = new List<ClsDomanda>();

        List<int> _idDomandeRisposte = new List<int>();
        List<string> _testiRisposte = new List<string>();

        public FrmRispondere(ClsSondaggio sondaggio)
        {
            _sondaggio = sondaggio;
            _indiceDomandaCorrente = 0;
            InitializeComponent();

            pnlAperta.Visible = false;
            pnlVF.Visible = false;
            pnlSingola.Visible = false;
            pnlMultipla.Visible = false;
        }

        private void FrmRispondere_Load(object sender, EventArgs e)
        {
            lblSondaggioID.Text = "Sondaggio ID: #" + _sondaggio.ID.ToString() + " Nome: " +_sondaggio.Nome;

            _domande = _sondaggio.TutteDomandeOrdinate();
            _numeroDomandeSondaggio = _domande.Count;

            if (_numeroDomandeSondaggio == 0)
            {
                MessageBox.Show("Questo sondaggio non ha ancora domande", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            else
            {
                CaricaRisposteDaFile();

                CaricaListBox(_domande);

                if (_numeroDomandeSondaggio > 0)
                    CaricaDomanda(0);
            }
        }
        private void CaricaRisposteDaFile()
        {
            foreach (ClsDomanda domanda in _sondaggio.DomandaChiusa)
            {
                string nomeFile = $"Risposte_S{_sondaggio.ID}_D{domanda.Id}.json";
                if (File.Exists(nomeFile))
                {
                    try
                    {
                        string json = File.ReadAllText(nomeFile);
                        domanda.Risposte = JsonConvert.DeserializeObject<List<ClsRisposta>>(json);
                    }
                    catch
                    {
                        if (domanda.Risposte == null)
                            domanda.Risposte = new List<ClsRisposta>();
                    }
                }
            }
        }
        private void CaricaListBox(List<ClsDomanda> domande)
        {
            lbDomande.Items.Clear();
            int i = 1;
            while (i <= domande.Count)
            {
                lbDomande.Items.Add("Domanda " + i);
                i++;
            }
        }
        private void lbDomande_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbDomande.SelectedIndex >= 0)
            {
                _indiceDomandaCorrente = lbDomande.SelectedIndex;
                CaricaDomanda(_indiceDomandaCorrente);
            }
        }
        private void CaricaDomanda(int indice)
        {
            _domandaCorrente = _domande[indice];
            lblOrdineDomanda.Text = (_indiceDomandaCorrente + 1) + ".";
            lblTesto.Text = _domandaCorrente.Testo;
            pnlAperta.Visible = false;
            pnlVF.Visible = false;
            pnlSingola.Visible = false;
            pnlMultipla.Visible = false;

            if (_domandaCorrente is ClsDomandaChiusa chiusa)
            {
                if (chiusa.Tipologia == ClsDomandaChiusa.eTIPOLOGIA.VF)
                {
                    pnlVF.Visible = true;
                    rbVero.Checked = false;
                    rbFalso.Checked = false;
                }
                else if (chiusa.Tipologia == ClsDomandaChiusa.eTIPOLOGIA.S)
                {
                    pnlSingola.Visible = true;
                    pnlSingola.Controls.Clear();

                    for (int i = 0; i < chiusa.Risposte.Count; i++)
                    {
                        RadioButton rb = new RadioButton
                        {
                            Text = chiusa.Risposte[i].Testo,
                            Tag = i,
                            AutoSize = true,
                            Margin = new Padding(10, 5, 10, 5),
                            MaximumSize = new Size(pnlSingola.Width - 30, 0)
                        };
                        pnlSingola.Controls.Add(rb);
                    }
                }
                else if (chiusa.Tipologia == ClsDomandaChiusa.eTIPOLOGIA.M)
                {
                    pnlMultipla.Visible = true;
                    pnlMultipla.Controls.Clear();
                    pnlMultipla.FlowDirection = FlowDirection.TopDown;
                    pnlMultipla.WrapContents = false;
                    pnlMultipla.AutoScroll = true;

                    for (int i = 0; i < chiusa.Risposte.Count; i++)
                    {
                        CheckBox cb = new CheckBox
                        {
                            Text = chiusa.Risposte[i].Testo,
                            Tag = i,
                            AutoSize = true,
                            Margin = new Padding(10, 5, 10, 5),
                            MaximumSize = new Size(pnlMultipla.Width - 30, 0)
                        };
                        pnlMultipla.Controls.Add(cb);
                    }
                }
            }
            else
            {
                pnlAperta.Visible = true;
                rtbRisposta.Clear();
            }

            RipristinaRispostaSalvata();
            GestisciBottoniNavigazione();
        }

        private void RipristinaRispostaSalvata()
        {
            int j = 0;
            bool trovata = false;

            while (j < _idDomandeRisposte.Count && !trovata)
            {
                if (_idDomandeRisposte[j] == _domandaCorrente.Id)
                {
                    trovata = true;
                    string rispostaSalvata = _testiRisposte[j];

                    if (_domandaCorrente is ClsDomandaChiusa chiusa)
                    {
                        if (chiusa.Tipologia == ClsDomandaChiusa.eTIPOLOGIA.VF)
                        {
                            if (rispostaSalvata == "Vero")
                                rbVero.Checked = true;
                            else if (rispostaSalvata == "Falso")
                                rbFalso.Checked = true;
                        }
                        else if (chiusa.Tipologia == ClsDomandaChiusa.eTIPOLOGIA.S)
                        {
                            foreach (Control ctrl in pnlSingola.Controls)
                            {
                                if (ctrl is RadioButton rb && rb.Text == rispostaSalvata)
                                    rb.Checked = true;
                            }
                        }
                        else if (chiusa.Tipologia == ClsDomandaChiusa.eTIPOLOGIA.M)
                        {
                            string[] risposteArray = rispostaSalvata.Split('|');
                            foreach (Control ctrl in pnlMultipla.Controls)
                            {
                                if (ctrl is CheckBox cb)
                                {
                                    if (risposteArray.Contains(cb.Text))
                                        cb.Checked = true;
                                }
                            }
                        }
                    }
                    else
                        rtbRisposta.Text = rispostaSalvata;
                }
                j++;
            }
        }

        private void btnVaiAvanti_Click(object sender, EventArgs e)
        {
            if (_indiceDomandaCorrente < _numeroDomandeSondaggio - 1)
            {
                SalvaRispostaCorrente();
                _indiceDomandaCorrente++;

                CaricaDomanda(_indiceDomandaCorrente);
                lbDomande.SelectedIndex = _indiceDomandaCorrente;

                GestisciBottoniNavigazione();
            }
        }
        private void GestisciBottoniNavigazione()
        {
            if (_indiceDomandaCorrente > 0)
                btnVaiIndietro.Visible = true;
            else
                btnVaiIndietro.Visible = false;

            if (_indiceDomandaCorrente < _numeroDomandeSondaggio - 1)
                btnVaiAvanti.Visible = true;
            else
                btnVaiAvanti.Visible = false;
        }

        private void btnVaiIndietro_Click(object sender, EventArgs e)
        {
            if (_indiceDomandaCorrente > 0)
            {
                SalvaRispostaCorrente();
                _indiceDomandaCorrente--;

                CaricaDomanda(_indiceDomandaCorrente);
                lbDomande.SelectedIndex = _indiceDomandaCorrente;

                GestisciBottoniNavigazione();
            }
        }
        private void SalvaRispostaCorrente()
        {
            string risposta = "";
            bool rispostaValida = false;

            if (_domandaCorrente is ClsDomandaChiusa chiusa)
            {
                if (chiusa.Tipologia == ClsDomandaChiusa.eTIPOLOGIA.VF)
                {
                    if (rbVero.Checked)
                    {
                        risposta = "Vero";
                        rispostaValida = true;
                    }
                    else if (rbFalso.Checked)
                    {
                        risposta = "Falso";
                        rispostaValida = true;
                    }
                }
                else if (chiusa.Tipologia == ClsDomandaChiusa.eTIPOLOGIA.S)
                {
                    int i = 0;
                    rispostaValida = false;
                    risposta = "";

                    while (i < pnlSingola.Controls.Count && !rispostaValida)
                    {
                        if (pnlSingola.Controls[i] is RadioButton rb && rb.Checked)
                        {
                            risposta = rb.Text;
                            rispostaValida = true;
                        }
                        i++;
                    }
                }
                else if (chiusa.Tipologia == ClsDomandaChiusa.eTIPOLOGIA.M)
                {
                    List<string> scelte = new List<string>();
                    foreach (Control ctrl in pnlMultipla.Controls)
                    {
                        if (ctrl is CheckBox cb && cb.Checked)
                            scelte.Add(cb.Text);
                    }
                    if (scelte.Count > 0)
                    {
                        risposta = string.Join("|", scelte);
                        rispostaValida = true;
                    }
                }
            }
            else
            {
                risposta = rtbRisposta.Text.Trim();
                if (!string.IsNullOrEmpty(risposta))
                    rispostaValida = true;
            }

            if (rispostaValida)
            {
                int index = _idDomandeRisposte.IndexOf(_domandaCorrente.Id);
                if (index != -1)
                    _testiRisposte[index] = risposta;
                else
                {
                    _idDomandeRisposte.Add(_domandaCorrente.Id);
                    _testiRisposte.Add(risposta);
                }
            }
        }

        private void llblFineSondaggio_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SalvaRispostaCorrente();

            DialogResult dr = MessageBox.Show("Sei sicuro di terminare il sondaggio?", "Attenzione", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                for (int i = 0; i < _idDomandeRisposte.Count; i++)
                {
                    int idDomanda = _idDomandeRisposte[i];
                    string risposteConcat = _testiRisposte[i];
                    ClsDomanda domanda = null;
                    int j = 0;
                    bool trovataDomanda = false;

                    while (j < _domande.Count && !trovataDomanda)
                    {
                        if (_domande[j].Id == idDomanda)
                        {
                            domanda = _domande[j];
                            trovataDomanda = true;
                        }
                        j++;
                    }

                    if (domanda != null)
                    {
                        if (domanda is ClsDomandaChiusa chiusa)
                        {
                            if (chiusa.Tipologia == ClsDomandaChiusa.eTIPOLOGIA.VF && (chiusa.Risposte == null || chiusa.Risposte.Count == 0))
                            {
                                chiusa.Risposte = new List<ClsRisposta>();
                                chiusa.Risposte.Add(new ClsRisposta(1, "Vero", 0));
                                chiusa.Risposte.Add(new ClsRisposta(2, "Falso", 0));
                            }

                            string[] risposteArray = risposteConcat.Split('|');
                            for (int k = 0; k < risposteArray.Length; k++)
                            {
                                string testoRisposta = risposteArray[k];
                                int z = 0;
                                bool trovataRisp = false;
                                while (z < chiusa.Risposte.Count && !trovataRisp)
                                {
                                    if (chiusa.Risposte[z].Testo == testoRisposta)
                                    {
                                        chiusa.Risposte[z].Contatore++;
                                        trovataRisp = true;
                                    }
                                    z++;
                                }
                            }

                            try
                            {
                                string nomeFile = $"Risposte_S{_sondaggio.ID}_D{chiusa.Id}.json";
                                string json = JsonConvert.SerializeObject(chiusa.Risposte, Formatting.Indented);
                                File.WriteAllText(nomeFile, json);
                            }
                            catch
                            {
                            }
                        }
                        else
                        {
                            try
                            {
                                string nomeFileAperte = $"RisposteAperte_S{_sondaggio.ID}_D{domanda.Id}.txt";
                                string rigaDaSalvare = $"[{DateTime.Now}] {risposteConcat}" + Environment.NewLine;
                                File.AppendAllText(nomeFileAperte, rigaDaSalvare);
                            }
                            catch
                            {
                            }
                        }
                    }
                }

                SalvaPartecipazione();

                MessageBox.Show("Sondaggio completato e salvato!", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FrmFaiSondaggi frmFaiSondaggi = new FrmFaiSondaggi();
                this.Hide();
                frmFaiSondaggi.ShowDialog();
                this.Close();
            }
        }

        private void btnTornaAiSondaggi_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Le risposte non salvate andranno perse. Procedere?","Attenzione", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                FrmCreaSondaggi frmCreaSondaggi = new FrmCreaSondaggi();
                this.Hide();
                frmCreaSondaggi.ShowDialog();
                this.Close();
            }
        }
        private void SalvaPartecipazione()
        {
            ClsRispondere partecipazione = new ClsRispondere();
            partecipazione.IDSondaggio = _sondaggio.ID;
            partecipazione.UsernameIntervistato = DB.UtenteLoggato.Username;
            partecipazione.Risposta = "Completato"; 

            DB.Rispondere.Add(partecipazione);
            DB.SalvaDati();
        }
        private void FrmRispondere_FormClosing(object sender, FormClosingEventArgs e)
        {
            DB.SalvaDati();
        }
    }
}
