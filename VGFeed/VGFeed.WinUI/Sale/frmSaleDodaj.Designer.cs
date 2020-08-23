namespace VGFeed.WinUI.Sale
{
    partial class frmSaleDodaj
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.cmbStore = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDatumStart = new System.Windows.Forms.DateTimePicker();
            this.dtpDatumEnd = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIgraNaziv = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvIgre = new System.Windows.Forms.DataGridView();
            this.IgraId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Platforma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrenutnaCijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPopust = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIgraLink = new System.Windows.Forms.TextBox();
            this.chbFizicka = new System.Windows.Forms.CheckBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvIgrePopust = new System.Windows.Forms.DataGridView();
            this.NazivIgre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlatformaIgre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIgre)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIgrePopust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Online Store";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(316, 88);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(274, 38);
            this.txtNaziv.TabIndex = 1;
            this.txtNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.txtNaziv_Validating);
            // 
            // cmbStore
            // 
            this.cmbStore.FormattingEnabled = true;
            this.cmbStore.Location = new System.Drawing.Point(49, 87);
            this.cmbStore.Name = "cmbStore";
            this.cmbStore.Size = new System.Drawing.Size(239, 39);
            this.cmbStore.TabIndex = 2;
            this.cmbStore.Validating += new System.ComponentModel.CancelEventHandler(this.cmbStore_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Naziv";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(614, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Datum početka";
            // 
            // dtpDatumStart
            // 
            this.dtpDatumStart.Location = new System.Drawing.Point(620, 88);
            this.dtpDatumStart.Name = "dtpDatumStart";
            this.dtpDatumStart.Size = new System.Drawing.Size(462, 38);
            this.dtpDatumStart.TabIndex = 5;
            this.dtpDatumStart.Validating += new System.ComponentModel.CancelEventHandler(this.dtpDatumStart_Validating);
            // 
            // dtpDatumEnd
            // 
            this.dtpDatumEnd.Location = new System.Drawing.Point(1121, 88);
            this.dtpDatumEnd.Name = "dtpDatumEnd";
            this.dtpDatumEnd.Size = new System.Drawing.Size(462, 38);
            this.dtpDatumEnd.TabIndex = 7;
            this.dtpDatumEnd.Validating += new System.ComponentModel.CancelEventHandler(this.dtpDatumEnd_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1115, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Datum završetka";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "Naziv igre";
            // 
            // txtIgraNaziv
            // 
            this.txtIgraNaziv.Location = new System.Drawing.Point(49, 247);
            this.txtIgraNaziv.Name = "txtIgraNaziv";
            this.txtIgraNaziv.Size = new System.Drawing.Size(279, 38);
            this.txtIgraNaziv.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(352, 235);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(147, 50);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Pretraga";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvIgre);
            this.panel1.Location = new System.Drawing.Point(49, 361);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 443);
            this.panel1.TabIndex = 11;
            // 
            // dgvIgre
            // 
            this.dgvIgre.AllowUserToAddRows = false;
            this.dgvIgre.AllowUserToDeleteRows = false;
            this.dgvIgre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIgre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IgraId,
            this.Naziv,
            this.Platforma,
            this.TrenutnaCijena});
            this.dgvIgre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIgre.Location = new System.Drawing.Point(0, 0);
            this.dgvIgre.Name = "dgvIgre";
            this.dgvIgre.ReadOnly = true;
            this.dgvIgre.RowTemplate.Height = 40;
            this.dgvIgre.Size = new System.Drawing.Size(847, 443);
            this.dgvIgre.TabIndex = 0;
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
            // Platforma
            // 
            this.Platforma.DataPropertyName = "PlatformNaziv";
            this.Platforma.HeaderText = "Platforma";
            this.Platforma.Name = "Platforma";
            this.Platforma.ReadOnly = true;
            // 
            // TrenutnaCijena
            // 
            this.TrenutnaCijena.DataPropertyName = "TrenutnaCijena";
            this.TrenutnaCijena.HeaderText = "Trenutna Cijena";
            this.TrenutnaCijena.Name = "TrenutnaCijena";
            this.TrenutnaCijena.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 32);
            this.label6.TabIndex = 12;
            this.label6.Text = "Rezultat pretrage";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(614, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 32);
            this.label7.TabIndex = 14;
            this.label7.Text = "Sale Link";
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(620, 247);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(462, 38);
            this.txtLink.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 833);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 32);
            this.label8.TabIndex = 16;
            this.label8.Text = "Popust u %";
            // 
            // txtPopust
            // 
            this.txtPopust.Location = new System.Drawing.Point(49, 884);
            this.txtPopust.Name = "txtPopust";
            this.txtPopust.Size = new System.Drawing.Size(135, 38);
            this.txtPopust.TabIndex = 15;
            this.txtPopust.Validating += new System.ComponentModel.CancelEventHandler(this.txtPopust_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(219, 833);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(226, 32);
            this.label9.TabIndex = 18;
            this.label9.Text = "Store link za igru";
            // 
            // txtIgraLink
            // 
            this.txtIgraLink.Location = new System.Drawing.Point(225, 884);
            this.txtIgraLink.Name = "txtIgraLink";
            this.txtIgraLink.Size = new System.Drawing.Size(274, 38);
            this.txtIgraLink.TabIndex = 17;
            // 
            // chbFizicka
            // 
            this.chbFizicka.AutoSize = true;
            this.chbFizicka.Location = new System.Drawing.Point(516, 884);
            this.chbFizicka.Name = "chbFizicka";
            this.chbFizicka.Size = new System.Drawing.Size(241, 36);
            this.chbFizicka.TabIndex = 19;
            this.chbFizicka.Text = "Fizička kopija?";
            this.chbFizicka.UseVisualStyleBackColor = true;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(763, 869);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(133, 53);
            this.btnDodaj.TabIndex = 20;
            this.btnDodaj.Text = "Dodaj >";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvIgrePopust);
            this.panel2.Location = new System.Drawing.Point(981, 361);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(662, 443);
            this.panel2.TabIndex = 21;
            // 
            // dgvIgrePopust
            // 
            this.dgvIgrePopust.AllowUserToAddRows = false;
            this.dgvIgrePopust.AllowUserToDeleteRows = false;
            this.dgvIgrePopust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIgrePopust.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NazivIgre,
            this.Cijena,
            this.PlatformaIgre});
            this.dgvIgrePopust.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIgrePopust.Location = new System.Drawing.Point(0, 0);
            this.dgvIgrePopust.Name = "dgvIgrePopust";
            this.dgvIgrePopust.ReadOnly = true;
            this.dgvIgrePopust.RowTemplate.Height = 40;
            this.dgvIgrePopust.Size = new System.Drawing.Size(662, 443);
            this.dgvIgrePopust.TabIndex = 0;
            // 
            // NazivIgre
            // 
            this.NazivIgre.DataPropertyName = "Naziv";
            this.NazivIgre.HeaderText = "Naziv";
            this.NazivIgre.Name = "NazivIgre";
            this.NazivIgre.ReadOnly = true;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // PlatformaIgre
            // 
            this.PlatformaIgre.DataPropertyName = "Platforma";
            this.PlatformaIgre.HeaderText = "Platforma";
            this.PlatformaIgre.Name = "PlatformaIgre";
            this.PlatformaIgre.ReadOnly = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1121, 304);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(395, 32);
            this.label10.TabIndex = 22;
            this.label10.Text = "Igre koje su dodane na popust";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(1445, 869);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(197, 65);
            this.btnSacuvaj.TabIndex = 23;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmSaleDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1687, 967);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.chbFizicka);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtIgraLink);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPopust);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtIgraNaziv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpDatumEnd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpDatumStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbStore);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label1);
            this.Name = "frmSaleDodaj";
            this.Text = "Sale Dodaj";
            this.Load += new System.EventHandler(this.SaleDodaj_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIgre)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIgrePopust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.ComboBox cmbStore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDatumStart;
        private System.Windows.Forms.DateTimePicker dtpDatumEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIgraNaziv;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvIgre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPopust;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIgraLink;
        private System.Windows.Forms.CheckBox chbFizicka;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvIgrePopust;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn IgraId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Platforma;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrenutnaCijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivIgre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlatformaIgre;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}