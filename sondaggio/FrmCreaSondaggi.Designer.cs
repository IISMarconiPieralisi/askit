namespace sondaggio
{
    partial class FrmCreaSondaggi
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
            this.cbDomandeFiltro = new System.Windows.Forms.ComboBox();
            this.lvDomande = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnElimina = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.rbRegistrati = new System.Windows.Forms.RadioButton();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.rbAnonimo = new System.Windows.Forms.RadioButton();
            this.lblDomanda = new System.Windows.Forms.Label();
            this.btnDomande = new System.Windows.Forms.Button();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.btnCategorie = new System.Windows.Forms.Button();
            this.btnStatistiche = new System.Windows.Forms.Button();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudID = new System.Windows.Forms.NumericUpDown();
            this.pnlFiltroID = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlFiltroTipo = new System.Windows.Forms.Panel();
            this.rbFiltroAnonimo = new System.Windows.Forms.RadioButton();
            this.rbFiltroRegistrato = new System.Windows.Forms.RadioButton();
            this.pnlFiltroStato = new System.Windows.Forms.Panel();
            this.rbFiltroChiuso = new System.Windows.Forms.RadioButton();
            this.rbFiltroAperto = new System.Windows.Forms.RadioButton();
            this.pnlFiltroNome = new System.Windows.Forms.Panel();
            this.tbFiltroNome = new System.Windows.Forms.TextBox();
            this.pnlFiltroData = new System.Windows.Forms.Panel();
            this.dtpFiltroData = new System.Windows.Forms.DateTimePicker();
            this.btnUtenti = new System.Windows.Forms.Button();
            this.btnRisposteStandard = new System.Windows.Forms.Button();
            this.rbStatoChiuso = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rbStatoAperto = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nudID)).BeginInit();
            this.pnlFiltroID.SuspendLayout();
            this.pnlFiltroTipo.SuspendLayout();
            this.pnlFiltroStato.SuspendLayout();
            this.pnlFiltroNome.SuspendLayout();
            this.pnlFiltroData.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbDomandeFiltro
            // 
            this.cbDomandeFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDomandeFiltro.FormattingEnabled = true;
            this.cbDomandeFiltro.Location = new System.Drawing.Point(49, 32);
            this.cbDomandeFiltro.Name = "cbDomandeFiltro";
            this.cbDomandeFiltro.Size = new System.Drawing.Size(240, 33);
            this.cbDomandeFiltro.TabIndex = 119;
            this.cbDomandeFiltro.SelectedIndexChanged += new System.EventHandler(this.cbDomande_SelectedIndexChanged);
            // 
            // lvDomande
            // 
            this.lvDomande.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5});
            this.lvDomande.FullRowSelect = true;
            this.lvDomande.HideSelection = false;
            this.lvDomande.Location = new System.Drawing.Point(13, 71);
            this.lvDomande.Name = "lvDomande";
            this.lvDomande.Size = new System.Drawing.Size(761, 358);
            this.lvDomande.TabIndex = 118;
            this.lvDomande.UseCompatibleStateImageBehavior = false;
            this.lvDomande.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 62;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Nome";
            this.columnHeader4.Width = 126;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Domande";
            this.columnHeader6.Width = 115;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Categoria";
            this.columnHeader7.Width = 152;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Stato";
            this.columnHeader2.Width = 79;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tipo";
            this.columnHeader3.Width = 97;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Data";
            this.columnHeader5.Width = 124;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(9, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 24);
            this.label5.TabIndex = 116;
            this.label5.Text = "Cerca per...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(10, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 25);
            this.label6.TabIndex = 117;
            this.label6.Text = "🔎";
            // 
            // btnElimina
            // 
            this.btnElimina.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElimina.Location = new System.Drawing.Point(782, 113);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(133, 34);
            this.btnElimina.TabIndex = 115;
            this.btnElimina.Text = "🗑️Elimina";
            this.btnElimina.UseVisualStyleBackColor = true;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifica.Location = new System.Drawing.Point(782, 71);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(133, 34);
            this.btnModifica.TabIndex = 114;
            this.btnModifica.Text = "✍️Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // rbRegistrati
            // 
            this.rbRegistrati.AutoSize = true;
            this.rbRegistrati.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.rbRegistrati.Location = new System.Drawing.Point(125, 3);
            this.rbRegistrati.Name = "rbRegistrati";
            this.rbRegistrati.Size = new System.Drawing.Size(183, 29);
            this.rbRegistrati.TabIndex = 113;
            this.rbRegistrati.TabStop = true;
            this.rbRegistrati.Text = "Utenti Registrati";
            this.rbRegistrati.UseVisualStyleBackColor = true;
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulla.Location = new System.Drawing.Point(1147, 310);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(117, 31);
            this.btnAnnulla.TabIndex = 112;
            this.btnAnnulla.Text = "↩️ Annulla";
            this.btnAnnulla.UseVisualStyleBackColor = true;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggiungi.Location = new System.Drawing.Point(926, 305);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(215, 36);
            this.btnAggiungi.TabIndex = 111;
            this.btnAggiungi.Text = "➕Aggiungi";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(922, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 24);
            this.label3.TabIndex = 109;
            this.label3.Text = "Tipo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(921, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 25);
            this.label4.TabIndex = 110;
            this.label4.Text = "📝";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Gray;
            this.label18.Location = new System.Drawing.Point(921, 60);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 24);
            this.label18.TabIndex = 104;
            this.label18.Text = "Nome";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(920, 89);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(34, 25);
            this.label19.TabIndex = 105;
            this.label19.Text = "📝";
            // 
            // rbAnonimo
            // 
            this.rbAnonimo.AutoSize = true;
            this.rbAnonimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.rbAnonimo.Location = new System.Drawing.Point(5, 3);
            this.rbAnonimo.Name = "rbAnonimo";
            this.rbAnonimo.Size = new System.Drawing.Size(114, 29);
            this.rbAnonimo.TabIndex = 102;
            this.rbAnonimo.TabStop = true;
            this.rbAnonimo.Text = "Anonimo";
            this.rbAnonimo.UseVisualStyleBackColor = true;
            // 
            // lblDomanda
            // 
            this.lblDomanda.AutoSize = true;
            this.lblDomanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomanda.Location = new System.Drawing.Point(918, 23);
            this.lblDomanda.Name = "lblDomanda";
            this.lblDomanda.Size = new System.Drawing.Size(249, 37);
            this.lblDomanda.TabIndex = 101;
            this.lblDomanda.Text = "Crea Sondaggio";
            // 
            // btnDomande
            // 
            this.btnDomande.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDomande.Location = new System.Drawing.Point(780, 357);
            this.btnDomande.Name = "btnDomande";
            this.btnDomande.Size = new System.Drawing.Size(143, 72);
            this.btnDomande.TabIndex = 123;
            this.btnDomande.Text = "❓ Gestisci Domande";
            this.btnDomande.UseVisualStyleBackColor = true;
            this.btnDomande.Click += new System.EventHandler(this.btnDomande_Click);
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(961, 89);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(302, 31);
            this.tbNome.TabIndex = 124;
            // 
            // btnCategorie
            // 
            this.btnCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorie.Location = new System.Drawing.Point(319, 435);
            this.btnCategorie.Name = "btnCategorie";
            this.btnCategorie.Size = new System.Drawing.Size(145, 72);
            this.btnCategorie.TabIndex = 125;
            this.btnCategorie.Text = "📚 Gestisci Categorie";
            this.btnCategorie.UseVisualStyleBackColor = true;
            this.btnCategorie.Click += new System.EventHandler(this.btnCategorie_Click);
            // 
            // btnStatistiche
            // 
            this.btnStatistiche.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistiche.Location = new System.Drawing.Point(166, 435);
            this.btnStatistiche.Name = "btnStatistiche";
            this.btnStatistiche.Size = new System.Drawing.Size(147, 72);
            this.btnStatistiche.TabIndex = 126;
            this.btnStatistiche.Text = "📊 Visualizza Statistiche";
            this.btnStatistiche.UseVisualStyleBackColor = true;
            this.btnStatistiche.Click += new System.EventHandler(this.btnStatistiche_Click);
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(961, 152);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(302, 33);
            this.cbCategoria.TabIndex = 127;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(921, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 128;
            this.label1.Text = "Categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(920, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 25);
            this.label2.TabIndex = 129;
            this.label2.Text = "📝";
            // 
            // nudID
            // 
            this.nudID.Location = new System.Drawing.Point(110, 14);
            this.nudID.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudID.Name = "nudID";
            this.nudID.Size = new System.Drawing.Size(120, 31);
            this.nudID.TabIndex = 130;
            this.nudID.ValueChanged += new System.EventHandler(this.nudID_ValueChanged);
            // 
            // pnlFiltroID
            // 
            this.pnlFiltroID.Controls.Add(this.label7);
            this.pnlFiltroID.Controls.Add(this.nudID);
            this.pnlFiltroID.Location = new System.Drawing.Point(323, 12);
            this.pnlFiltroID.Name = "pnlFiltroID";
            this.pnlFiltroID.Size = new System.Drawing.Size(238, 53);
            this.pnlFiltroID.TabIndex = 131;
            this.pnlFiltroID.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(3, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 24);
            this.label7.TabIndex = 132;
            this.label7.Text = "Numero ID";
            // 
            // pnlFiltroTipo
            // 
            this.pnlFiltroTipo.Controls.Add(this.rbFiltroAnonimo);
            this.pnlFiltroTipo.Controls.Add(this.rbFiltroRegistrato);
            this.pnlFiltroTipo.Location = new System.Drawing.Point(312, 12);
            this.pnlFiltroTipo.Name = "pnlFiltroTipo";
            this.pnlFiltroTipo.Size = new System.Drawing.Size(312, 53);
            this.pnlFiltroTipo.TabIndex = 133;
            this.pnlFiltroTipo.Visible = false;
            // 
            // rbFiltroAnonimo
            // 
            this.rbFiltroAnonimo.AutoSize = true;
            this.rbFiltroAnonimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.rbFiltroAnonimo.Location = new System.Drawing.Point(3, 14);
            this.rbFiltroAnonimo.Name = "rbFiltroAnonimo";
            this.rbFiltroAnonimo.Size = new System.Drawing.Size(114, 29);
            this.rbFiltroAnonimo.TabIndex = 134;
            this.rbFiltroAnonimo.TabStop = true;
            this.rbFiltroAnonimo.Text = "Anonimo";
            this.rbFiltroAnonimo.UseVisualStyleBackColor = true;
            this.rbFiltroAnonimo.CheckedChanged += new System.EventHandler(this.rbFiltroAnonimo_CheckedChanged);
            // 
            // rbFiltroRegistrato
            // 
            this.rbFiltroRegistrato.AutoSize = true;
            this.rbFiltroRegistrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.rbFiltroRegistrato.Location = new System.Drawing.Point(123, 14);
            this.rbFiltroRegistrato.Name = "rbFiltroRegistrato";
            this.rbFiltroRegistrato.Size = new System.Drawing.Size(183, 29);
            this.rbFiltroRegistrato.TabIndex = 135;
            this.rbFiltroRegistrato.TabStop = true;
            this.rbFiltroRegistrato.Text = "Utenti Registrati";
            this.rbFiltroRegistrato.UseVisualStyleBackColor = true;
            this.rbFiltroRegistrato.CheckedChanged += new System.EventHandler(this.rbFiltroRegistrato_CheckedChanged);
            // 
            // pnlFiltroStato
            // 
            this.pnlFiltroStato.Controls.Add(this.rbFiltroChiuso);
            this.pnlFiltroStato.Controls.Add(this.rbFiltroAperto);
            this.pnlFiltroStato.Location = new System.Drawing.Point(312, 12);
            this.pnlFiltroStato.Name = "pnlFiltroStato";
            this.pnlFiltroStato.Size = new System.Drawing.Size(205, 53);
            this.pnlFiltroStato.TabIndex = 136;
            this.pnlFiltroStato.Visible = false;
            // 
            // rbFiltroChiuso
            // 
            this.rbFiltroChiuso.AutoSize = true;
            this.rbFiltroChiuso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.rbFiltroChiuso.Location = new System.Drawing.Point(102, 14);
            this.rbFiltroChiuso.Name = "rbFiltroChiuso";
            this.rbFiltroChiuso.Size = new System.Drawing.Size(97, 29);
            this.rbFiltroChiuso.TabIndex = 135;
            this.rbFiltroChiuso.TabStop = true;
            this.rbFiltroChiuso.Text = "Chiuso";
            this.rbFiltroChiuso.UseVisualStyleBackColor = true;
            this.rbFiltroChiuso.CheckedChanged += new System.EventHandler(this.rbChiuso_CheckedChanged);
            // 
            // rbFiltroAperto
            // 
            this.rbFiltroAperto.AutoSize = true;
            this.rbFiltroAperto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.rbFiltroAperto.Location = new System.Drawing.Point(3, 14);
            this.rbFiltroAperto.Name = "rbFiltroAperto";
            this.rbFiltroAperto.Size = new System.Drawing.Size(93, 29);
            this.rbFiltroAperto.TabIndex = 134;
            this.rbFiltroAperto.TabStop = true;
            this.rbFiltroAperto.Text = "Aperto";
            this.rbFiltroAperto.UseVisualStyleBackColor = true;
            this.rbFiltroAperto.CheckedChanged += new System.EventHandler(this.rbAperto_CheckedChanged);
            // 
            // pnlFiltroNome
            // 
            this.pnlFiltroNome.Controls.Add(this.tbFiltroNome);
            this.pnlFiltroNome.Location = new System.Drawing.Point(309, 12);
            this.pnlFiltroNome.Name = "pnlFiltroNome";
            this.pnlFiltroNome.Size = new System.Drawing.Size(205, 53);
            this.pnlFiltroNome.TabIndex = 137;
            this.pnlFiltroNome.Visible = false;
            // 
            // tbFiltroNome
            // 
            this.tbFiltroNome.Location = new System.Drawing.Point(6, 17);
            this.tbFiltroNome.Name = "tbFiltroNome";
            this.tbFiltroNome.Size = new System.Drawing.Size(196, 31);
            this.tbFiltroNome.TabIndex = 0;
            this.tbFiltroNome.TextChanged += new System.EventHandler(this.tbFiltroNome_TextChanged);
            // 
            // pnlFiltroData
            // 
            this.pnlFiltroData.Controls.Add(this.dtpFiltroData);
            this.pnlFiltroData.Location = new System.Drawing.Point(306, 12);
            this.pnlFiltroData.Name = "pnlFiltroData";
            this.pnlFiltroData.Size = new System.Drawing.Size(205, 53);
            this.pnlFiltroData.TabIndex = 138;
            this.pnlFiltroData.Visible = false;
            // 
            // dtpFiltroData
            // 
            this.dtpFiltroData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFiltroData.Location = new System.Drawing.Point(0, 17);
            this.dtpFiltroData.Name = "dtpFiltroData";
            this.dtpFiltroData.Size = new System.Drawing.Size(200, 31);
            this.dtpFiltroData.TabIndex = 0;
            this.dtpFiltroData.ValueChanged += new System.EventHandler(this.dtpFiltroData_ValueChanged);
            // 
            // btnUtenti
            // 
            this.btnUtenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUtenti.Location = new System.Drawing.Point(15, 435);
            this.btnUtenti.Name = "btnUtenti";
            this.btnUtenti.Size = new System.Drawing.Size(145, 72);
            this.btnUtenti.TabIndex = 139;
            this.btnUtenti.Text = "👯‍♂️ Gestisci Utenti";
            this.btnUtenti.UseVisualStyleBackColor = true;
            this.btnUtenti.Click += new System.EventHandler(this.btnUtenti_Click);
            // 
            // btnRisposteStandard
            // 
            this.btnRisposteStandard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRisposteStandard.Location = new System.Drawing.Point(473, 435);
            this.btnRisposteStandard.Name = "btnRisposteStandard";
            this.btnRisposteStandard.Size = new System.Drawing.Size(203, 72);
            this.btnRisposteStandard.TabIndex = 140;
            this.btnRisposteStandard.Text = "📝Gestisci Risposte Standard";
            this.btnRisposteStandard.UseVisualStyleBackColor = true;
            this.btnRisposteStandard.Click += new System.EventHandler(this.btnRisposteStandard_Click);
            // 
            // rbStatoChiuso
            // 
            this.rbStatoChiuso.AutoSize = true;
            this.rbStatoChiuso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.rbStatoChiuso.Location = new System.Drawing.Point(137, 3);
            this.rbStatoChiuso.Name = "rbStatoChiuso";
            this.rbStatoChiuso.Size = new System.Drawing.Size(97, 29);
            this.rbStatoChiuso.TabIndex = 144;
            this.rbStatoChiuso.TabStop = true;
            this.rbStatoChiuso.Text = "Chiuso";
            this.rbStatoChiuso.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(922, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 24);
            this.label8.TabIndex = 142;
            this.label8.Text = "Stato";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(921, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 25);
            this.label9.TabIndex = 143;
            this.label9.Text = "📝";
            // 
            // rbStatoAperto
            // 
            this.rbStatoAperto.AutoSize = true;
            this.rbStatoAperto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.rbStatoAperto.Location = new System.Drawing.Point(17, 3);
            this.rbStatoAperto.Name = "rbStatoAperto";
            this.rbStatoAperto.Size = new System.Drawing.Size(93, 29);
            this.rbStatoAperto.TabIndex = 141;
            this.rbStatoAperto.TabStop = true;
            this.rbStatoAperto.Text = "Aperto";
            this.rbStatoAperto.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbStatoChiuso);
            this.panel1.Controls.Add(this.rbStatoAperto);
            this.panel1.Location = new System.Drawing.Point(959, 216);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 35);
            this.panel1.TabIndex = 145;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbRegistrati);
            this.panel2.Controls.Add(this.rbAnonimo);
            this.panel2.Location = new System.Drawing.Point(956, 266);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(307, 33);
            this.panel2.TabIndex = 146;
            // 
            // FrmCreaSondaggi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 512);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnRisposteStandard);
            this.Controls.Add(this.btnUtenti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.btnStatistiche);
            this.Controls.Add(this.btnCategorie);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.btnDomande);
            this.Controls.Add(this.cbDomandeFiltro);
            this.Controls.Add(this.lvDomande);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnAnnulla);
            this.Controls.Add(this.btnAggiungi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lblDomanda);
            this.Controls.Add(this.pnlFiltroStato);
            this.Controls.Add(this.pnlFiltroID);
            this.Controls.Add(this.pnlFiltroData);
            this.Controls.Add(this.pnlFiltroTipo);
            this.Controls.Add(this.pnlFiltroNome);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmCreaSondaggi";
            this.Text = "FrmSondaggi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCreaSondaggi_FormClosing);
            this.Load += new System.EventHandler(this.FrmCreaSondaggi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudID)).EndInit();
            this.pnlFiltroID.ResumeLayout(false);
            this.pnlFiltroID.PerformLayout();
            this.pnlFiltroTipo.ResumeLayout(false);
            this.pnlFiltroTipo.PerformLayout();
            this.pnlFiltroStato.ResumeLayout(false);
            this.pnlFiltroStato.PerformLayout();
            this.pnlFiltroNome.ResumeLayout(false);
            this.pnlFiltroNome.PerformLayout();
            this.pnlFiltroData.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbDomandeFiltro;
        private System.Windows.Forms.ListView lvDomande;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.RadioButton rbRegistrati;
        private System.Windows.Forms.Button btnAnnulla;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.RadioButton rbAnonimo;
        private System.Windows.Forms.Label lblDomanda;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnDomande;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Button btnCategorie;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnStatistiche;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudID;
        private System.Windows.Forms.Panel pnlFiltroID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlFiltroTipo;
        private System.Windows.Forms.RadioButton rbFiltroRegistrato;
        private System.Windows.Forms.RadioButton rbFiltroAnonimo;
        private System.Windows.Forms.Panel pnlFiltroStato;
        private System.Windows.Forms.RadioButton rbFiltroChiuso;
        private System.Windows.Forms.RadioButton rbFiltroAperto;
        private System.Windows.Forms.Panel pnlFiltroNome;
        private System.Windows.Forms.TextBox tbFiltroNome;
        private System.Windows.Forms.Panel pnlFiltroData;
        private System.Windows.Forms.DateTimePicker dtpFiltroData;
        private System.Windows.Forms.Button btnUtenti;
        private System.Windows.Forms.Button btnRisposteStandard;
        private System.Windows.Forms.RadioButton rbStatoChiuso;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rbStatoAperto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}