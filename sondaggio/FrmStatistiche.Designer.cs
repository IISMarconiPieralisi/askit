namespace sondaggio
{
    partial class FrmStatistiche
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnTornaIndietro = new System.Windows.Forms.Button();
            this.chtRisposte = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbSondaggi = new System.Windows.Forms.ComboBox();
            this.lbDomande = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.chtRisposte)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTornaIndietro
            // 
            this.btnTornaIndietro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTornaIndietro.Location = new System.Drawing.Point(12, 12);
            this.btnTornaIndietro.Name = "btnTornaIndietro";
            this.btnTornaIndietro.Size = new System.Drawing.Size(241, 40);
            this.btnTornaIndietro.TabIndex = 127;
            this.btnTornaIndietro.Text = "↩️Torna ai Sondaggi";
            this.btnTornaIndietro.UseVisualStyleBackColor = true;
            this.btnTornaIndietro.Click += new System.EventHandler(this.btnTornaIndietro_Click);
            // 
            // chtRisposte
            // 
            chartArea1.Name = "ChartArea1";
            this.chtRisposte.ChartAreas.Add(chartArea1);
            this.chtRisposte.IsSoftShadows = false;
            legend1.Name = "Legend1";
            this.chtRisposte.Legends.Add(legend1);
            this.chtRisposte.Location = new System.Drawing.Point(259, 58);
            this.chtRisposte.Name = "chtRisposte";
            this.chtRisposte.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtRisposte.Series.Add(series1);
            this.chtRisposte.Size = new System.Drawing.Size(776, 369);
            this.chtRisposte.TabIndex = 128;
            this.chtRisposte.Text = "chart1";
            // 
            // cbSondaggi
            // 
            this.cbSondaggi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.cbSondaggi.FormattingEnabled = true;
            this.cbSondaggi.Location = new System.Drawing.Point(12, 58);
            this.cbSondaggi.Name = "cbSondaggi";
            this.cbSondaggi.Size = new System.Drawing.Size(241, 33);
            this.cbSondaggi.TabIndex = 129;
            this.cbSondaggi.SelectedIndexChanged += new System.EventHandler(this.cbSondaggi_SelectedIndexChanged);
            // 
            // lbDomande
            // 
            this.lbDomande.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lbDomande.FormattingEnabled = true;
            this.lbDomande.ItemHeight = 25;
            this.lbDomande.Location = new System.Drawing.Point(12, 98);
            this.lbDomande.Name = "lbDomande";
            this.lbDomande.Size = new System.Drawing.Size(241, 329);
            this.lbDomande.TabIndex = 130;
            this.lbDomande.SelectedIndexChanged += new System.EventHandler(this.lbDomande_SelectedIndexChanged);
            // 
            // FrmStatistiche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 438);
            this.Controls.Add(this.lbDomande);
            this.Controls.Add(this.cbSondaggi);
            this.Controls.Add(this.chtRisposte);
            this.Controls.Add(this.btnTornaIndietro);
            this.Name = "FrmStatistiche";
            this.Text = "FrmStatistiche";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmStatistiche_FormClosing);
            this.Load += new System.EventHandler(this.FrmStatistiche_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtRisposte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTornaIndietro;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtRisposte;
        private System.Windows.Forms.ComboBox cbSondaggi;
        private System.Windows.Forms.ListBox lbDomande;
    }
}