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

namespace sondaggio
{
    public partial class FrmRaggruppaRisposteAperte : Form
    {
        ClsSondaggio _sondaggioSelezionato;
        ClsDomanda _domandaSelezionata;
        bool _modifica = false;
        string _rispostaStandardDaModificare = "";

        const string SEPARATORE = "|||";
        public FrmRaggruppaRisposteAperte()
        {
            InitializeComponent();
        }

        private void FrmRaggruppaRisposteAperte_Load(object sender, EventArgs e)
        {
            DB.CaricaDati();
            PopolaComboBoxSondaggi();
        }

        private void PopolaComboBoxSondaggi()
        {
            cbSondaggi.Items.Clear();

            foreach (ClsSondaggio sondaggio in DB.Sondaggi)
            {
                if (sondaggio.DomandaAperta != null && sondaggio.DomandaAperta.Count > 0)
                    cbSondaggi.Items.Add(sondaggio.Nome);
            }

            if (cbSondaggi.Items.Count > 0)
                cbSondaggi.SelectedIndex = 0;
            else
            {
                MessageBox.Show("Nessun sondaggio con domande aperte disponibile", "Informazione", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void cbSondaggi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSondaggi.SelectedIndex >= 0)
            {
                string nomeSondaggio = cbSondaggi.SelectedItem.ToString();

                _sondaggioSelezionato = DB.Sondaggi.FirstOrDefault(s => s.Nome == nomeSondaggio);

                if (_sondaggioSelezionato != null)
                {
                    PopolaListBoxDomande();
                    ResetCampi();
                }
            }
        }

        private void PopolaListBoxDomande()
        {
            lbDomande.Items.Clear();

            if (_sondaggioSelezionato != null && _sondaggioSelezionato.DomandaAperta != null)
            {
                foreach (ClsDomanda domanda in _sondaggioSelezionato.DomandaAperta)
                    lbDomande.Items.Add($"Domanda {domanda.Ordine}: {domanda.Testo}");
            }

            if (lbDomande.Items.Count > 0)
                lbDomande.SelectedIndex = 0;
        }

        private void lbDomande_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbDomande.SelectedIndex >= 0 && _sondaggioSelezionato != null)
            {
                _domandaSelezionata = _sondaggioSelezionato.DomandaAperta[lbDomande.SelectedIndex];

                if (_domandaSelezionata.RisposteStandard == null)
                    _domandaSelezionata.RisposteStandard = new List<string>();

                PopolaListViewRisposte();
                ResetCampi();
            }
        }

        private void PopolaListViewRisposte()
        {
            lvRisposte.Items.Clear();

            if (_domandaSelezionata != null && _sondaggioSelezionato != null)
            {
                string nomeFile = $"RisposteAperte_S{_sondaggioSelezionato.ID}_D{_domandaSelezionata.Id}.txt";

                if (File.Exists(nomeFile))
                {
                    try
                    {
                        string[] righe = File.ReadAllLines(nomeFile);
                        string filtroRicerca = tbRisposta.Text.Trim().ToLower();

                        foreach (string riga in righe)
                        {
                            if (!string.IsNullOrWhiteSpace(riga))
                            {
                                string testoRisposta = EstraiTestoRisposta(riga);
                                string data = EstraiData(riga);

                                if (string.IsNullOrEmpty(filtroRicerca) ||
                                    testoRisposta.ToLower().Contains(filtroRicerca))
                                {
                                    string rispostaStandard = TrovaRispostaStandard(testoRisposta);

                                    ListViewItem lvi = new ListViewItem(testoRisposta); 
                                    lvi.SubItems.Add(rispostaStandard); 
                                    lvi.Tag = testoRisposta;
                                    lvRisposte.Items.Add(lvi);
                                }
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Errore nella lettura del file: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Nessuna risposta trovata per questa domanda.", "Informazione", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private string EstraiTestoRisposta(string riga)
        {
            string r;
            int indiceChiusura = riga.IndexOf(']');
            if (indiceChiusura >= 0 && indiceChiusura < riga.Length - 1)
                r=riga.Substring(indiceChiusura + 1).Trim();
            else
                r= riga.Trim();
            return r;
        }

        private string EstraiData(string riga)
        {
            string r;
            int inizio = riga.IndexOf('[');
            int fine = riga.IndexOf(']');
            if (inizio >= 0 && fine > inizio)
                r = riga.Substring(inizio + 1, fine - inizio - 1).Trim();
            else
                r="N/D";
            return r;
        }

        private string TrovaRispostaStandard(string testoRisposta)
        {
            string rispostaStandard = "-";

            int i = 0;
            bool trovato = false;

            while (i < _domandaSelezionata.RisposteStandard.Count && !trovato)
            {
                string risposta = _domandaSelezionata.RisposteStandard[i];

                if (risposta.Contains(SEPARATORE))
                {
                    string[] parti = risposta.Split(new[] { SEPARATORE }, StringSplitOptions.None);
                    if (parti.Length == 2 && parti[0] == testoRisposta)
                    {
                        rispostaStandard = parti[1];
                        trovato = true;
                    }
                }
                i++;
            }

            return rispostaStandard;
        }

        private void ResetCampi()
        {
            tbRispostaStandard.Text = "";
            _modifica = false;
            _rispostaStandardDaModificare = "";
        }

        private bool ValidaSelezione(string messaggio = "Selezionare almeno una risposta!")
        {
            bool èValido;
            if (lvRisposte.SelectedItems.Count == 0)
            {
                MessageBox.Show(messaggio, "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                èValido = false;
            }
            else
                èValido=true;
            return èValido;
        }

        private bool ValidaRispostaStandard()
        {
            bool èValido;
            if (string.IsNullOrWhiteSpace(tbRispostaStandard.Text))
            {
                MessageBox.Show("Inserire una risposta standard!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                èValido = false;
            }
            else
                èValido= true;
            return èValido;
        }

        private bool HaAlmenoUnoStandard()
        {
            bool haStandard = false;
            int i = 0;

            while (i < lvRisposte.SelectedItems.Count && !haStandard)
            {
                if (lvRisposte.SelectedItems[i].SubItems[1].Text != "-")
                    haStandard = true;
                i++;
            }

            return haStandard;
        }


        private void RimuoviAssociazioneSingola(string testoRispostaUtente)
        {
            _domandaSelezionata.RisposteStandard.RemoveAll(entry =>
            {
                if (entry.Contains(SEPARATORE))
                {
                    string[] parti = entry.Split(new[] { SEPARATORE }, StringSplitOptions.None);
                    return parti.Length == 2 && parti[0] == testoRispostaUtente;
                }
                return false;
            });
        }

        private void GestisciAssociazione(string testoRispostaUtente, string rispostaStandard)
        {
            RimuoviAssociazioneSingola(testoRispostaUtente);
            string rispostaUtenteConStandard = testoRispostaUtente + SEPARATORE + rispostaStandard;
            _domandaSelezionata.RisposteStandard.Add(rispostaUtenteConStandard);

            int i = 0;

            while (i < lvRisposte.Items.Count && lvRisposte.Items[i].Tag.ToString() != testoRispostaUtente)
                i++;

            if (i < lvRisposte.Items.Count)
                lvRisposte.Items[i].SubItems[1].Text = rispostaStandard;
        }

        private void SalvaEAggiorna(string messaggio)
        {
            DB.SalvaDati();
            PopolaListViewRisposte();
            MessageBox.Show(messaggio, "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (ValidaRispostaStandard())
            {
                string rispostaStandard = tbRispostaStandard.Text.Trim();

                if (_domandaSelezionata.RisposteStandard == null)
                    _domandaSelezionata.RisposteStandard = new List<string>();

                if (_modifica)
                    ModificaTutteLeAssociazioni(rispostaStandard);
                else
                    AssociaRisposteSelezionate(rispostaStandard);
            }
        }

        private void ModificaTutteLeAssociazioni(string nuovaRispostaStandard)
        {
            string vecchiaRisposta = _rispostaStandardDaModificare;

            for (int i = 0; i < _domandaSelezionata.RisposteStandard.Count; i++)
            {
                string entry = _domandaSelezionata.RisposteStandard[i];
                if (entry.Contains(SEPARATORE))
                {
                    string[] parti = entry.Split(new[] { SEPARATORE }, StringSplitOptions.None);
                    if (parti.Length == 2 && parti[1] == vecchiaRisposta)
                        _domandaSelezionata.RisposteStandard[i] = parti[0] + SEPARATORE + nuovaRispostaStandard;
                }
            }

            foreach (ListViewItem lvi in lvRisposte.Items)
            {
                if (lvi.SubItems[1].Text == vecchiaRisposta)
                    lvi.SubItems[1].Text = nuovaRispostaStandard;
            }

            tbRispostaStandard.Text = "";
            _modifica = false;
            _rispostaStandardDaModificare = "";

            SalvaEAggiorna("Risposta standard modificata con successo!");
        }

        private void AssociaRisposteSelezionate(string rispostaStandard)
        {
            if (ValidaSelezione("Selezionare almeno una risposta da associare!"))
            {
                foreach (ListViewItem lvi in lvRisposte.SelectedItems)
                {
                    string testoRispostaUtente = lvi.Tag.ToString();
                    GestisciAssociazione(testoRispostaUtente, rispostaStandard);
                }

                tbRispostaStandard.Text = "";
                SalvaEAggiorna("Associazione completata con successo!");
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (ValidaSelezione("Selezionare una risposta con risposta standard da modificare!"))
            {
                ListViewItem lvi = lvRisposte.SelectedItems[0];
                string rispostaStandardCorrente = lvi.SubItems[1].Text;

                if (rispostaStandardCorrente == "-")
                    MessageBox.Show("Questa risposta non ha una risposta standard associata!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    tbRispostaStandard.Text = rispostaStandardCorrente;
                    _modifica = true;
                    _rispostaStandardDaModificare = rispostaStandardCorrente;

                    MessageBox.Show("Modifica la risposta standard e premi 'Associa' per salvare", "Modalità Modifica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            if (ValidaSelezione("Selezionare una risposta con risposta standard da eliminare!"))
            {
                ListViewItem lvi = lvRisposte.SelectedItems[0];
                string rispostaStandard = lvi.SubItems[1].Text;

                if (rispostaStandard == "-")
                    MessageBox.Show("Questa risposta non ha una risposta standard associata!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    DialogResult dr = MessageBox.Show($"Sei sicuro di voler eliminare la risposta standard '{rispostaStandard}' e tutte le sue associazioni?", "Conferma", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes)
                        EliminaTutteLeAssociazioni(rispostaStandard);
                }
            }
        }

        private void EliminaTutteLeAssociazioni(string rispostaStandard)
        {
            _domandaSelezionata.RisposteStandard.RemoveAll(app =>
            {
                if (app.Contains(SEPARATORE))
                {
                    string[] parti = app.Split(new[] { SEPARATORE }, StringSplitOptions.None);
                    return parti.Length == 2 && parti[1] == rispostaStandard;
                }
                return false;
            });

            foreach (ListViewItem lvi in lvRisposte.Items)
            {
                if (lvi.SubItems[1].Text == rispostaStandard)
                    lvi.SubItems[1].Text = "-";
            }

            SalvaEAggiorna("Risposta standard eliminata con successo!");
        }

        private void btnEliminaSingoli_Click(object sender, EventArgs e)
        {
            if (ValidaSelezione("Selezionare almeno una risposta da cui rimuovere lo standard!"))
            {
                if (!HaAlmenoUnoStandard())
                    MessageBox.Show("Nessuna delle risposte selezionate ha una risposta standard associata!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {             
                    DialogResult dr = MessageBox.Show($"Sei sicuro di voler rimuovere la risposta standard dalle {lvRisposte.SelectedItems.Count} risposta/e selezionata/e?", "Conferma", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes)
                        EliminaAssociazioniSelezionate();
                }
            }
        }

        private void EliminaAssociazioniSelezionate()
        {
            int contatore = 0;

            foreach (ListViewItem lvi in lvRisposte.SelectedItems)
            {
                string testoRispostaUtente = lvi.Tag.ToString();
                string rispostaStandardCorrente = lvi.SubItems[1].Text;

                if (rispostaStandardCorrente != "-")
                {
                    RimuoviAssociazioneSingola(testoRispostaUtente);
                    lvi.SubItems[1].Text = "-";
                    contatore++;
                }
            }

            lvRisposte.SelectedItems.Clear();
            SalvaEAggiorna($"{contatore} associazione/i rimossa/e con successo!");
        }

        private void btnModificaSingoli_Click(object sender, EventArgs e)
        {
            if (ValidaSelezione("Selezionare almeno una risposta da modificare!") && ValidaRispostaStandard())
            {
                string nuovaRispostaStandard = tbRispostaStandard.Text.Trim();

                if (_domandaSelezionata.RisposteStandard == null)
                    _domandaSelezionata.RisposteStandard = new List<string>();

                int i = 0;
                foreach (ListViewItem lvi in lvRisposte.SelectedItems)
                {
                    string testoRispostaUtente = lvi.Tag.ToString();
                    GestisciAssociazione(testoRispostaUtente, nuovaRispostaStandard);
                    i++;
                }

                tbRispostaStandard.Text = "";
                lvRisposte.SelectedItems.Clear();

                SalvaEAggiorna($"{i} associazione/i modificata/e con successo!");
            }
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            ResetCampi();
            lvRisposte.SelectedItems.Clear();
        }

        private void FrmRaggruppaRisposteAperte_FormClosing(object sender, FormClosingEventArgs e)
        {
            DB.SalvaDati();
        }

        private void btnTornaIndietro_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbRisposta_TextChanged(object sender, EventArgs e)
        {
            if (_domandaSelezionata != null)
                PopolaListViewRisposte();
        }
    }
}