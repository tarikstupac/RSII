namespace VGFeed.WinUI.Sale
{
    partial class frmSales
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.SaleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleLink = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.dtpDatumOd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDatumDo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvSales);
            this.panel1.Location = new System.Drawing.Point(36, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1351, 442);
            this.panel1.TabIndex = 0;
            // 
            // dgvSales
            // 
            this.dgvSales.AllowUserToAddRows = false;
            this.dgvSales.AllowUserToDeleteRows = false;
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SaleId,
            this.Naziv,
            this.DatumStart,
            this.DatumEnd,
            this.SaleLink});
            this.dgvSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSales.Location = new System.Drawing.Point(0, 0);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.ReadOnly = true;
            this.dgvSales.RowTemplate.Height = 40;
            this.dgvSales.Size = new System.Drawing.Size(1351, 442);
            this.dgvSales.TabIndex = 0;
            this.dgvSales.DoubleClick += new System.EventHandler(this.dgvSales_DoubleClick);
            // 
            // SaleId
            // 
            this.SaleId.DataPropertyName = "SaleId";
            this.SaleId.HeaderText = "SaleId";
            this.SaleId.Name = "SaleId";
            this.SaleId.ReadOnly = true;
            this.SaleId.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // DatumStart
            // 
            this.DatumStart.DataPropertyName = "DatumStart";
            this.DatumStart.HeaderText = "Datum početka";
            this.DatumStart.Name = "DatumStart";
            this.DatumStart.ReadOnly = true;
            // 
            // DatumEnd
            // 
            this.DatumEnd.DataPropertyName = "DatumEnd";
            this.DatumEnd.HeaderText = "Datum Završetka";
            this.DatumEnd.Name = "DatumEnd";
            this.DatumEnd.ReadOnly = true;
            // 
            // SaleLink
            // 
            this.SaleLink.DataPropertyName = "SaleLink";
            this.SaleLink.HeaderText = "Link";
            this.SaleLink.Name = "SaleLink";
            this.SaleLink.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(36, 64);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(165, 38);
            this.txtNaziv.TabIndex = 2;
            // 
            // dtpDatumOd
            // 
            this.dtpDatumOd.Location = new System.Drawing.Point(257, 64);
            this.dtpDatumOd.Name = "dtpDatumOd";
            this.dtpDatumOd.Size = new System.Drawing.Size(463, 38);
            this.dtpDatumOd.TabIndex = 3;
            this.dtpDatumOd.Value = new System.DateTime(1755, 1, 1, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Datum Od";
            // 
            // dtpDatumDo
            // 
            this.dtpDatumDo.Location = new System.Drawing.Point(745, 64);
            this.dtpDatumDo.Name = "dtpDatumDo";
            this.dtpDatumDo.Size = new System.Drawing.Size(463, 38);
            this.dtpDatumDo.TabIndex = 5;
            this.dtpDatumDo.Value = new System.DateTime(2750, 12, 31, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(739, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Datum Do";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1237, 46);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 55);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Pretraga";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 636);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDatumDo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDatumOd);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "frmSales";
            this.Text = "frmSales";
            this.Load += new System.EventHandler(this.frmSales_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.DateTimePicker dtpDatumOd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDatumDo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleLink;
    }
}