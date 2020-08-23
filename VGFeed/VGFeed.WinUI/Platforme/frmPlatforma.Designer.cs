namespace VGFeed.WinUI.Platforme
{
    partial class frmPlatforma
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
            this.txtSkracenica = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLogo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUcitaj = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSačuvaj = new System.Windows.Forms.Button();
            this.dgvPlatforme = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.PlatformId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Skracenica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Logo = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlatforme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(63, 89);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(348, 38);
            this.txtNaziv.TabIndex = 1;
            this.txtNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.txtNaziv_Validating);
            // 
            // txtSkracenica
            // 
            this.txtSkracenica.Location = new System.Drawing.Point(63, 187);
            this.txtSkracenica.Name = "txtSkracenica";
            this.txtSkracenica.Size = new System.Drawing.Size(348, 38);
            this.txtSkracenica.TabIndex = 3;
            this.txtSkracenica.Validating += new System.ComponentModel.CancelEventHandler(this.txtSkracenica_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Skraćenica";
            // 
            // txtLogo
            // 
            this.txtLogo.Location = new System.Drawing.Point(63, 287);
            this.txtLogo.Name = "txtLogo";
            this.txtLogo.Size = new System.Drawing.Size(348, 38);
            this.txtLogo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Logo";
            // 
            // btnUcitaj
            // 
            this.btnUcitaj.Location = new System.Drawing.Point(427, 282);
            this.btnUcitaj.Name = "btnUcitaj";
            this.btnUcitaj.Size = new System.Drawing.Size(127, 47);
            this.btnUcitaj.TabIndex = 6;
            this.btnUcitaj.Text = "Učitaj";
            this.btnUcitaj.UseVisualStyleBackColor = true;
            this.btnUcitaj.Click += new System.EventHandler(this.btnUcitaj_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Location = new System.Drawing.Point(636, 89);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(280, 136);
            this.pbLogo.TabIndex = 7;
            this.pbLogo.TabStop = false;
            this.pbLogo.Validating += new System.ComponentModel.CancelEventHandler(this.pbLogo_Validating);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvPlatforme);
            this.panel1.Location = new System.Drawing.Point(63, 390);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 370);
            this.panel1.TabIndex = 8;
            // 
            // btnSačuvaj
            // 
            this.btnSačuvaj.Location = new System.Drawing.Point(771, 779);
            this.btnSačuvaj.Name = "btnSačuvaj";
            this.btnSačuvaj.Size = new System.Drawing.Size(145, 54);
            this.btnSačuvaj.TabIndex = 9;
            this.btnSačuvaj.Text = "Sačuvaj";
            this.btnSačuvaj.UseVisualStyleBackColor = true;
            this.btnSačuvaj.Click += new System.EventHandler(this.btnSačuvaj_Click);
            // 
            // dgvPlatforme
            // 
            this.dgvPlatforme.AllowUserToAddRows = false;
            this.dgvPlatforme.AllowUserToDeleteRows = false;
            this.dgvPlatforme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlatforme.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlatformId,
            this.Naziv,
            this.Skracenica,
            this.Logo});
            this.dgvPlatforme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPlatforme.Location = new System.Drawing.Point(0, 0);
            this.dgvPlatforme.Name = "dgvPlatforme";
            this.dgvPlatforme.ReadOnly = true;
            this.dgvPlatforme.RowTemplate.Height = 40;
            this.dgvPlatforme.Size = new System.Drawing.Size(853, 370);
            this.dgvPlatforme.TabIndex = 0;
            this.dgvPlatforme.DoubleClick += new System.EventHandler(this.dgvPlatforme_DoubleClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // PlatformId
            // 
            this.PlatformId.DataPropertyName = "PlatformId";
            this.PlatformId.HeaderText = "PlatformId";
            this.PlatformId.Name = "PlatformId";
            this.PlatformId.ReadOnly = true;
            this.PlatformId.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Skracenica
            // 
            this.Skracenica.DataPropertyName = "Skracenica";
            this.Skracenica.HeaderText = "Skraćenica";
            this.Skracenica.Name = "Skracenica";
            this.Skracenica.ReadOnly = true;
            // 
            // Logo
            // 
            this.Logo.DataPropertyName = "Logo";
            this.Logo.HeaderText = "Logo";
            this.Logo.Name = "Logo";
            this.Logo.ReadOnly = true;
            this.Logo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Logo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmPlatforma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 858);
            this.Controls.Add(this.btnSačuvaj);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.btnUcitaj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLogo);
            this.Controls.Add(this.txtSkracenica);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label1);
            this.Name = "frmPlatforma";
            this.Text = "frmPlatforma";
            this.Load += new System.EventHandler(this.frmPlatforma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlatforme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtSkracenica;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLogo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUcitaj;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPlatforme;
        private System.Windows.Forms.Button btnSačuvaj;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlatformId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Skracenica;
        private System.Windows.Forms.DataGridViewImageColumn Logo;
    }
}