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
    public partial class FrmCreaCategorie : Form
    {
        bool _modifica = false;
        int _indice;
        public FrmCreaCategorie()
        {
            InitializeComponent();
        }
        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            tbNomeCategoria.Text = "";
            _modifica = false;
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNomeCategoria.Text))
                MessageBox.Show("Inserire il nome della categoria!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (_modifica)
                {
                    string nomeFormattato = tbNomeCategoria.Text.Trim().ToUpper().Substring(0, 1) + tbNomeCategoria.Text.Trim().ToLower().Substring(1);
                    DB.Categorie[_indice].Nome = nomeFormattato;
                    MessageBox.Show("Categoria modificata con successo!", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _modifica = false;
                }
                else
                {
                    if (DB.Categorie.Any(c => c.Nome.ToLower() == tbNomeCategoria.Text.ToLower()))
                        MessageBox.Show("Categoria già esistente!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        string nomeFormattato = tbNomeCategoria.Text.Trim().ToUpper().Substring(0, 1) + tbNomeCategoria.Text.Trim().ToLower().Substring(1);
                        ClsCategoria categoria = new ClsCategoria(nomeFormattato);
                        DB.Categorie.Add(categoria);
                        MessageBox.Show("Categoria aggiunta con successo!!!!!!!!", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    tbNomeCategoria.Text = "";
                }
                PopolaListBox(DB.Categorie);
            }
        }

      
        private void PopolaListBox(List<ClsCategoria> categorie)
        {
            lbCategorie.Items.Clear();
            foreach (ClsCategoria categoria in categorie)
                lbCategorie.Items.Add(categoria.Nome);
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (lbCategorie.SelectedItems.Count == 0)
                MessageBox.Show("Selezionare una categoria da modificare!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                btnSalva.Text = "Aggiorna";
                _indice = (int)lbCategorie.SelectedIndex;
                tbNomeCategoria.Text = DB.Categorie[_indice].Nome;
                _modifica = true;
            }
            btnSalva.Text = "Aggiungi";
        }
        private void btnElimina_Click(object sender, EventArgs e)
        {
            if (lbCategorie.SelectedItems.Count == 0)
                MessageBox.Show("Selezionare una categoria da eliminare!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                DialogResult dr = MessageBox.Show("Sei sicuro di voler eliminare questa categoria?", "Conferma", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    _indice = Convert.ToInt32(lbCategorie.SelectedIndex);
                    DB.Categorie.RemoveAt(_indice);
                    PopolaListBox(DB.Categorie);
                    MessageBox.Show("Categoria eliminata!", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void tbCategoria_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbCategoria.Text))
                PopolaListBox(DB.Categorie);
            else
            {
                string filtro = tbCategoria.Text.Trim().ToLower();
                List<ClsCategoria> categorieFiltrate = DB.Categorie.FindAll(categorie => categorie.Nome.Contains(filtro));

                if (categorieFiltrate.Count == 0)
                {
                    MessageBox.Show($"Nessuna categoria trovato per '{tbCategoria.Text}'", "Ricerca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PopolaListBox(DB.Categorie);
                }
                else
                    PopolaListBox(categorieFiltrate);
            }
        }

        private void btnTornaIndietro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCreaCategorie_FormClosing(object sender, FormClosingEventArgs e)
        {
            DB.SalvaDati();
        }

        private void FrmCreaCategorie_Load(object sender, EventArgs e)
        {
            PopolaListBox(DB.Categorie);
        }
    }
}