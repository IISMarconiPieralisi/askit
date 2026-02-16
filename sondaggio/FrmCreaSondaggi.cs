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
    public partial class FrmCreaSondaggi : Form
    {
        int indice;
        bool modifica = false;
        ClsSondaggio sondaggio = new ClsSondaggio();
        ClsAdmin admin = DB.Admin[0];
        public FrmCreaSondaggi()
        {
            InitializeComponent();
        }

        private void FrmCreaSondaggi_Load(object sender, EventArgs e)
        {
            DB.CaricaDati();
            PopolaListView(DB.Sondaggi);
            PopolaComboBox();
        }

        private void PopolaComboBox()
        {
            cbCategoria.Items.Clear();
            for (int i = 0; i < DB.Categorie.Count; i++)
                cbCategoria.Items.Add(DB.Categorie[i].Nome);

            cbDomandeFiltro.Items.Clear();
            cbDomandeFiltro.Items.Add("ID");
            cbDomandeFiltro.Items.Add("Stato");
            cbDomandeFiltro.Items.Add("Tipo");
            cbDomandeFiltro.Items.Add("Nome");
            cbDomandeFiltro.Items.Add("Data");
        }

        private void btnDomande_Click(object sender, EventArgs e)
        {
            if (lvDomande.SelectedItems.Count == 0)
                MessageBox.Show("Selezionare un sondaggio!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                ClsSondaggio sondaggioSelezionato = (ClsSondaggio)lvDomande.SelectedItems[0].Tag;
                FrmCreaDomande frmCreaDomande = new FrmCreaDomande(sondaggioSelezionato);
                this.Hide();
                frmCreaDomande.ShowDialog();
                this.Show();

                PopolaListView(DB.Sondaggi);
            }
        }

        private void btnCategorie_Click(object sender, EventArgs e)
        {
            FrmCreaCategorie frmCreaCategorie = new FrmCreaCategorie();
            frmCreaCategorie.ShowDialog();
            PopolaComboBox();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNome.Text) || cbCategoria.SelectedIndex == -1 || !(rbStatoAperto.Checked || rbStatoChiuso.Checked)|| !(rbAnonimo.Checked || rbRegistrati.Checked))
                MessageBox.Show("Compilare tutti i campi", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string nomeFormattato = tbNome.Text.Trim().ToUpper().Substring(0, 1) + tbNome.Text.Trim().ToLower().Substring(1);
                ClsCategoria catSelezionata = DB.Categorie[cbCategoria.SelectedIndex];

                if (modifica)
                {
                    DB.Sondaggi[indice].Nome = nomeFormattato;
                    DB.Sondaggi[indice].Aperto = rbStatoAperto.Checked;
                    DB.Sondaggi[indice].Anonimo = rbAnonimo.Checked;
                    DB.Sondaggi[indice].Categoria = catSelezionata;

                    MessageBox.Show("Sondaggio modificato con successo!", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    modifica = false;
                    btnAggiungi.Text = "Aggiungi";
                }
                else
                {
                    if (DB.Sondaggi.Any(s => s.Nome.ToLower() == tbNome.Text.ToLower()))
                        MessageBox.Show("Sondaggio già esistente!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        ClsSondaggio nuovoSondaggio = new ClsSondaggio(DB.ContIDsondaggio, rbStatoAperto.Checked, rbAnonimo.Checked, nomeFormattato, DateTime.Now);
                        nuovoSondaggio.Categoria = catSelezionata;

                        DB.Sondaggi.Add(nuovoSondaggio);
                        DB.ContIDsondaggio++;
                        MessageBox.Show("Sondaggio aggiunto con successo!", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                tbNome.Text = "";
                cbCategoria.SelectedIndex = -1;
                rbStatoAperto.Checked = false;
                rbStatoChiuso.Checked = false;
                rbAnonimo.Checked = false;
                rbRegistrati.Checked = false;
                DB.SalvaDati();             
                PopolaListView(DB.Sondaggi);   
            }
        }

        private void PopolaListView(List<ClsSondaggio> sondaggi)
        {
            lvDomande.Items.Clear();

            for (int i = 0; i < sondaggi.Count; i++)
            {
                ClsSondaggio s = sondaggi[i];
                ListViewItem lvi = new ListViewItem(s.ID.ToString());
                lvi.SubItems.Add(s.Nome);
                lvi.SubItems.Add(s.NumeroDomande.ToString());
                lvi.SubItems.Add(s.Categoria.Nome);

                if (s.Aperto)
                    lvi.SubItems.Add("Aperto");
                else
                    lvi.SubItems.Add("Chiuso");

                if (s.Anonimo)
                    lvi.SubItems.Add("Anonimo");
                else
                    lvi.SubItems.Add("Registrati");

                lvi.SubItems.Add(s.DataCreazione.ToString("dd/MM/yyyy"));
                lvi.Tag = s;

                lvDomande.Items.Add(lvi);
            }
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            tbNome.Text = "";
            cbCategoria.SelectedIndex = -1;
            rbStatoAperto.Checked = false;
            rbStatoChiuso.Checked = false;
            rbAnonimo.Checked = false;
            rbRegistrati.Checked = false;
            modifica = false;
        }

        private void cbDomande_SelectedIndexChanged(object sender, EventArgs e)
        {
            TogliFiltri();
            CaricaFiltro(cbDomandeFiltro.SelectedIndex);
        }

        private void TogliFiltri()
        {
            pnlFiltroID.Visible = false;
            pnlFiltroStato.Visible = false;
            pnlFiltroTipo.Visible = false;
            pnlFiltroNome.Visible = false;
            pnlFiltroData.Visible = false;
        }

        private void CaricaFiltro(int scelta)
        {
            switch (scelta)
            {
                case 0:
                    nudID.Value = 0;
                    pnlFiltroID.Visible = true;
                        break;

                case 1:
                    rbFiltroChiuso.Checked = false;
                    rbFiltroAperto.Checked = false;
                    pnlFiltroStato.Visible = true;
                    break;

                case 2:
                    rbFiltroAnonimo.Checked = false;
                    rbFiltroAnonimo.Checked = false;
                    pnlFiltroTipo.Visible = true;
                    break;

                case 3:
                    tbFiltroNome.Text = String.Empty;
                    pnlFiltroNome.Visible = true;
                    break;

                case 4:
                    dtpFiltroData.Value = DateTime.Today;
                    pnlFiltroData.Visible = true;
                    break;
            }
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            if (lvDomande.SelectedItems.Count == 0)
                MessageBox.Show("Selezionare un sondaggio da eliminare!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                DialogResult dr = MessageBox.Show("Sei sicuro di voler eliminare questo sondaggio?", "Conferma", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    ClsSondaggio s = (ClsSondaggio)lvDomande.SelectedItems[0].Tag;
                    DB.Sondaggi.Remove(s); 
                    DB.SalvaDati();
                    PopolaListView(DB.Sondaggi);
                    MessageBox.Show("Sondaggio eliminato!");
                }
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (lvDomande.SelectedItems.Count == 0)
                MessageBox.Show("Selezionare un sondaggio da modificare!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                ClsSondaggio s = (ClsSondaggio)lvDomande.SelectedItems[0].Tag;

                int i = 0;
                bool trovato = false;
                while (i < DB.Sondaggi.Count && !trovato)
                {
                    if (DB.Sondaggi[i].ID == s.ID)
                    {
                        indice = i; 
                        trovato = true;
                    }
                    i++;
                }

                if (trovato)
                {
                    tbNome.Text = s.Nome;
                    if (s.Aperto)
                    {
                        rbStatoAperto.Checked = true;
                        rbStatoChiuso.Checked = false;
                    }
                    else
                    {
                        rbStatoAperto.Checked = false;
                        rbStatoChiuso.Checked = true;
                    }

                    if (s.Anonimo)
                    {
                        rbAnonimo.Checked = true;
                        rbRegistrati.Checked = false;
                    }
                    else
                    {
                        rbAnonimo.Checked = false;
                        rbRegistrati.Checked = true;
                    }

                    if (s.Categoria != null)
                    {
                        int c = 0;
                        bool catTrovata = false;
                        while (c < cbCategoria.Items.Count && !catTrovata)
                        {
                            if (cbCategoria.Items[c].ToString() == s.Categoria.Nome)
                            {
                                cbCategoria.SelectedIndex = c;
                                catTrovata = true;
                            }
                            c++;
                        }
                    }

                    modifica = true;
                    btnAggiungi.Text = "Aggiorna"; 
                    PopolaListView(DB.Sondaggi);
                }
            }
        }

        private void btnStatistiche_Click(object sender, EventArgs e)
        {
            FrmStatistiche frmStatistiche = new FrmStatistiche();
            frmStatistiche.ShowDialog();
        }

        private void FrmCreaSondaggi_FormClosing(object sender, FormClosingEventArgs e)
        {
            DB.SalvaDati();
        }

        private void rbAperto_CheckedChanged(object sender, EventArgs e)
        {
            FiltraLista();
        }

        private void FiltraLista()
        {
            List<ClsSondaggio> listaFiltrata = admin.Cerca(scelta: cbDomandeFiltro.SelectedIndex,
                                                            id: (int)nudID.Value,
                                                            stato: rbFiltroAperto.Checked,
                                                            tipo: rbFiltroAnonimo.Checked,
                                                            nome: tbFiltroNome.Text.Trim(),
                                                            data: dtpFiltroData.Value,
                                                            sondaggi: DB.Sondaggi
                                                            );
            PopolaListView(listaFiltrata);
        }

        private void rbChiuso_CheckedChanged(object sender, EventArgs e)
        {
            FiltraLista();
        }

        private void nudID_ValueChanged(object sender, EventArgs e)
        {
            FiltraLista();
        }

        private void dtpFiltroData_ValueChanged(object sender, EventArgs e)
        {
            FiltraLista();
        }

        private void tbFiltroNome_TextChanged(object sender, EventArgs e)
        {
            FiltraLista();
        }

        private void rbFiltroRegistrato_CheckedChanged(object sender, EventArgs e)
        {
            FiltraLista();

        }

        private void rbFiltroAnonimo_CheckedChanged(object sender, EventArgs e)
        {
            FiltraLista();

        }

        private void btnUtenti_Click(object sender, EventArgs e)
        {
            FrmUtenti frmUtenti = new FrmUtenti();
            frmUtenti.ShowDialog();
        }

        private void btnRisposteStandard_Click(object sender, EventArgs e)
        {
            FrmRaggruppaRisposteAperte frmRaggruppaRisposteAperte = new FrmRaggruppaRisposteAperte();
            frmRaggruppaRisposteAperte.ShowDialog();
        }
    }
}
