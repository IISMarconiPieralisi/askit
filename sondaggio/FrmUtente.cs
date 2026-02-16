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
    public partial class FrmUtente : Form
    {
        bool accesso = false;
        public FrmUtente()
        {        
            InitializeComponent();
        }

        private void FrmUtente_Load(object sender, EventArgs e)
        {
            DB.CaricaUtenti();
            foreach (string comune in Enum.GetNames(typeof(ClsUtente.eCOMUNE)))
                cbComune.Items.Add(comune);
        }
        private void btnRegistrati_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNome.Text) ||
                   string.IsNullOrWhiteSpace(tbCognome.Text) ||
                   string.IsNullOrWhiteSpace(tbEmail.Text) ||
                   string.IsNullOrWhiteSpace(tbUsername.Text) ||
                   string.IsNullOrWhiteSpace(tbCreaPassword.Text) ||
                   cbComune.SelectedIndex == -1 ||
                   (!rbM.Checked && !rbF.Checked))
                MessageBox.Show("Compilare tutti i campi!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (DB.Intervistati.Any(i => i.Username == tbUsername.Text))
                MessageBox.Show("Username già esistente!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (tbUsername.Name.StartsWith("Guest-"))
                MessageBox.Show("Il tuo Username non può iniziare con Guest-", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {

                ClsIntervistato intervistato = new ClsIntervistato();
                intervistato.Nome = tbNome.Text;
                intervistato.Cognome = tbCognome.Text;
                intervistato.Email = tbEmail.Text;
                intervistato.Username = tbUsername.Text;
                intervistato.Password = tbCreaPassword.Text;
                intervistato.ComuneDiNascita = (ClsUtente.eCOMUNE)cbComune.SelectedIndex;
                intervistato.Sesso = rbM.Checked ? ClsUtente.eSESSO.maschio : ClsUtente.eSESSO.femmina;
                intervistato.DataDiNascita = dtmDataDiNascita.Value;

                DB.Intervistati.Add(intervistato);
                DB.UtenteLoggato = intervistato;

                tbNome.Text = "";
                tbCognome.Text = "";
                tbEmail.Text = "";
                tbUsername.Text = "";
                tbCreaPassword.Text = "";
                cbComune.SelectedIndex = -1;
                rbM.Checked = false;
                rbF.Checked = false;

                MessageBox.Show("Registrazione effettuata con successo!", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FrmFaiSondaggi frmFaiSondaggi = new FrmFaiSondaggi();
                this.Hide();
                frmFaiSondaggi.ShowDialog();
                this.Close();
            }
        }
        private void btnAccedi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPasswordAccedi.Text) || string.IsNullOrWhiteSpace(tbUsernameAccedi.Text))
                MessageBox.Show("Inserire username e password!");
            else
            {
                int i = 0;
                accesso = false;

                while (i < DB.Intervistati.Count && !accesso)
                {
                    if (DB.Intervistati[i].Username == tbUsernameAccedi.Text &&
                        DB.Intervistati[i].Password == tbPasswordAccedi.Text)
                    {
                        DB.UtenteLoggato = DB.Intervistati[i];
                        FrmFaiSondaggi frmFaiSondaggi = new FrmFaiSondaggi();
                        this.Hide();
                        accesso = true;
                        frmFaiSondaggi.ShowDialog();
                        this.Close();
                    }
                    i++;
                }
                i = 0;

                while (i < DB.Admin.Count && !accesso)
                {
                    if (DB.Admin[i].Username == tbUsernameAccedi.Text &&
                        DB.Admin[i].Password == tbPasswordAccedi.Text)
                    {
                        DB.UtenteLoggato = DB.Admin[i];
                        FrmCreaSondaggi frmCreaSondaggi = new FrmCreaSondaggi();
                        this.Hide();
                        accesso = true;
                        frmCreaSondaggi.ShowDialog();
                        this.Close();
                    }
                    i++;
                }

                if (!accesso)
                    MessageBox.Show("Credenziali errate! Se non sei registrato, registrati prima.", "Attenzione",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void FrmUtente_FormClosing(object sender, FormClosingEventArgs e)
        {
            DB.SalvaUtenti();
        }

        private void btnMostraPassAccesso_MouseDown(object sender, MouseEventArgs e)
        {
            btnMostraPassAccesso.ForeColor = Color.DodgerBlue;
            tbPasswordAccedi.UseSystemPasswordChar = false;
        }

        private void btnMostraPassAccesso_MouseUp(object sender, MouseEventArgs e)
        {
            btnMostraPassAccesso.ForeColor = Color.Black;
            tbPasswordAccedi.UseSystemPasswordChar = true;
        }

        private void btnMostraPassLogin_MouseDown(object sender, MouseEventArgs e)
        {
            btnMostraPassLogin.ForeColor = Color.DodgerBlue;
            tbCreaPassword.UseSystemPasswordChar = false;
        }

        private void btnMostraPassLogin_MouseUp(object sender, MouseEventArgs e)
        {
            btnMostraPassLogin.ForeColor = Color.Black;
            tbCreaPassword.UseSystemPasswordChar = true;
        }

        private void llblGuest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Random rnd = new Random();
            int numeroCasuale = rnd.Next(1, 99999);
            string usernameGuest = "Guest-" + numeroCasuale;

            while (DB.Intervistati.Any(i => i.Username == usernameGuest) || DB.Admin.Any(a => a.Username == usernameGuest))
            {
                DB.ContIDsondaggio++;
                usernameGuest = "Guest-" + numeroCasuale;
            }

            ClsIntervistato guest = new ClsIntervistato(
                usernameGuest,
                "guest",  
                "Guest",
                "Anonimo",
                DateTime.Now,
                ClsUtente.eCOMUNE.Ancona, 
                ClsUtente.eSESSO.maschio,  
                "guest@ask.it"        
            );

            DB.Intervistati.Add(guest);
            DB.UtenteLoggato = guest;
            DB.SalvaUtenti();

            FrmFaiSondaggi frmFaiSondaggi = new FrmFaiSondaggi();
            this.Hide();
            frmFaiSondaggi.ShowDialog();
            this.Close();
        }
    }
}
