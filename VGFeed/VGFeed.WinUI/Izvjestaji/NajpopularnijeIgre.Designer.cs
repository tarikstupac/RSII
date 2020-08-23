namespace VGFeed.WinUI.Izvjestaji
{
    partial class NajpopularnijeIgre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NajpopularnijeIgre));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvIgre = new System.Windows.Forms.DataGridView();
            this.cmbPlatforme = new System.Windows.Forms.ComboBox();
            this.cmbZanr = new System.Windows.Forms.ComboBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Platform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zanr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojZainteresovanih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojOdigranih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UkupnaAktivnost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIgre)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvIgre);
            this.panel1.Location = new System.Drawing.Point(24, 134);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1439, 784);
            this.panel1.TabIndex = 0;
            // 
            // dgvIgre
            // 
            this.dgvIgre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIgre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naziv,
            this.Platform,
            this.Zanr,
            this.BrojZainteresovanih,
            this.BrojOdigranih,
            this.UkupnaAktivnost});
            this.dgvIgre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIgre.Location = new System.Drawing.Point(0, 0);
            this.dgvIgre.Name = "dgvIgre";
            this.dgvIgre.RowTemplate.Height = 40;
            this.dgvIgre.Size = new System.Drawing.Size(1439, 784);
            this.dgvIgre.TabIndex = 0;
            // 
            // cmbPlatforme
            // 
            this.cmbPlatforme.FormattingEnabled = true;
            this.cmbPlatforme.Location = new System.Drawing.Point(41, 63);
            this.cmbPlatforme.Name = "cmbPlatforme";
            this.cmbPlatforme.Size = new System.Drawing.Size(259, 39);
            this.cmbPlatforme.TabIndex = 1;
            // 
            // cmbZanr
            // 
            this.cmbZanr.FormattingEnabled = true;
            this.cmbZanr.Location = new System.Drawing.Point(349, 63);
            this.cmbZanr.Name = "cmbZanr";
            this.cmbZanr.Size = new System.Drawing.Size(259, 39);
            this.cmbZanr.TabIndex = 2;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(681, 63);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(280, 38);
            this.txtNaziv.TabIndex = 3;
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(1312, 51);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(150, 50);
            this.btnPretraga.TabIndex = 4;
            this.btnPretraga.Text = "Pretraga";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1312, 955);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 50);
            this.button1.TabIndex = 5;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Platforme";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Zanrovi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(675, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Naziv";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            // 
            // Platform
            // 
            this.Platform.DataPropertyName = "PlatformNaziv";
            this.Platform.HeaderText = "Platform";
            this.Platform.Name = "Platform";
            // 
            // Zanr
            // 
            this.Zanr.DataPropertyName = "ZanrNaziv";
            this.Zanr.HeaderText = "Zanr";
            this.Zanr.Name = "Zanr";
            // 
            // BrojZainteresovanih
            // 
            this.BrojZainteresovanih.DataPropertyName = "BrojZainteresovanih";
            this.BrojZainteresovanih.HeaderText = "Interes korisnika";
            this.BrojZainteresovanih.Name = "BrojZainteresovanih";
            // 
            // BrojOdigranih
            // 
            this.BrojOdigranih.DataPropertyName = "BrojOdigranih";
            this.BrojOdigranih.HeaderText = "Broj puta odigrana";
            this.BrojOdigranih.Name = "BrojOdigranih";
            // 
            // UkupnaAktivnost
            // 
            this.UkupnaAktivnost.DataPropertyName = "UkupnaAktivnost";
            this.UkupnaAktivnost.HeaderText = "Ukupna Popularnost";
            this.UkupnaAktivnost.Name = "UkupnaAktivnost";
            // 
            // NajpopularnijeIgre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1503, 1028);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.cmbZanr);
            this.Controls.Add(this.cmbPlatforme);
            this.Controls.Add(this.panel1);
            this.Name = "NajpopularnijeIgre";
            this.Text = "NajpopularnijeIgre";
            this.Load += new System.EventHandler(this.NajpopularnijeIgre_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIgre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvIgre;
        private System.Windows.Forms.ComboBox cmbPlatforme;
        private System.Windows.Forms.ComboBox cmbZanr;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Platform;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zanr;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojZainteresovanih;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojOdigranih;
        private System.Windows.Forms.DataGridViewTextBoxColumn UkupnaAktivnost;
    }
}