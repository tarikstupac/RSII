namespace VGFeed.WinUI.Izvjestaji
{
    partial class NajaktivnijiKorisnici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NajaktivnijiKorisnici));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvKorisnici = new System.Windows.Forms.DataGridView();
            this.cmbDrzava = new System.Windows.Forms.ComboBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojOdigranih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojZainteresiranih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UkupnaAktivnost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvKorisnici);
            this.panel1.Location = new System.Drawing.Point(45, 216);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1677, 747);
            this.panel1.TabIndex = 0;
            // 
            // dgvKorisnici
            // 
            this.dgvKorisnici.AllowUserToOrderColumns = true;
            this.dgvKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisnici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ime,
            this.Prezime,
            this.Username,
            this.BrojOdigranih,
            this.BrojZainteresiranih,
            this.UkupnaAktivnost});
            this.dgvKorisnici.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKorisnici.Location = new System.Drawing.Point(0, 0);
            this.dgvKorisnici.Name = "dgvKorisnici";
            this.dgvKorisnici.RowTemplate.Height = 40;
            this.dgvKorisnici.Size = new System.Drawing.Size(1677, 747);
            this.dgvKorisnici.TabIndex = 0;
            // 
            // cmbDrzava
            // 
            this.cmbDrzava.FormattingEnabled = true;
            this.cmbDrzava.Location = new System.Drawing.Point(59, 78);
            this.cmbDrzava.Name = "cmbDrzava";
            this.cmbDrzava.Size = new System.Drawing.Size(294, 39);
            this.cmbDrzava.TabIndex = 1;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(407, 79);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(261, 38);
            this.txtIme.TabIndex = 2;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(706, 79);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(261, 38);
            this.txtPrezime.TabIndex = 3;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(1006, 79);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(261, 38);
            this.txtUsername.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Država";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(714, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Prezime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1000, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Korisnicko ime";
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(1559, 59);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(163, 58);
            this.btnPretraga.TabIndex = 9;
            this.btnPretraga.Text = "Pretraga";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            // 
            // BrojOdigranih
            // 
            this.BrojOdigranih.DataPropertyName = "BrojOdigranih";
            this.BrojOdigranih.HeaderText = "Broj Odigranih";
            this.BrojOdigranih.Name = "BrojOdigranih";
            // 
            // BrojZainteresiranih
            // 
            this.BrojZainteresiranih.DataPropertyName = "BrojZainteresovanih";
            this.BrojZainteresiranih.HeaderText = "Broj Zainteresovanih";
            this.BrojZainteresiranih.Name = "BrojZainteresiranih";
            // 
            // UkupnaAktivnost
            // 
            this.UkupnaAktivnost.DataPropertyName = "UkupnaAktivnost";
            this.UkupnaAktivnost.HeaderText = "Ukupna Aktivnost";
            this.UkupnaAktivnost.Name = "UkupnaAktivnost";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1559, 980);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 59);
            this.button1.TabIndex = 10;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // NajaktivnijiKorisnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1774, 1064);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.cmbDrzava);
            this.Controls.Add(this.panel1);
            this.Name = "NajaktivnijiKorisnici";
            this.Text = "NajaktivnijiKorisnici";
            this.Load += new System.EventHandler(this.NajaktivnijiKorisnici_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvKorisnici;
        private System.Windows.Forms.ComboBox cmbDrzava;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojOdigranih;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojZainteresiranih;
        private System.Windows.Forms.DataGridViewTextBoxColumn UkupnaAktivnost;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}