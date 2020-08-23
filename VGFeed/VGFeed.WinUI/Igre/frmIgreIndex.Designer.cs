namespace VGFeed.WinUI.Igre
{
    partial class frmIgreIndex
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
            this.cmbPlatforme = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbZanr = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvIgre = new System.Windows.Forms.DataGridView();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.btnPlatforme = new System.Windows.Forms.Button();
            this.btnZanrovi = new System.Windows.Forms.Button();
            this.IgraId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrenutnaCijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlatformNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZanrNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumIzlaska = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MetacriticOcjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Multiplayer = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SlikaThumb = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIgre)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPlatforme
            // 
            this.cmbPlatforme.FormattingEnabled = true;
            this.cmbPlatforme.Location = new System.Drawing.Point(191, 45);
            this.cmbPlatforme.Name = "cmbPlatforme";
            this.cmbPlatforme.Size = new System.Drawing.Size(263, 39);
            this.cmbPlatforme.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Platforma";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(472, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Žanr";
            // 
            // cmbZanr
            // 
            this.cmbZanr.FormattingEnabled = true;
            this.cmbZanr.Location = new System.Drawing.Point(551, 45);
            this.cmbZanr.Name = "cmbZanr";
            this.cmbZanr.Size = new System.Drawing.Size(263, 39);
            this.cmbZanr.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(848, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Naziv";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(941, 45);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(308, 38);
            this.txtNaziv.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvIgre);
            this.panel1.Location = new System.Drawing.Point(54, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 710);
            this.panel1.TabIndex = 6;
            // 
            // dgvIgre
            // 
            this.dgvIgre.AllowUserToAddRows = false;
            this.dgvIgre.AllowUserToDeleteRows = false;
            this.dgvIgre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIgre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IgraId,
            this.Naziv,
            this.TrenutnaCijena,
            this.PlatformNaziv,
            this.ZanrNaziv,
            this.DatumIzlaska,
            this.MetacriticOcjena,
            this.Multiplayer,
            this.SlikaThumb});
            this.dgvIgre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIgre.Location = new System.Drawing.Point(0, 0);
            this.dgvIgre.Name = "dgvIgre";
            this.dgvIgre.ReadOnly = true;
            this.dgvIgre.RowTemplate.Height = 40;
            this.dgvIgre.Size = new System.Drawing.Size(1370, 710);
            this.dgvIgre.TabIndex = 0;
            this.dgvIgre.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIgre_CellContentClick);
            this.dgvIgre.DoubleClick += new System.EventHandler(this.dgvIgre_DoubleClick);
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(1283, 37);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(158, 63);
            this.btnPretraga.TabIndex = 7;
            this.btnPretraga.Text = "Pretraga";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // btnPlatforme
            // 
            this.btnPlatforme.Location = new System.Drawing.Point(54, 868);
            this.btnPlatforme.Name = "btnPlatforme";
            this.btnPlatforme.Size = new System.Drawing.Size(197, 48);
            this.btnPlatforme.TabIndex = 8;
            this.btnPlatforme.Text = "Platforme";
            this.btnPlatforme.UseVisualStyleBackColor = true;
            this.btnPlatforme.Click += new System.EventHandler(this.btnPlatforme_Click);
            // 
            // btnZanrovi
            // 
            this.btnZanrovi.Location = new System.Drawing.Point(286, 868);
            this.btnZanrovi.Name = "btnZanrovi";
            this.btnZanrovi.Size = new System.Drawing.Size(197, 48);
            this.btnZanrovi.TabIndex = 9;
            this.btnZanrovi.Text = "Žanrovi";
            this.btnZanrovi.UseVisualStyleBackColor = true;
            this.btnZanrovi.Click += new System.EventHandler(this.btnZanrovi_Click);
            // 
            // IgraId
            // 
            this.IgraId.DataPropertyName = "IgraId";
            this.IgraId.HeaderText = "IgraId";
            this.IgraId.Name = "IgraId";
            this.IgraId.ReadOnly = true;
            this.IgraId.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // TrenutnaCijena
            // 
            this.TrenutnaCijena.DataPropertyName = "TrenutnaCijena";
            this.TrenutnaCijena.HeaderText = "Trenutna Cijena";
            this.TrenutnaCijena.Name = "TrenutnaCijena";
            this.TrenutnaCijena.ReadOnly = true;
            // 
            // PlatformNaziv
            // 
            this.PlatformNaziv.DataPropertyName = "PlatformNaziv";
            this.PlatformNaziv.HeaderText = "Platforma";
            this.PlatformNaziv.Name = "PlatformNaziv";
            this.PlatformNaziv.ReadOnly = true;
            // 
            // ZanrNaziv
            // 
            this.ZanrNaziv.DataPropertyName = "ZanrNaziv";
            this.ZanrNaziv.HeaderText = "Žanr";
            this.ZanrNaziv.Name = "ZanrNaziv";
            this.ZanrNaziv.ReadOnly = true;
            // 
            // DatumIzlaska
            // 
            this.DatumIzlaska.HeaderText = "Datum izlaska";
            this.DatumIzlaska.Name = "DatumIzlaska";
            this.DatumIzlaska.ReadOnly = true;
            // 
            // MetacriticOcjena
            // 
            this.MetacriticOcjena.DataPropertyName = "MetacriticOcjena";
            this.MetacriticOcjena.HeaderText = "Metacritic Ocjena";
            this.MetacriticOcjena.Name = "MetacriticOcjena";
            this.MetacriticOcjena.ReadOnly = true;
            // 
            // Multiplayer
            // 
            this.Multiplayer.DataPropertyName = "Multiplayer";
            this.Multiplayer.HeaderText = "Multiplayer";
            this.Multiplayer.Name = "Multiplayer";
            this.Multiplayer.ReadOnly = true;
            // 
            // SlikaThumb
            // 
            this.SlikaThumb.DataPropertyName = "SlikaThumb";
            this.SlikaThumb.HeaderText = "Slika";
            this.SlikaThumb.Name = "SlikaThumb";
            this.SlikaThumb.ReadOnly = true;
            // 
            // frmIgreIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1499, 948);
            this.Controls.Add(this.btnZanrovi);
            this.Controls.Add(this.btnPlatforme);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbZanr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPlatforme);
            this.Name = "frmIgreIndex";
            this.Text = "frmIgreIndex";
            this.Load += new System.EventHandler(this.frmIgreIndex_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIgre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPlatforme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbZanr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvIgre;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.Button btnPlatforme;
        private System.Windows.Forms.Button btnZanrovi;
        private System.Windows.Forms.DataGridViewTextBoxColumn IgraId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrenutnaCijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlatformNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZanrNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumIzlaska;
        private System.Windows.Forms.DataGridViewTextBoxColumn MetacriticOcjena;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Multiplayer;
        private System.Windows.Forms.DataGridViewImageColumn SlikaThumb;
    }
}