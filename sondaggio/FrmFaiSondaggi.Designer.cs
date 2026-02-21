namespace sondaggio
{
    partial class FrmFaiSondaggi
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
            this.cbDomande = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPartecipa = new System.Windows.Forms.Button();
            this.lvDomande = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // cbDomande
            // 
            this.cbDomande.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDomande.FormattingEnabled = true;
            this.cbDomande.Location = new System.Drawing.Point(52, 36);
            this.cbDomande.Name = "cbDomande";
            this.cbDomande.Size = new System.Drawing.Size(240, 33);
            this.cbDomande.TabIndex = 123;
            this.cbDomande.SelectedIndexChanged += new System.EventHandler(this.cbDomande_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(244, 24);
            this.label5.TabIndex = 120;
            this.label5.Text = "Cerca per nome Sondaggio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(13, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 25);
            this.label6.TabIndex = 121;
            this.label6.Text = "🔎";
            // 
            // btnPartecipa
            // 
            this.btnPartecipa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartecipa.Location = new System.Drawing.Point(785, 75);
            this.btnPartecipa.Name = "btnPartecipa";
            this.btnPartecipa.Size = new System.Drawing.Size(153, 67);
            this.btnPartecipa.TabIndex = 124;
            this.btnPartecipa.Text = "📝Partecipa al sondaggio";
            this.btnPartecipa.UseVisualStyleBackColor = true;
            this.btnPartecipa.Click += new System.EventHandler(this.btnPartecipa_Click);
            // 
            // lvDomande
            // 
            this.lvDomande.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader7});
            this.lvDomande.FullRowSelect = true;
            this.lvDomande.HideSelection = false;
            this.lvDomande.Location = new System.Drawing.Point(18, 75);
            this.lvDomande.Name = "lvDomande";
            this.lvDomande.Size = new System.Drawing.Size(761, 358);
            this.lvDomande.TabIndex = 125;
            this.lvDomande.UseCompatibleStateImageBehavior = false;
            this.lvDomande.View = System.Windows.Forms.View.Details;
            this.lvDomande.SelectedIndexChanged += new System.EventHandler(this.lvDomande_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nome";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Domande";
            this.columnHeader2.Width = 124;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Categoria";
            this.columnHeader3.Width = 133;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Stato";
            this.columnHeader4.Width = 86;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tipo";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Data";
            this.columnHeader7.Width = 150;
            // 
            // FrmFaiSondaggi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 450);
            this.Controls.Add(this.lvDomande);
            this.Controls.Add(this.btnPartecipa);
            this.Controls.Add(this.cbDomande);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmFaiSondaggi";
            this.Text = "FrmFaiSondaggi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmFaiSondaggi_FormClosing);
            this.Load += new System.EventHandler(this.FrmFaiSondaggi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDomande;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPartecipa;
        private System.Windows.Forms.ListView lvDomande;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}