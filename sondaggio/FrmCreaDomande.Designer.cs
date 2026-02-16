namespace sondaggio
{
    partial class FrmCreaDomande
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbMultiple = new System.Windows.Forms.RadioButton();
            this.rbAperta = new System.Windows.Forms.RadioButton();
            this.lblDomanda = new System.Windows.Forms.Label();
            this.rtbTesto = new System.Windows.Forms.RichTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudOrdine = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.rbSiNo = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnElimina = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.lvDomande = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbDomande = new System.Windows.Forms.ComboBox();
            this.btnGestisciRisposte = new System.Windows.Forms.Button();
            this.rbSingola = new System.Windows.Forms.RadioButton();
            this.lblSondaggioID = new System.Windows.Forms.Label();
            this.btnTornaIndietro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrdine)).BeginInit();
            this.SuspendLayout();
            // 
            // rbMultiple
            // 
            this.rbMultiple.AutoSize = true;
            this.rbMultiple.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.rbMultiple.Location = new System.Drawing.Point(930, 215);
            this.rbMultiple.Name = "rbMultiple";
            this.rbMultiple.Size = new System.Drawing.Size(171, 29);
            this.rbMultiple.TabIndex = 24;
            this.rbMultiple.TabStop = true;
            this.rbMultiple.Text = "Scelta Multipla";
            this.rbMultiple.UseVisualStyleBackColor = true;
            // 
            // rbAperta
            // 
            this.rbAperta.AutoSize = true;
            this.rbAperta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.rbAperta.Location = new System.Drawing.Point(715, 215);
            this.rbAperta.Name = "rbAperta";
            this.rbAperta.Size = new System.Drawing.Size(93, 29);
            this.rbAperta.TabIndex = 23;
            this.rbAperta.TabStop = true;
            this.rbAperta.Text = "Aperta";
            this.rbAperta.UseVisualStyleBackColor = true;
            this.rbAperta.CheckedChanged += new System.EventHandler(this.rbAperta_CheckedChanged);
            // 
            // lblDomanda
            // 
            this.lblDomanda.AutoSize = true;
            this.lblDomanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomanda.Location = new System.Drawing.Point(673, 91);
            this.lblDomanda.Name = "lblDomanda";
            this.lblDomanda.Size = new System.Drawing.Size(235, 37);
            this.lblDomanda.TabIndex = 17;
            this.lblDomanda.Text = "Crea Domanda";
            // 
            // rtbTesto
            // 
            this.rtbTesto.Location = new System.Drawing.Point(715, 279);
            this.rtbTesto.Name = "rtbTesto";
            this.rtbTesto.Size = new System.Drawing.Size(574, 193);
            this.rtbTesto.TabIndex = 14;
            this.rtbTesto.Text = "";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Gray;
            this.label18.Location = new System.Drawing.Point(676, 250);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 24);
            this.label18.TabIndex = 72;
            this.label18.Text = "Testo";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(675, 279);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(34, 25);
            this.label19.TabIndex = 74;
            this.label19.Text = "📝";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(676, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 75;
            this.label1.Text = "Ordine";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(675, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 25);
            this.label2.TabIndex = 76;
            this.label2.Text = "🥇";
            // 
            // nudOrdine
            // 
            this.nudOrdine.Location = new System.Drawing.Point(715, 155);
            this.nudOrdine.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudOrdine.Name = "nudOrdine";
            this.nudOrdine.Size = new System.Drawing.Size(120, 31);
            this.nudOrdine.TabIndex = 77;
            this.nudOrdine.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(676, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 24);
            this.label3.TabIndex = 78;
            this.label3.Text = "Tipologia";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(675, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 25);
            this.label4.TabIndex = 79;
            this.label4.Text = "📝";
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggiungi.Location = new System.Drawing.Point(715, 475);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(451, 36);
            this.btnAggiungi.TabIndex = 80;
            this.btnAggiungi.Text = "➕Aggiungi";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulla.Location = new System.Drawing.Point(1172, 478);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(117, 31);
            this.btnAnnulla.TabIndex = 81;
            this.btnAnnulla.Text = "↩️ Annulla";
            this.btnAnnulla.UseVisualStyleBackColor = true;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // rbSiNo
            // 
            this.rbSiNo.AutoSize = true;
            this.rbSiNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.rbSiNo.Location = new System.Drawing.Point(826, 215);
            this.rbSiNo.Name = "rbSiNo";
            this.rbSiNo.Size = new System.Drawing.Size(82, 29);
            this.rbSiNo.TabIndex = 82;
            this.rbSiNo.TabStop = true;
            this.rbSiNo.Text = "Sì/No";
            this.rbSiNo.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(15, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 24);
            this.label5.TabIndex = 86;
            this.label5.Text = "Cerca per titolo Domanda";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(14, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 25);
            this.label6.TabIndex = 88;
            this.label6.Text = "🔎";
            // 
            // btnElimina
            // 
            this.btnElimina.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElimina.Location = new System.Drawing.Point(496, 193);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(133, 34);
            this.btnElimina.TabIndex = 84;
            this.btnElimina.Text = "🗑️Elimina";
            this.btnElimina.UseVisualStyleBackColor = true;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifica.Location = new System.Drawing.Point(496, 153);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(133, 34);
            this.btnModifica.TabIndex = 83;
            this.btnModifica.Text = "✍️Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // lvDomande
            // 
            this.lvDomande.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvDomande.FullRowSelect = true;
            this.lvDomande.HideSelection = false;
            this.lvDomande.Location = new System.Drawing.Point(19, 153);
            this.lvDomande.Name = "lvDomande";
            this.lvDomande.Size = new System.Drawing.Size(471, 358);
            this.lvDomande.TabIndex = 89;
            this.lvDomande.UseCompatibleStateImageBehavior = false;
            this.lvDomande.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ordine";
            this.columnHeader1.Width = 98;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tipo";
            this.columnHeader2.Width = 126;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Testo";
            this.columnHeader3.Width = 235;
            // 
            // cbDomande
            // 
            this.cbDomande.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDomande.FormattingEnabled = true;
            this.cbDomande.Location = new System.Drawing.Point(55, 114);
            this.cbDomande.Name = "cbDomande";
            this.cbDomande.Size = new System.Drawing.Size(240, 33);
            this.cbDomande.TabIndex = 94;
            this.cbDomande.SelectedIndexChanged += new System.EventHandler(this.cbDomande_SelectedIndexChanged);
            // 
            // btnGestisciRisposte
            // 
            this.btnGestisciRisposte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestisciRisposte.Location = new System.Drawing.Point(496, 439);
            this.btnGestisciRisposte.Name = "btnGestisciRisposte";
            this.btnGestisciRisposte.Size = new System.Drawing.Size(133, 72);
            this.btnGestisciRisposte.TabIndex = 98;
            this.btnGestisciRisposte.Text = "➕ Gestisci Risposte";
            this.btnGestisciRisposte.UseVisualStyleBackColor = true;
            this.btnGestisciRisposte.Click += new System.EventHandler(this.btnGestisciRisposte_Click);
            // 
            // rbSingola
            // 
            this.rbSingola.AutoSize = true;
            this.rbSingola.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.rbSingola.Location = new System.Drawing.Point(1121, 215);
            this.rbSingola.Name = "rbSingola";
            this.rbSingola.Size = new System.Drawing.Size(168, 29);
            this.rbSingola.TabIndex = 99;
            this.rbSingola.TabStop = true;
            this.rbSingola.Text = "Scelta Singola";
            this.rbSingola.UseVisualStyleBackColor = true;
            // 
            // lblSondaggioID
            // 
            this.lblSondaggioID.AutoSize = true;
            this.lblSondaggioID.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSondaggioID.Location = new System.Drawing.Point(12, 51);
            this.lblSondaggioID.Name = "lblSondaggioID";
            this.lblSondaggioID.Size = new System.Drawing.Size(308, 37);
            this.lblSondaggioID.TabIndex = 100;
            this.lblSondaggioID.Text = "ID Sondaggio #1234";
            // 
            // btnTornaIndietro
            // 
            this.btnTornaIndietro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTornaIndietro.Location = new System.Drawing.Point(12, 9);
            this.btnTornaIndietro.Name = "btnTornaIndietro";
            this.btnTornaIndietro.Size = new System.Drawing.Size(241, 39);
            this.btnTornaIndietro.TabIndex = 126;
            this.btnTornaIndietro.Text = "↩️Torna ai Sondaggi";
            this.btnTornaIndietro.UseVisualStyleBackColor = true;
            this.btnTornaIndietro.Click += new System.EventHandler(this.btnTornaIndietro_Click);
            // 
            // FrmCreaDomande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 537);
            this.Controls.Add(this.btnTornaIndietro);
            this.Controls.Add(this.lblSondaggioID);
            this.Controls.Add(this.rbSingola);
            this.Controls.Add(this.btnGestisciRisposte);
            this.Controls.Add(this.cbDomande);
            this.Controls.Add(this.lvDomande);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.rbSiNo);
            this.Controls.Add(this.btnAnnulla);
            this.Controls.Add(this.btnAggiungi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudOrdine);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.rbMultiple);
            this.Controls.Add(this.rbAperta);
            this.Controls.Add(this.lblDomanda);
            this.Controls.Add(this.rtbTesto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmCreaDomande";
            this.Text = "Domanda";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCreaDomande_FormClosing);
            this.Load += new System.EventHandler(this.FrmDomanda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudOrdine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbMultiple;
        private System.Windows.Forms.RadioButton rbAperta;
        private System.Windows.Forms.Label lblDomanda;
        private System.Windows.Forms.RichTextBox rtbTesto;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudOrdine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.Button btnAnnulla;
        private System.Windows.Forms.RadioButton rbSiNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.ListView lvDomande;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ComboBox cbDomande;
        private System.Windows.Forms.Button btnGestisciRisposte;
        private System.Windows.Forms.RadioButton rbSingola;
        private System.Windows.Forms.Label lblSondaggioID;
        private System.Windows.Forms.Button btnTornaIndietro;
    }
}

