using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sondaggio
{
    public partial class FrmCreaDomande : Form
    {
        bool domandaAperta;
        ClsSondaggio _sondaggio;
        int _indice;
        bool _modifica = false;

        public FrmCreaDomande(ClsSondaggio sondaggio)
        {
            InitializeComponent();
            _sondaggio = sondaggio;
        }

        private void FrmDomanda_Load(object sender, EventArgs e)
        {
            lblSondaggioID.Text = "ID Sondaggio " + _sondaggio.ID;
            PopolaComboBox();
            PopolaListView();
        }
        private void PopolaComboBox()
        {
            cbDomande.Items.Clear();

            for (int i = 0; i < _sondaggio.DomandaAperta.Count; i++)
                cbDomande.Items.Add(_sondaggio.DomandaAperta[i].Testo);

            for (int i = 0; i < _sondaggio.DomandaChiusa.Count; i++)
                cbDomande.Items.Add(_sondaggio.DomandaChiusa[i].Testo);
        }

        private void PopolaListView()
        {
            lvDomande.Items.Clear();
            for (int i = 0; i < _sondaggio.DomandaAperta.Count; i++)
            {
                if (string.IsNullOrEmpty(cbDomande.Text) || cbDomande.Text == _sondaggio.DomandaAperta[i].Testo)
                {
                    //aperta
                    ListViewItem lvi = new ListViewItem(_sondaggio.DomandaAperta[i].Ordine.ToString());
                    lvi.SubItems.Add("Aperta");
                    lvi.SubItems.Add(_sondaggio.DomandaAperta[i].Testo);
                    lvi.Tag = "A-" + i;
                    lvDomande.Items.Add(lvi);
                }
            }
            for (int i = 0; i < _sondaggio.DomandaChiusa.Count; i++)
            {
                if (string.IsNullOrEmpty(cbDomande.Text) || cbDomande.Text == _sondaggio.DomandaChiusa[i].Testo)
                {
                    string tipologia = "";
                    if (_sondaggio.DomandaChiusa[i].Tipologia == ClsDomandaChiusa.eTIPOLOGIA.VF)
                        tipologia = "Vero/Falso";
                    else if (_sondaggio.DomandaChiusa[i].Tipologia == ClsDomandaChiusa.eTIPOLOGIA.S)
                        tipologia = "Singola";
                    else if (_sondaggio.DomandaChiusa[i].Tipologia == ClsDomandaChiusa.eTIPOLOGIA.M)
                        tipologia = "Multipla";

                    //chiusa
                    ListViewItem lvi = new ListViewItem(_sondaggio.DomandaChiusa[i].Ordine.ToString());
                    lvi.SubItems.Add(tipologia);
                    lvi.SubItems.Add(_sondaggio.DomandaChiusa[i].Testo);
                    lvi.Tag = "C-" + i;
                    lvDomande.Items.Add(lvi);
                }
            }
        }


        private void rbAperta_CheckedChanged(object sender, EventArgs e)
        {
            domandaAperta = rbAperta.Checked;

            rbSiNo.Enabled = !domandaAperta;
            rbSingola.Enabled = !domandaAperta;
            rbMultiple.Enabled = !domandaAperta;
            btnGestisciRisposte.Enabled = !domandaAperta && !rbSiNo.Checked;
        }
        private void btnTornaIndietro_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtbTesto.Text) || nudOrdine.Value == 0 || (!rbAperta.Checked && !rbSiNo.Checked && !rbSingola.Checked && !rbMultiple.Checked))
                MessageBox.Show("Compilare tutti i campi!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                int ordine = (int)nudOrdine.Value;
                string testo = rtbTesto.Text.Trim();
                bool esisteDomanda = false;
                int i = 0;
                while (i < _sondaggio.Domande.Count && !esisteDomanda)
                {
                    if (_sondaggio.Domande[i].Ordine == ordine && !_modifica)
                        esisteDomanda = true;
                    i++;
                }
                if (esisteDomanda)
                    MessageBox.Show("Ordine già esistente!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (rbAperta.Checked)
                    {
                        ClsDomanda domandaAperta = new ClsDomanda(DB.ContIDrisp, testo, ordine, new List<ClsRisposta>());
                        DB.ContIDrisp++;
                        if (_modifica)
                        {
                            if (domandaAperta.GetType() == typeof(ClsDomanda))
                                _sondaggio.DomandaAperta[_indice] = domandaAperta;
                        }
                        else
                            _sondaggio.DomandaAperta.Add(domandaAperta);
                    }
                    else
                    {
                        ClsDomandaChiusa.eTIPOLOGIA tipologia;
                        if (rbSiNo.Checked)
                            tipologia = ClsDomandaChiusa.eTIPOLOGIA.VF;
                        else if (rbSingola.Checked)
                            tipologia = ClsDomandaChiusa.eTIPOLOGIA.S;
                        else
                            tipologia = ClsDomandaChiusa.eTIPOLOGIA.M;

                        List<ClsRisposta> risposte = new List<ClsRisposta>();

                        if (tipologia == ClsDomandaChiusa.eTIPOLOGIA.VF)
                        {
                            risposte.Add(new ClsRisposta(1, "Vero", 0));
                            risposte.Add(new ClsRisposta(2, "Falso", 0));
                        }

                        ClsDomandaChiusa domandaChiusa = new ClsDomandaChiusa(DB.ContIDrisp, testo, ordine, tipologia, risposte);
                        DB.ContIDrisp++;
                        if (_modifica)
                        {
                            if (domandaChiusa.GetType() == typeof(ClsDomandaChiusa))
                                _sondaggio.DomandaChiusa[_indice] = domandaChiusa;
                        }
                        else
                            _sondaggio.DomandaChiusa.Add(domandaChiusa);
                    }
                    PopolaListView();
                    PopolaComboBox();
                    ResetCampi();
                    MessageBox.Show("Domanda aggiunta/modificata!", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _modifica = false;
                }
            }
            btnAggiungi.Text = "Aggiungi";
        }

        private void ResetCampi()
        {
            nudOrdine.Value++;
            rbAperta.Checked = false;
            rbMultiple.Checked = false;
            rbSingola.Checked = false;
            rbSiNo.Checked = false;
            rtbTesto.Text = String.Empty;
            btnGestisciRisposte.Enabled = true;
        }

        private void btnGestisciRisposte_Click(object sender, EventArgs e)
        {
            if (lvDomande.SelectedItems.Count > 0)
            {
                string tag = lvDomande.SelectedItems[0].Tag.ToString();
                string[] parti = tag.Split('-');
                string tipo = parti[0];
                int indiceDomanda = Convert.ToInt32(parti[1]);

                if (tipo == "C")
                {
                    ClsDomandaChiusa domandaSelezionata = _sondaggio.DomandaChiusa[indiceDomanda];

                    if (domandaSelezionata.Tipologia == ClsDomandaChiusa.eTIPOLOGIA.VF)
                        MessageBox.Show("Le domande Vero/Falso hanno risposte predefinite (Vero/Falso) e non possono essere modificate.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                    {
                        FrmCreaRisposte frmRisposte = new FrmCreaRisposte(domandaSelezionata, _sondaggio);
                        frmRisposte.ShowDialog();
                        DB.SalvaDati();
                    }
                }
                else
                    MessageBox.Show("Le domande aperte non hanno risposte predefinite!");
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (lvDomande.SelectedItems.Count == 0)
                MessageBox.Show("Selezionare una domanda da modificare!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                string tag = lvDomande.SelectedItems[0].Tag.ToString();
                string[] parti = tag.Split('-');
                string tipo = parti[0];
                _indice = Convert.ToInt32(parti[1]);
                if (tipo == "A")
                {
                    ClsDomanda domanda = _sondaggio.DomandaAperta[_indice];
                    nudOrdine.Value = domanda.Ordine;
                    rtbTesto.Text = domanda.Testo;
                    rbAperta.Checked = true;
                }
                else
                {
                    ClsDomandaChiusa domanda = _sondaggio.DomandaChiusa[_indice];
                    nudOrdine.Value = domanda.Ordine;
                    rtbTesto.Text = domanda.Testo;
                    if (domanda.Tipologia == ClsDomandaChiusa.eTIPOLOGIA.VF)
                        rbSiNo.Checked = true;
                    else if (domanda.Tipologia == ClsDomandaChiusa.eTIPOLOGIA.S)
                        rbSingola.Checked = true;
                    else
                        rbMultiple.Checked = true;
                }
                _modifica = true;
            }
            btnAggiungi.Text = "Aggiungi";
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            if (lvDomande.SelectedItems.Count == 0)
                MessageBox.Show("Selezionare una domanda da eliminare!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                DialogResult dr = MessageBox.Show("Sei sicuro di voler eliminare questa domanda?", "Conferma", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    string tag = lvDomande.SelectedItems[0].Tag.ToString();
                    string[] parti = tag.Split('-');
                    string tipo = parti[0];
                    int indice = Convert.ToInt32(parti[1]);

                    if (tipo == "A")
                        _sondaggio.DomandaAperta.RemoveAt(indice);
                    else
                        _sondaggio.DomandaChiusa.RemoveAt(indice);

                    PopolaComboBox();
                    PopolaListView();
                    MessageBox.Show("Domanda eliminata!", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            nudOrdine.Value = 1;
            rtbTesto.Text = "";
            rbAperta.Checked = false;
            rbSiNo.Checked = false;
            rbSingola.Checked = false;
            rbMultiple.Checked = false;
            _modifica = false;
        }
        private void cbDomande_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopolaListView();
        }

        private void FrmCreaDomande_FormClosing(object sender, FormClosingEventArgs e)
        {
            DB.SalvaDati();
        }
    }
}
