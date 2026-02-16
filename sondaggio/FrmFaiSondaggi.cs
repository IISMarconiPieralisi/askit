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
    public partial class FrmFaiSondaggi : Form
    {
        public FrmFaiSondaggi()
        {
            InitializeComponent();
        }

        private void FrmFaiSondaggi_Load(object sender, EventArgs e)
        {
            DB.CaricaDati();
            PopolaComboBox();
            PopolaListview();
        }

        private void PopolaComboBox()
        {
            cbDomande.Items.Clear();
            cbDomande.Items.Add("Tutti sondaggi");

            List<ClsSondaggio> sondaggiDisponibili = OttieniSondaggiDisponibili();

            for (int i = 0; i < sondaggiDisponibili.Count; i++)
                cbDomande.Items.Add(sondaggiDisponibili[i].Nome);

            cbDomande.SelectedIndex = 0;
        }
        private List<ClsSondaggio> OttieniSondaggiDisponibili()
        {
            List<ClsSondaggio> sondaggi;
            bool èOspite = DB.UtenteLoggato.Username.StartsWith("Guest-");

            if (èOspite)
                sondaggi=DB.Sondaggi.FindAll(s => s.Anonimo == true);
            else
                sondaggi =  DB.Sondaggi;
            return sondaggi;
        }
        private void PopolaListview()
        {
            lvDomande.Items.Clear();

            List<ClsSondaggio> sondaggiDisponibili = OttieniSondaggiDisponibili();  

            if (cbDomande.SelectedItem == null || cbDomande.SelectedIndex == 0)
            {
                foreach (ClsSondaggio sondaggio in sondaggiDisponibili)  
                    AggiungiSondaggioAListView(sondaggio);
            }
            else
            {
                string nomeSondaggio = cbDomande.SelectedItem.ToString();
                for (int i = 0; i < sondaggiDisponibili.Count; i++)  
                {
                    if (sondaggiDisponibili[i].Nome == nomeSondaggio)
                        AggiungiSondaggioAListView(sondaggiDisponibili[i]);
                }
            }
        }
        private void AggiungiSondaggioAListView(ClsSondaggio s)
        {
            ListViewItem lvi = new ListViewItem(s.Nome);
            lvi.SubItems.Add(s.NumeroDomande.ToString());

            string nomeCat = "Nessuna";
            if (s.Categoria != null)
                nomeCat = s.Categoria.Nome;
            lvi.SubItems.Add(nomeCat);

            string stato = "Chiuso";
            if (s.Aperto)
                stato = "Aperto";
            lvi.SubItems.Add(stato);

            string tipo = "Registrati";
            if (s.Anonimo)
                tipo = "Anonimo";
            lvi.SubItems.Add(tipo);

            lvi.SubItems.Add(s.DataCreazione.ToString("dd/MM/yyyy"));

            lvi.Tag = s;
            lvDomande.Items.Add(lvi);
        }

        private void cbDomande_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopolaListview();
        }

        private void btnPartecipa_Click(object sender, EventArgs e)
        {
            if (lvDomande.SelectedItems.Count > 0)
            {
                ClsSondaggio s = (ClsSondaggio)lvDomande.SelectedItems[0].Tag;

                bool giaFatto = DB.Rispondere.Any(r => r.IDSondaggio == s.ID && r.UsernameIntervistato == DB.UtenteLoggato.Username);

                if (giaFatto)
                    MessageBox.Show("Hai giò completato questo sondaggio, fanne altri!!!", "Accesso Negato", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                else if (s.Aperto == false)
                    MessageBox.Show("Sondaggio selezionato è al momento chiuso, fanne altri!!!", "Accesso Negato", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                else
                {
                    bool èOspite = DB.UtenteLoggato.Username.StartsWith("Guest-");
                    if (èOspite && !s.Anonimo)
                        MessageBox.Show("Come guest, puoi accedere solo ai sondaggi anonimi!","Accesso Negato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        FrmRispondere frm = new FrmRispondere(s);
                        this.Hide();
                        frm.ShowDialog();
                        this.Show();
                    }
                }
            }
        }

        private void FrmFaiSondaggi_FormClosing(object sender, FormClosingEventArgs e)
        {
            DB.SalvaDati();
        }
    }
}
