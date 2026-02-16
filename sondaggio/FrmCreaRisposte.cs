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
    public partial class FrmCreaRisposte : Form
    {
        bool _modifica = false;
        int _indice;
        ClsSondaggio _sondaggio;
        ClsDomandaChiusa _domanda;
        string _nomeFile;
        public FrmCreaRisposte(ClsDomandaChiusa domanda, ClsSondaggio sondaggio)
        {
            InitializeComponent();
            _domanda = domanda;
            _sondaggio = sondaggio;
        }
        private void FrmCreaRisposte_Load(object sender, EventArgs e)
        {
            lblSondaggioID.Text = "ID Sondaggio " + _sondaggio.ID;

            string tipologia = "";
            if (_domanda.Tipologia == ClsDomandaChiusa.eTIPOLOGIA.VF)
                tipologia = "Vero/Falso";
            else if (_domanda.Tipologia == ClsDomandaChiusa.eTIPOLOGIA.S)
                tipologia = "Singola";
            else if (_domanda.Tipologia == ClsDomandaChiusa.eTIPOLOGIA.M)
                tipologia = "Multipla";

            lblTipoDomanda.Text = "Domanda n° " + _domanda.Ordine + " - Tipologia: " + tipologia;

            _nomeFile = $"Risposte_S{_sondaggio.ID}_D{_domanda.Id}.json";

            if (File.Exists(_nomeFile))
            {
                try
                {
                    string json = File.ReadAllText(_nomeFile);
                    _domanda.Risposte = JsonConvert.DeserializeObject<List<ClsRisposta>>(json);
                }
                catch
                {
                    _domanda.Risposte = new List<ClsRisposta>();
                }
            }
            else
            {
                if (_domanda.Risposte == null)
                    _domanda.Risposte = new List<ClsRisposta>();
            }

            PopolaListView();
        }

        private void PopolaListView()
        {
            lvRisposte.Items.Clear();
            if (_domanda.Risposte != null)
            {
                for (int i = 0; i < _domanda.Risposte.Count; i++)
                {
                    ListViewItem lvi = new ListViewItem(_domanda.Risposte[i].Id.ToString());
                    lvi.SubItems.Add(_domanda.Risposte[i].Testo);
                    lvi.Tag = i; 
                    lvRisposte.Items.Add(lvi);
                }
            }
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtbTesto.Text))
                MessageBox.Show("Inserire il testo della risposta!");
            else
            {
                if (_domanda.Risposte == null)
                    _domanda.Risposte = new List<ClsRisposta>();

                if (_modifica)
                {
                    _domanda.Risposte[_indice].Testo = rtbTesto.Text;
                    _modifica = false;
                    btnSalva.Text = "Aggiungi";
                }
                else
                {
                    ClsRisposta nuovaRisposta = new ClsRisposta(_domanda.Risposte.Count + 1, rtbTesto.Text, 0);
                    _domanda.Risposte.Add(nuovaRisposta);
                }

                rtbTesto.Clear();
                PopolaListView();

                DB.SalvaDati();
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (lvRisposte.SelectedItems.Count == 0)
                MessageBox.Show("Selezionare una risposta da modificare!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                _indice = (int)lvRisposte.SelectedItems[0].Tag;
                rtbTesto.Text = _domanda.Risposte[_indice].Testo;
                _modifica = true;
            }
            btnSalva.Text = "Aggiungi";
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            if (lvRisposte.SelectedItems.Count == 0)
                MessageBox.Show("Selezionare una risposta da eliminare!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                DialogResult dr = MessageBox.Show("Sei sicuro di voler eliminare questa risposta?", "Conferma", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    _indice = (int)lvRisposte.SelectedItems[0].Tag;
                    _domanda.Risposte.RemoveAt(_indice);
                    PopolaListView();
                    MessageBox.Show("Risposta eliminata!", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private void btnTornaIndietro_Click(object sender, EventArgs e)
        {
            FrmCreaSondaggi frmCreaSondaggi = new FrmCreaSondaggi();
            this.Hide();
            frmCreaSondaggi.ShowDialog();
            this.Close();
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            rtbTesto.Text = "";
            _modifica = false;
        }

        private void FrmCreaRisposte_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_domanda.Risposte != null && _domanda.Risposte.Count > 0)
            {
                try
                {
                    string json = JsonConvert.SerializeObject(_domanda.Risposte, Formatting.Indented);
                    File.WriteAllText(_nomeFile, json);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Errore nel salvataggio: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
