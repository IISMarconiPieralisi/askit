using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace sondaggio
{
    public partial class FrmUtenti : Form
    {
        int indice;
        bool modifica = false;
        List<ClsUtente> utenti = new List<ClsUtente>();
        public FrmUtenti()
        {
            InitializeComponent();
        }

        private void FrmUtenti_Load(object sender, EventArgs e)
        {
            CaricaComboBox();
            SincronizzaDati();
        }
        private void SincronizzaDati()
        {
            utenti.Clear();
            utenti.AddRange(DB.Intervistati);
            utenti.AddRange(DB.Admin);
            PopolaListView(utenti);
        }
        private void CaricaComboBox()
        {
            cbComune.Items.Clear();
            foreach (string comune in Enum.GetNames(typeof(ClsUtente.eCOMUNE)))
                cbComune.Items.Add(comune);
        }

        private void btnTornaIndietro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbFiltroNome_TextChanged(object sender, EventArgs e)
        {
            string filtro = tbFiltroNome.Text.Trim().ToLower();
            List<ClsUtente> utentiFiltrati = utenti.FindAll(app => app.Nome.ToLower().Contains(filtro) || app.Cognome.ToLower().Contains(filtro));

            PopolaListView(utentiFiltrati);
        }
        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNome.Text) ||
                string.IsNullOrWhiteSpace(tbCognome.Text) ||
                string.IsNullOrWhiteSpace(tbUsername.Text) ||
                string.IsNullOrWhiteSpace(tbPassword.Text) ||
                string.IsNullOrWhiteSpace(tbEmail.Text) ||
                cbComune.SelectedIndex == -1)
                MessageBox.Show("Compilare tutti i campi", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                ClsUtente.eSESSO sesso = rbM.Checked ? ClsUtente.eSESSO.maschio : ClsUtente.eSESSO.femmina;
                ClsUtente.eCOMUNE comune = (ClsUtente.eCOMUNE)cbComune.SelectedIndex;

                if (rbAdmin.Checked)
                {
                    if (modifica)
                    {
                        DB.Admin[indice].Nome = tbNome.Text.Trim();
                        DB.Admin[indice].Cognome = tbCognome.Text.Trim();
                        DB.Admin[indice].Username = tbUsername.Text.Trim();
                        DB.Admin[indice].Password = tbPassword.Text.Trim();
                        DB.Admin[indice].DataDiNascita = dtmDataDiNascita.Value;
                        DB.Admin[indice].ComuneDiNascita = comune;
                        DB.Admin[indice].Sesso = sesso;
                        DB.Admin[indice].Email = tbEmail.Text.Trim();
                        MessageBox.Show("Admin aggiornato!", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        ClsAdmin nuovoAdmin = new ClsAdmin(tbUsername.Text.Trim(), tbPassword.Text.Trim(), tbNome.Text.Trim(), tbCognome.Text.Trim(), dtmDataDiNascita.Value, comune, sesso, tbEmail.Text.Trim());
                        DB.Admin.Add(nuovoAdmin);
                        MessageBox.Show("Admin aggiunto!", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (modifica)
                    {
                        DB.Intervistati[indice].Nome = tbNome.Text.Trim();
                        DB.Intervistati[indice].Cognome = tbCognome.Text.Trim();
                        DB.Intervistati[indice].Username = tbUsername.Text.Trim();
                        DB.Intervistati[indice].Password = tbPassword.Text.Trim();
                        DB.Intervistati[indice].DataDiNascita = dtmDataDiNascita.Value;
                        DB.Intervistati[indice].ComuneDiNascita = comune;
                        DB.Intervistati[indice].Sesso = sesso;
                        DB.Intervistati[indice].Email = tbEmail.Text.Trim();
                        MessageBox.Show("Intervistato aggiornato!", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        ClsIntervistato nuovoIntervistato = new ClsIntervistato(tbUsername.Text.Trim(), tbPassword.Text.Trim(), tbNome.Text.Trim(), tbCognome.Text.Trim(), dtmDataDiNascita.Value, comune, sesso, tbEmail.Text.Trim());
                        DB.Intervistati.Add(nuovoIntervistato);
                        MessageBox.Show("Intervistato aggiunto!", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                DB.SalvaUtenti(); 
                SincronizzaDati();
                ResetCampi();
            }
        }

        private void PopolaListView(List<ClsUtente> lista)
        {
            lvUtenti.Items.Clear(); 
            foreach (ClsUtente utente in lista)
            {
                string ruolo = (utente is ClsAdmin) ? "Admin" : "Intervistato";
                ListViewItem lvi = new ListViewItem(ruolo);
                lvi.SubItems.Add(utente.Nome + " " + utente.Cognome);
                lvi.SubItems.Add(utente.Username);
                lvi.SubItems.Add(utente.Password);
                lvi.Tag = utente;
                lvUtenti.Items.Add(lvi);
            }
        }
        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            ResetCampi();
        }

        private void ResetCampi()
        {
            tbNome.Clear();
            tbCognome.Clear();
            tbUsername.Clear();
            tbPassword.Clear();
            tbEmail.Clear();
            cbComune.SelectedIndex = -1;
            dtmDataDiNascita.Value = DateTime.Today;
            rbM.Checked = true;
            rbAdmin.Checked = false;
            ImpostaStatoControlli(false);
            btnAggiungi.Enabled = true;
            btnAggiungi.Text = "Aggiungi";
            modifica = false;
            tbPassword.UseSystemPasswordChar = true;
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            if (lvUtenti.SelectedItems.Count > 0)
            {
                ClsUtente utente = (ClsUtente)lvUtenti.SelectedItems[0].Tag;
                CaricaDatiNeiControlli(utente);
                ImpostaStatoControlli(true);
                btnAggiungi.Enabled = false;
                tbPassword.UseSystemPasswordChar = false;
            }
            else
                MessageBox.Show("Seleziona un utente", "Avviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void CaricaDatiNeiControlli(ClsUtente u)
        {
            tbNome.Text = u.Nome;
            tbCognome.Text = u.Cognome;
            tbUsername.Text = u.Username;
            tbPassword.Text = u.Password;
            tbEmail.Text = u.Email;
            dtmDataDiNascita.Value = u.DataDiNascita;
            cbComune.SelectedItem = u.ComuneDiNascita.ToString();
            rbM.Checked = (u.Sesso == ClsUtente.eSESSO.maschio);
            rbF.Checked = (u.Sesso == ClsUtente.eSESSO.femmina);
            rbAdmin.Checked = (u is ClsAdmin);
        }
        private void ImpostaStatoControlli(bool soloLettura)
        {
            tbNome.ReadOnly = tbCognome.ReadOnly = tbUsername.ReadOnly = tbPassword.ReadOnly = tbEmail.ReadOnly = soloLettura;
            cbComune.Enabled = dtmDataDiNascita.Enabled = rbM.Enabled =rbF.Enabled = rbAdmin.Enabled = !soloLettura;
            if (rbIntervistato != null)
                rbIntervistato.Enabled = !soloLettura;
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (lvUtenti.SelectedItems.Count > 0)
            {
                ClsUtente utente = (ClsUtente)lvUtenti.SelectedItems[0].Tag;
                modifica = true;
                CaricaDatiNeiControlli(utente);
                ImpostaStatoControlli(false);

                btnAggiungi.Text = "Aggiorna";
                btnAggiungi.Enabled = true;

                if (utente is ClsAdmin)
                    indice = DB.Admin.IndexOf((ClsAdmin)utente);
                else
                    indice = DB.Intervistati.IndexOf((ClsIntervistato)utente);
            }
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            if (lvUtenti.SelectedItems.Count > 0)
            {
                ClsUtente utente = (ClsUtente)lvUtenti.SelectedItems[0].Tag;
                if (MessageBox.Show("Eliminare l'utente?", "Conferma", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (utente is ClsAdmin)
                        DB.Admin.Remove((ClsAdmin)utente);
                    else
                        DB.Intervistati.Remove((ClsIntervistato)utente);

                    DB.SalvaDati();
                    SincronizzaDati();
                    ResetCampi();
                }
            }
        }
    }
}
