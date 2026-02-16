namespace sondaggio
{
    partial class FrmRispondere
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
            this.btnVaiAvanti = new System.Windows.Forms.Button();
            this.btnVaiIndietro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTesto = new System.Windows.Forms.Label();
            this.lblSondaggioID = new System.Windows.Forms.Label();
            this.lblOrdineDomanda = new System.Windows.Forms.Label();
            this.btnTornaAiSondaggi = new System.Windows.Forms.Button();
            this.pnlAperta = new System.Windows.Forms.FlowLayoutPanel();
            this.rtbRisposta = new System.Windows.Forms.RichTextBox();
            this.pnlVF = new System.Windows.Forms.FlowLayoutPanel();
            this.rbVero = new System.Windows.Forms.RadioButton();
            this.rbFalso = new System.Windows.Forms.RadioButton();
            this.pnlSingola = new System.Windows.Forms.FlowLayoutPanel();
            this.rbSingola1 = new System.Windows.Forms.RadioButton();
            this.pnlMultipla = new System.Windows.Forms.FlowLayoutPanel();
            this.cbMultipla1 = new System.Windows.Forms.CheckBox();
            this.llblFineSondaggio = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.lbDomande = new System.Windows.Forms.ListBox();
            this.pnlAperta.SuspendLayout();
            this.pnlVF.SuspendLayout();
            this.pnlSingola.SuspendLayout();
            this.pnlMultipla.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVaiAvanti
            // 
            this.btnVaiAvanti.Location = new System.Drawing.Point(1023, 237);
            this.btnVaiAvanti.Name = "btnVaiAvanti";
            this.btnVaiAvanti.Size = new System.Drawing.Size(56, 50);
            this.btnVaiAvanti.TabIndex = 0;
            this.btnVaiAvanti.Text = "➡️";
            this.btnVaiAvanti.UseVisualStyleBackColor = true;
            this.btnVaiAvanti.Click += new System.EventHandler(this.btnVaiAvanti_Click);
            // 
            // btnVaiIndietro
            // 
            this.btnVaiIndietro.Location = new System.Drawing.Point(329, 237);
            this.btnVaiIndietro.Name = "btnVaiIndietro";
            this.btnVaiIndietro.Size = new System.Drawing.Size(56, 50);
            this.btnVaiIndietro.TabIndex = 1;
            this.btnVaiIndietro.Text = "⬅️";
            this.btnVaiIndietro.UseVisualStyleBackColor = true;
            this.btnVaiIndietro.Visible = false;
            this.btnVaiIndietro.Click += new System.EventHandler(this.btnVaiIndietro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(386, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Testo";
            // 
            // lblTesto
            // 
            this.lblTesto.AutoSize = true;
            this.lblTesto.Location = new System.Drawing.Point(386, 107);
            this.lblTesto.Name = "lblTesto";
            this.lblTesto.Size = new System.Drawing.Size(399, 25);
            this.lblTesto.TabIndex = 3;
            this.lblTesto.Text = "ADSCBUIABCIOAUGDCBYJHBWDCIOQ";
            // 
            // lblSondaggioID
            // 
            this.lblSondaggioID.AutoSize = true;
            this.lblSondaggioID.Location = new System.Drawing.Point(386, 12);
            this.lblSondaggioID.Name = "lblSondaggioID";
            this.lblSondaggioID.Size = new System.Drawing.Size(437, 25);
            this.lblSondaggioID.TabIndex = 4;
            this.lblSondaggioID.Text = "Sondaggio ID #1234 Nome: nomeSondaggio";
            // 
            // lblOrdineDomanda
            // 
            this.lblOrdineDomanda.AutoSize = true;
            this.lblOrdineDomanda.Location = new System.Drawing.Point(355, 82);
            this.lblOrdineDomanda.Name = "lblOrdineDomanda";
            this.lblOrdineDomanda.Size = new System.Drawing.Size(30, 25);
            this.lblOrdineDomanda.TabIndex = 10;
            this.lblOrdineDomanda.Text = "7.";
            // 
            // btnTornaAiSondaggi
            // 
            this.btnTornaAiSondaggi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTornaAiSondaggi.Location = new System.Drawing.Point(12, 12);
            this.btnTornaAiSondaggi.Name = "btnTornaAiSondaggi";
            this.btnTornaAiSondaggi.Size = new System.Drawing.Size(241, 40);
            this.btnTornaAiSondaggi.TabIndex = 127;
            this.btnTornaAiSondaggi.Text = "↩️Torna ai Sondaggi";
            this.btnTornaAiSondaggi.UseVisualStyleBackColor = true;
            this.btnTornaAiSondaggi.Click += new System.EventHandler(this.btnTornaAiSondaggi_Click);
            // 
            // pnlAperta
            // 
            this.pnlAperta.AutoScroll = true;
            this.pnlAperta.Controls.Add(this.rtbRisposta);
            this.pnlAperta.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlAperta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pnlAperta.Location = new System.Drawing.Point(391, 136);
            this.pnlAperta.Name = "pnlAperta";
            this.pnlAperta.Size = new System.Drawing.Size(626, 345);
            this.pnlAperta.TabIndex = 128;
            this.pnlAperta.Visible = false;
            this.pnlAperta.WrapContents = false;
            // 
            // rtbRisposta
            // 
            this.rtbRisposta.Location = new System.Drawing.Point(3, 3);
            this.rtbRisposta.Name = "rtbRisposta";
            this.rtbRisposta.Size = new System.Drawing.Size(623, 238);
            this.rtbRisposta.TabIndex = 0;
            this.rtbRisposta.Text = "";
            // 
            // pnlVF
            // 
            this.pnlVF.AutoScroll = true;
            this.pnlVF.Controls.Add(this.rbVero);
            this.pnlVF.Controls.Add(this.rbFalso);
            this.pnlVF.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlVF.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pnlVF.Location = new System.Drawing.Point(391, 135);
            this.pnlVF.Name = "pnlVF";
            this.pnlVF.Size = new System.Drawing.Size(626, 349);
            this.pnlVF.TabIndex = 129;
            this.pnlVF.Visible = false;
            this.pnlVF.WrapContents = false;
            // 
            // rbVero
            // 
            this.rbVero.AutoSize = true;
            this.rbVero.Location = new System.Drawing.Point(3, 3);
            this.rbVero.Name = "rbVero";
            this.rbVero.Size = new System.Drawing.Size(49, 29);
            this.rbVero.TabIndex = 0;
            this.rbVero.TabStop = true;
            this.rbVero.Text = "Sì";
            this.rbVero.UseVisualStyleBackColor = true;
            // 
            // rbFalso
            // 
            this.rbFalso.AutoSize = true;
            this.rbFalso.Location = new System.Drawing.Point(3, 38);
            this.rbFalso.Name = "rbFalso";
            this.rbFalso.Size = new System.Drawing.Size(57, 29);
            this.rbFalso.TabIndex = 1;
            this.rbFalso.TabStop = true;
            this.rbFalso.Text = "No";
            this.rbFalso.UseVisualStyleBackColor = true;
            // 
            // pnlSingola
            // 
            this.pnlSingola.AutoScroll = true;
            this.pnlSingola.Controls.Add(this.rbSingola1);
            this.pnlSingola.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlSingola.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pnlSingola.Location = new System.Drawing.Point(394, 136);
            this.pnlSingola.Name = "pnlSingola";
            this.pnlSingola.Size = new System.Drawing.Size(623, 349);
            this.pnlSingola.TabIndex = 130;
            this.pnlSingola.Visible = false;
            this.pnlSingola.WrapContents = false;
            // 
            // rbSingola1
            // 
            this.rbSingola1.Location = new System.Drawing.Point(3, 3);
            this.rbSingola1.Name = "rbSingola1";
            this.rbSingola1.Size = new System.Drawing.Size(584, 63);
            this.rbSingola1.TabIndex = 1;
            this.rbSingola1.TabStop = true;
            this.rbSingola1.Text = "Risposta";
            this.rbSingola1.UseVisualStyleBackColor = true;
            // 
            // pnlMultipla
            // 
            this.pnlMultipla.AutoScroll = true;
            this.pnlMultipla.Controls.Add(this.cbMultipla1);
            this.pnlMultipla.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlMultipla.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pnlMultipla.Location = new System.Drawing.Point(391, 135);
            this.pnlMultipla.Name = "pnlMultipla";
            this.pnlMultipla.Size = new System.Drawing.Size(626, 349);
            this.pnlMultipla.TabIndex = 131;
            this.pnlMultipla.Visible = false;
            this.pnlMultipla.WrapContents = false;
            // 
            // cbMultipla1
            // 
            this.cbMultipla1.Location = new System.Drawing.Point(3, 3);
            this.cbMultipla1.Name = "cbMultipla1";
            this.cbMultipla1.Size = new System.Drawing.Size(515, 29);
            this.cbMultipla1.TabIndex = 0;
            this.cbMultipla1.Text = "Risposta";
            this.cbMultipla1.UseVisualStyleBackColor = true;
            // 
            // llblFineSondaggio
            // 
            this.llblFineSondaggio.Location = new System.Drawing.Point(7, 425);
            this.llblFineSondaggio.Name = "llblFineSondaggio";
            this.llblFineSondaggio.Size = new System.Drawing.Size(258, 43);
            this.llblFineSondaggio.TabIndex = 132;
            this.llblFineSondaggio.TabStop = true;
            this.llblFineSondaggio.Text = "Fine Sondaggio";
            this.llblFineSondaggio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.llblFineSondaggio.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblFineSondaggio_LinkClicked);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(7, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(258, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Navigazione sondaggio";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbDomande
            // 
            this.lbDomande.FormattingEnabled = true;
            this.lbDomande.ItemHeight = 25;
            this.lbDomande.Location = new System.Drawing.Point(12, 107);
            this.lbDomande.Name = "lbDomande";
            this.lbDomande.Size = new System.Drawing.Size(253, 304);
            this.lbDomande.TabIndex = 133;
            this.lbDomande.SelectedIndexChanged += new System.EventHandler(this.lbDomande_SelectedIndexChanged);
            // 
            // FrmRispondere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 508);
            this.Controls.Add(this.lbDomande);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.llblFineSondaggio);
            this.Controls.Add(this.btnTornaAiSondaggi);
            this.Controls.Add(this.lblOrdineDomanda);
            this.Controls.Add(this.lblSondaggioID);
            this.Controls.Add(this.lblTesto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVaiIndietro);
            this.Controls.Add(this.btnVaiAvanti);
            this.Controls.Add(this.pnlMultipla);
            this.Controls.Add(this.pnlVF);
            this.Controls.Add(this.pnlSingola);
            this.Controls.Add(this.pnlAperta);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmRispondere";
            this.Text = "Rispondi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmRispondere_FormClosing);
            this.Load += new System.EventHandler(this.FrmRispondere_Load);
            this.pnlAperta.ResumeLayout(false);
            this.pnlVF.ResumeLayout(false);
            this.pnlVF.PerformLayout();
            this.pnlSingola.ResumeLayout(false);
            this.pnlMultipla.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVaiAvanti;
        private System.Windows.Forms.Button btnVaiIndietro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTesto;
        private System.Windows.Forms.Label lblSondaggioID;
        private System.Windows.Forms.Label lblOrdineDomanda;
        private System.Windows.Forms.Button btnTornaAiSondaggi;
        private System.Windows.Forms.FlowLayoutPanel pnlAperta;
        private System.Windows.Forms.RichTextBox rtbRisposta;
        private System.Windows.Forms.FlowLayoutPanel pnlVF;
        private System.Windows.Forms.RadioButton rbVero;
        private System.Windows.Forms.RadioButton rbFalso;
        private System.Windows.Forms.FlowLayoutPanel pnlSingola;
        private System.Windows.Forms.RadioButton rbSingola1;
        private System.Windows.Forms.FlowLayoutPanel pnlMultipla;
        private System.Windows.Forms.CheckBox cbMultipla1;
        private System.Windows.Forms.LinkLabel llblFineSondaggio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbDomande;
    }
}