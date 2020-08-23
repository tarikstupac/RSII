namespace VGFeed.WinUI.Sale
{
    partial class frmSaleDetalji
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
            this.cmbStore = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDatumStart = new System.Windows.Forms.DateTimePicker();
            this.dtpDatumEnd = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvIgre = new System.Windows.Forms.DataGridView();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.SaleDetaljiId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IgraNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IgraPlatformNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Popust = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FizickaKopija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreLink = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPopust = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIgraLink = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chbFizicka = new System.Windows.Forms.CheckBox();
            this.btnIzmjena = new System.Windows.Forms.Button();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIgre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Online Store";
            // 
            // cmbStore
            // 
            this.cmbStore.FormattingEnabled = true;
            this.cmbStore.Location = new System.Drawing.Point(46, 86);
            this.cmbStore.Name = "cmbStore";
            this.cmbStore.Size = new System.Drawing.Size(252, 39);
            this.cmbStore.TabIndex = 1;
            this.cmbStore.Validating += new System.ComponentModel.CancelEventHandler(this.cmbStore_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Naziv";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(351, 86);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(305, 38);
            this.txtNaziv.TabIndex = 3;
            this.txtNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.txtNaziv_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(702, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Datum početka";
            // 
            // dtpDatumStart
            // 
            this.dtpDatumStart.Location = new System.Drawing.Point(708, 86);
            this.dtpDatumStart.Name = "dtpDatumStart";
            this.dtpDatumStart.Size = new System.Drawing.Size(467, 38);
            this.dtpDatumStart.TabIndex = 5;
            this.dtpDatumStart.Validating += new System.ComponentModel.CancelEventHandler(this.dtpDatumStart_Validating);
            // 
            // dtpDatumEnd
            // 
            this.dtpDatumEnd.Location = new System.Drawing.Point(708, 204);
            this.dtpDatumEnd.Name = "dtpDatumEnd";
            this.dtpDatumEnd.Size = new System.Drawing.Size(467, 38);
            this.dtpDatumEnd.TabIndex = 7;
            this.dtpDatumEnd.Validating += new System.ComponentModel.CancelEventHandler(this.dtpDatumEnd_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(702, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Datum završetka";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(46, 207);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(610, 38);
            this.txtLink.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sale Link";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvIgre);
            this.panel1.Location = new System.Drawing.Point(46, 323);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1129, 540);
            this.panel1.TabIndex = 10;
            // 
            // dgvIgre
            // 
            this.dgvIgre.AllowUserToAddRows = false;
            this.dgvIgre.AllowUserToDeleteRows = false;
            this.dgvIgre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIgre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SaleDetaljiId,
            this.IgraNaziv,
            this.IgraPlatformNaziv,
            this.Popust,
            this.Cijena,
            this.FizickaKopija,
            this.StoreLink});
            this.dgvIgre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIgre.Location = new System.Drawing.Point(0, 0);
            this.dgvIgre.Name = "dgvIgre";
            this.dgvIgre.ReadOnly = true;
            this.dgvIgre.RowTemplate.Height = 40;
            this.dgvIgre.Size = new System.Drawing.Size(1129, 540);
            this.dgvIgre.TabIndex = 0;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // SaleDetaljiId
            // 
            this.SaleDetaljiId.DataPropertyName = "SaleDetaljiId";
            this.SaleDetaljiId.HeaderText = "SaleDetaljiId";
            this.SaleDetaljiId.Name = "SaleDetaljiId";
            this.SaleDetaljiId.ReadOnly = true;
            this.SaleDetaljiId.Visible = false;
            // 
            // IgraNaziv
            // 
            this.IgraNaziv.DataPropertyName = "IgraNaziv";
            this.IgraNaziv.HeaderText = "Naziv";
            this.IgraNaziv.Name = "IgraNaziv";
            this.IgraNaziv.ReadOnly = true;
            // 
            // IgraPlatformNaziv
            // 
            this.IgraPlatformNaziv.DataPropertyName = "IgraPlatformNaziv";
            this.IgraPlatformNaziv.HeaderText = "Platforma";
            this.IgraPlatformNaziv.Name = "IgraPlatformNaziv";
            this.IgraPlatformNaziv.ReadOnly = true;
            // 
            // Popust
            // 
            this.Popust.DataPropertyName = "Popust";
            this.Popust.HeaderText = "Popust u %";
            this.Popust.Name = "Popust";
            this.Popust.ReadOnly = true;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // FizickaKopija
            // 
            this.FizickaKopija.DataPropertyName = "FizickaKopija";
            this.FizickaKopija.HeaderText = "Fizicka Kopija?";
            this.FizickaKopija.Name = "FizickaKopija";
            this.FizickaKopija.ReadOnly = true;
            // 
            // StoreLink
            // 
            this.StoreLink.DataPropertyName = "StoreLink";
            this.StoreLink.HeaderText = "Link";
            this.StoreLink.Name = "StoreLink";
            this.StoreLink.ReadOnly = true;
            // 
            // txtPopust
            // 
            this.txtPopust.Location = new System.Drawing.Point(46, 943);
            this.txtPopust.Name = "txtPopust";
            this.txtPopust.Size = new System.Drawing.Size(127, 38);
            this.txtPopust.TabIndex = 12;
            this.txtPopust.Validating += new System.ComponentModel.CancelEventHandler(this.txtPopust_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 890);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 32);
            this.label6.TabIndex = 11;
            this.label6.Text = "Popust u %";
            // 
            // txtIgraLink
            // 
            this.txtIgraLink.Location = new System.Drawing.Point(476, 943);
            this.txtIgraLink.Name = "txtIgraLink";
            this.txtIgraLink.Size = new System.Drawing.Size(327, 38);
            this.txtIgraLink.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(470, 890);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 32);
            this.label7.TabIndex = 13;
            this.label7.Text = "Link";
            // 
            // chbFizicka
            // 
            this.chbFizicka.AutoSize = true;
            this.chbFizicka.Location = new System.Drawing.Point(224, 944);
            this.chbFizicka.Name = "chbFizicka";
            this.chbFizicka.Size = new System.Drawing.Size(225, 36);
            this.chbFizicka.TabIndex = 15;
            this.chbFizicka.Text = "Fizička kopija";
            this.chbFizicka.UseVisualStyleBackColor = true;
            // 
            // btnIzmjena
            // 
            this.btnIzmjena.Location = new System.Drawing.Point(830, 930);
            this.btnIzmjena.Name = "btnIzmjena";
            this.btnIzmjena.Size = new System.Drawing.Size(155, 50);
            this.btnIzmjena.TabIndex = 16;
            this.btnIzmjena.Text = "Izmjeni";
            this.btnIzmjena.UseVisualStyleBackColor = true;
            this.btnIzmjena.Click += new System.EventHandler(this.btnIzmjena_Click);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(1043, 930);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(172, 84);
            this.btnSacuvaj.TabIndex = 17;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // frmSaleDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 1041);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.btnIzmjena);
            this.Controls.Add(this.chbFizicka);
            this.Controls.Add(this.txtIgraLink);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPopust);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpDatumEnd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpDatumStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbStore);
            this.Controls.Add(this.label1);
            this.Name = "frmSaleDetalji";
            this.Text = "frmSaleDetalji";
            this.Load += new System.EventHandler(this.frmSaleDetalji_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIgre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbStore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDatumStart;
        private System.Windows.Forms.DateTimePicker dtpDatumEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvIgre;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleDetaljiId;
        private System.Windows.Forms.DataGridViewTextBoxColumn IgraNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn IgraPlatformNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Popust;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn FizickaKopija;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreLink;
        private System.Windows.Forms.TextBox txtPopust;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chbFizicka;
        private System.Windows.Forms.TextBox txtIgraLink;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnIzmjena;
    }
}