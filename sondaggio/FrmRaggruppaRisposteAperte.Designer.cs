namespace sondaggio
{
    partial class FrmRaggruppaRisposteAperte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTornaIndietro = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.btnModifica = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.tbRispostaStandard = new System.Windows.Forms.TextBox();
            this.btnAssocia = new System.Windows.Forms.Button();
            this.btnElimina = new System.Windows.Forms.Button();
            this.lvRisposte = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbDomande = new System.Windows.Forms.ListBox();
            this.cbSondaggi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tbRisposta = new System.Windows.Forms.TextBox();
            this.btnModificaSingoli = new System.Windows.Forms.Button();
            this.btnEliminaSingoli = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTornaIndietro
            // 
            this.btnTornaIndietro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTornaIndietro.Location = new System.Drawing.Point(19, 12);
            this.btnTornaIndietro.Name = "btnTornaIndietro";
            this.btnTornaIndietro.Size = new System.Drawing.Size(241, 40);
            this.btnTornaIndietro.TabIndex = 134;
            this.btnTornaIndietro.Text = "↩️Torna ai Sondaggi";
            this.btnTornaIndietro.UseVisualStyleBackColor = true;
            this.btnTornaIndietro.Click += new System.EventHandler(this.btnTornaIndietro_Click_1);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Gray;
            this.label18.Location = new System.Drawing.Point(15, 55);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 24);
            this.label18.TabIndex = 131;
            // 
            // btnModifica
            // 
            this.btnModifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifica.Location = new System.Drawing.Point(473, 391);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(235, 36);
            this.btnModifica.TabIndex = 128;
            this.btnModifica.Text = "✍️Modifica Standard";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnAnnulla);
            this.panel1.Controls.Add(this.tbRispostaStandard);
            this.panel1.Controls.Add(this.btnAssocia);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1085, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 455);
            this.panel1.TabIndex = 127;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(14, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 24);
            this.label1.TabIndex = 75;
            this.label1.Text = "Nome Risposta Standard";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 25);
            this.label3.TabIndex = 77;
            this.label3.Text = "📊";
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulla.Location = new System.Drawing.Point(155, 131);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(117, 34);
            this.btnAnnulla.TabIndex = 6;
            this.btnAnnulla.Text = "↩️ Annulla";
            this.btnAnnulla.UseVisualStyleBackColor = true;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // tbRispostaStandard
            // 
            this.tbRispostaStandard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRispostaStandard.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbRispostaStandard.Location = new System.Drawing.Point(45, 91);
            this.tbRispostaStandard.Name = "tbRispostaStandard";
            this.tbRispostaStandard.Size = new System.Drawing.Size(227, 31);
            this.tbRispostaStandard.TabIndex = 76;
            // 
            // btnAssocia
            // 
            this.btnAssocia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssocia.Location = new System.Drawing.Point(18, 128);
            this.btnAssocia.Name = "btnAssocia";
            this.btnAssocia.Size = new System.Drawing.Size(131, 41);
            this.btnAssocia.TabIndex = 5;
            this.btnAssocia.Text = "➕Associa";
            this.btnAssocia.UseVisualStyleBackColor = true;
            this.btnAssocia.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnElimina
            // 
            this.btnElimina.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElimina.Location = new System.Drawing.Point(714, 393);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(226, 34);
            this.btnElimina.TabIndex = 129;
            this.btnElimina.Text = "🗑️Elimina Standard";
            this.btnElimina.UseVisualStyleBackColor = true;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // lvRisposte
            // 
            this.lvRisposte.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvRisposte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lvRisposte.FullRowSelect = true;
            this.lvRisposte.HideSelection = false;
            this.lvRisposte.Location = new System.Drawing.Point(265, 121);
            this.lvRisposte.Name = "lvRisposte";
            this.lvRisposte.Size = new System.Drawing.Size(675, 266);
            this.lvRisposte.TabIndex = 135;
            this.lvRisposte.UseCompatibleStateImageBehavior = false;
            this.lvRisposte.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Risposta Data";
            this.columnHeader1.Width = 296;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Risposta Standard";
            this.columnHeader2.Width = 366;
            // 
            // lbDomande
            // 
            this.lbDomande.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lbDomande.FormattingEnabled = true;
            this.lbDomande.ItemHeight = 25;
            this.lbDomande.Location = new System.Drawing.Point(19, 98);
            this.lbDomande.Name = "lbDomande";
            this.lbDomande.Size = new System.Drawing.Size(241, 329);
            this.lbDomande.TabIndex = 137;
            this.lbDomande.SelectedIndexChanged += new System.EventHandler(this.lbDomande_SelectedIndexChanged);
            // 
            // cbSondaggi
            // 
            this.cbSondaggi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.cbSondaggi.FormattingEnabled = true;
            this.cbSondaggi.Location = new System.Drawing.Point(19, 58);
            this.cbSondaggi.Name = "cbSondaggi";
            this.cbSondaggi.Size = new System.Drawing.Size(241, 33);
            this.cbSondaggi.TabIndex = 136;
            this.cbSondaggi.SelectedIndexChanged += new System.EventHandler(this.cbSondaggi_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(266, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 24);
            this.label2.TabIndex = 138;
            this.label2.Text = "Cerca per risposta data";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(265, 84);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(34, 25);
            this.label19.TabIndex = 140;
            this.label19.Text = "🔎";
            // 
            // tbRisposta
            // 
            this.tbRisposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRisposta.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbRisposta.Location = new System.Drawing.Point(297, 84);
            this.tbRisposta.Name = "tbRisposta";
            this.tbRisposta.Size = new System.Drawing.Size(227, 31);
            this.tbRisposta.TabIndex = 139;
            this.tbRisposta.TextChanged += new System.EventHandler(this.tbRisposta_TextChanged);
            // 
            // btnModificaSingoli
            // 
            this.btnModificaSingoli.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificaSingoli.Location = new System.Drawing.Point(946, 121);
            this.btnModificaSingoli.Name = "btnModificaSingoli";
            this.btnModificaSingoli.Size = new System.Drawing.Size(133, 64);
            this.btnModificaSingoli.TabIndex = 141;
            this.btnModificaSingoli.Text = "✍️Modifica Singoli";
            this.btnModificaSingoli.UseVisualStyleBackColor = true;
            this.btnModificaSingoli.Click += new System.EventHandler(this.btnModificaSingoli_Click);
            // 
            // btnEliminaSingoli
            // 
            this.btnEliminaSingoli.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminaSingoli.Location = new System.Drawing.Point(946, 191);
            this.btnEliminaSingoli.Name = "btnEliminaSingoli";
            this.btnEliminaSingoli.Size = new System.Drawing.Size(133, 64);
            this.btnEliminaSingoli.TabIndex = 142;
            this.btnEliminaSingoli.Text = "🗑️Elimina Singoli";
            this.btnEliminaSingoli.UseVisualStyleBackColor = true;
            this.btnEliminaSingoli.Click += new System.EventHandler(this.btnEliminaSingoli_Click);
            // 
            // FrmRaggruppaRisposteAperte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 455);
            this.Controls.Add(this.btnEliminaSingoli);
            this.Controls.Add(this.btnModificaSingoli);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.tbRisposta);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.lvRisposte);
            this.Controls.Add(this.lbDomande);
            this.Controls.Add(this.btnTornaIndietro);
            this.Controls.Add(this.cbSondaggi);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.panel1);
            this.Name = "FrmRaggruppaRisposteAperte";
            this.Text = "FrmRaggruppaRisposteAperte";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmRaggruppaRisposteAperte_FormClosing);
            this.Load += new System.EventHandler(this.FrmRaggruppaRisposteAperte_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTornaIndietro;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAnnulla;
        private System.Windows.Forms.TextBox tbRispostaStandard;
        private System.Windows.Forms.Button btnAssocia;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.ListView lvRisposte;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListBox lbDomande;
        private System.Windows.Forms.ComboBox cbSondaggi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbRisposta;
        private System.Windows.Forms.Button btnModificaSingoli;
        private System.Windows.Forms.Button btnEliminaSingoli;
    }
}