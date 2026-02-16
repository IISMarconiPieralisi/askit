namespace sondaggio
{
    partial class FrmCreaRisposte
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
            this.lblSondaggioID = new System.Windows.Forms.Label();
            this.lvRisposte = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnElimina = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.btnSalva = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblDomanda = new System.Windows.Forms.Label();
            this.rtbTesto = new System.Windows.Forms.RichTextBox();
            this.lblTipoDomanda = new System.Windows.Forms.Label();
            this.btnTornaIndietro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSondaggioID
            // 
            this.lblSondaggioID.AutoSize = true;
            this.lblSondaggioID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSondaggioID.Location = new System.Drawing.Point(12, 46);
            this.lblSondaggioID.Name = "lblSondaggioID";
            this.lblSondaggioID.Size = new System.Drawing.Size(179, 24);
            this.lblSondaggioID.TabIndex = 123;
            this.lblSondaggioID.Text = "ID Sondaggio #1234";
            // 
            // lvRisposte
            // 
            this.lvRisposte.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3});
            this.lvRisposte.FullRowSelect = true;
            this.lvRisposte.HideSelection = false;
            this.lvRisposte.Location = new System.Drawing.Point(16, 132);
            this.lvRisposte.Name = "lvRisposte";
            this.lvRisposte.Size = new System.Drawing.Size(471, 358);
            this.lvRisposte.TabIndex = 119;
            this.lvRisposte.UseCompatibleStateImageBehavior = false;
            this.lvRisposte.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 98;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Testo";
            this.columnHeader3.Width = 367;
            // 
            // btnElimina
            // 
            this.btnElimina.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElimina.Location = new System.Drawing.Point(493, 172);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(133, 34);
            this.btnElimina.TabIndex = 116;
            this.btnElimina.Text = "🗑️Elimina";
            this.btnElimina.UseVisualStyleBackColor = true;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifica.Location = new System.Drawing.Point(493, 132);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(133, 34);
            this.btnModifica.TabIndex = 115;
            this.btnModifica.Text = "✍️Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulla.Location = new System.Drawing.Point(951, 331);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(117, 31);
            this.btnAnnulla.TabIndex = 113;
            this.btnAnnulla.Text = "↩️ Annulla";
            this.btnAnnulla.UseVisualStyleBackColor = true;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // btnSalva
            // 
            this.btnSalva.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalva.Location = new System.Drawing.Point(712, 331);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(233, 36);
            this.btnSalva.TabIndex = 112;
            this.btnSalva.Text = "➕Aggiungi";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Gray;
            this.label18.Location = new System.Drawing.Point(673, 132);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 24);
            this.label18.TabIndex = 105;
            this.label18.Text = "Testo";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(672, 161);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(34, 25);
            this.label19.TabIndex = 106;
            this.label19.Text = "📝";
            // 
            // lblDomanda
            // 
            this.lblDomanda.AutoSize = true;
            this.lblDomanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomanda.Location = new System.Drawing.Point(670, 95);
            this.lblDomanda.Name = "lblDomanda";
            this.lblDomanda.Size = new System.Drawing.Size(219, 37);
            this.lblDomanda.TabIndex = 102;
            this.lblDomanda.Text = "Crea Risposta";
            // 
            // rtbTesto
            // 
            this.rtbTesto.Location = new System.Drawing.Point(712, 161);
            this.rtbTesto.Name = "rtbTesto";
            this.rtbTesto.Size = new System.Drawing.Size(356, 164);
            this.rtbTesto.TabIndex = 101;
            this.rtbTesto.Text = "";
            // 
            // lblTipoDomanda
            // 
            this.lblTipoDomanda.AutoSize = true;
            this.lblTipoDomanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDomanda.Location = new System.Drawing.Point(9, 70);
            this.lblTipoDomanda.Name = "lblTipoDomanda";
            this.lblTipoDomanda.Size = new System.Drawing.Size(507, 37);
            this.lblTipoDomanda.TabIndex = 124;
            this.lblTipoDomanda.Text = "Domanda n° 1 - Tipologia: Multipla";
            // 
            // btnTornaIndietro
            // 
            this.btnTornaIndietro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTornaIndietro.Location = new System.Drawing.Point(12, 12);
            this.btnTornaIndietro.Name = "btnTornaIndietro";
            this.btnTornaIndietro.Size = new System.Drawing.Size(241, 31);
            this.btnTornaIndietro.TabIndex = 125;
            this.btnTornaIndietro.Text = "↩️Torna alle Domande";
            this.btnTornaIndietro.UseVisualStyleBackColor = true;
            this.btnTornaIndietro.Click += new System.EventHandler(this.btnTornaIndietro_Click);
            // 
            // FrmCreaRisposte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 514);
            this.Controls.Add(this.btnTornaIndietro);
            this.Controls.Add(this.lblTipoDomanda);
            this.Controls.Add(this.lblSondaggioID);
            this.Controls.Add(this.lvRisposte);
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnAnnulla);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lblDomanda);
            this.Controls.Add(this.rtbTesto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmCreaRisposte";
            this.Text = "FrmCreaRisposte";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCreaRisposte_FormClosing);
            this.Load += new System.EventHandler(this.FrmCreaRisposte_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSondaggioID;
        private System.Windows.Forms.ListView lvRisposte;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnAnnulla;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblDomanda;
        private System.Windows.Forms.RichTextBox rtbTesto;
        private System.Windows.Forms.Label lblTipoDomanda;
        private System.Windows.Forms.Button btnTornaIndietro;
    }
}