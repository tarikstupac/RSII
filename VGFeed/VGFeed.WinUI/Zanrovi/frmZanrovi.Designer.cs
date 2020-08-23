﻿namespace VGFeed.WinUI.Zanrovi
{
    partial class frmZanrovi
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
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSkracenica = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvZanrovi = new System.Windows.Forms.DataGridView();
            this.ZanrId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Skracenica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZanrovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(36, 92);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(337, 38);
            this.txtNaziv.TabIndex = 1;
            this.txtNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.txtNaziv_Validating);
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(36, 215);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(337, 178);
            this.txtOpis.TabIndex = 3;
            this.txtOpis.Validating += new System.ComponentModel.CancelEventHandler(this.txtOpis_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Opis";
            // 
            // txtSkracenica
            // 
            this.txtSkracenica.Location = new System.Drawing.Point(36, 467);
            this.txtSkracenica.Name = "txtSkracenica";
            this.txtSkracenica.Size = new System.Drawing.Size(337, 38);
            this.txtSkracenica.TabIndex = 5;
            this.txtSkracenica.Validating += new System.ComponentModel.CancelEventHandler(this.txtSkracenica_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Skraćenica";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvZanrovi);
            this.panel1.Location = new System.Drawing.Point(492, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 413);
            this.panel1.TabIndex = 6;
            // 
            // dgvZanrovi
            // 
            this.dgvZanrovi.AllowUserToAddRows = false;
            this.dgvZanrovi.AllowUserToDeleteRows = false;
            this.dgvZanrovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZanrovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ZanrId,
            this.Naziv,
            this.Opis,
            this.Skracenica});
            this.dgvZanrovi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvZanrovi.Location = new System.Drawing.Point(0, 0);
            this.dgvZanrovi.Name = "dgvZanrovi";
            this.dgvZanrovi.ReadOnly = true;
            this.dgvZanrovi.RowTemplate.Height = 40;
            this.dgvZanrovi.Size = new System.Drawing.Size(795, 413);
            this.dgvZanrovi.TabIndex = 0;
            this.dgvZanrovi.DoubleClick += new System.EventHandler(this.dgvZanrovi_DoubleClick);
            // 
            // ZanrId
            // 
            this.ZanrId.DataPropertyName = "ZanrId";
            this.ZanrId.HeaderText = "ZanrId";
            this.ZanrId.Name = "ZanrId";
            this.ZanrId.ReadOnly = true;
            this.ZanrId.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Opis
            // 
            this.Opis.DataPropertyName = "Opis";
            this.Opis.HeaderText = "Opis";
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            // 
            // Skracenica
            // 
            this.Skracenica.DataPropertyName = "Skracenica";
            this.Skracenica.HeaderText = "Skraćenica";
            this.Skracenica.Name = "Skracenica";
            this.Skracenica.ReadOnly = true;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(1139, 556);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(147, 45);
            this.btnSacuvaj.TabIndex = 7;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmZanrovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 624);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSkracenica);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label1);
            this.Name = "frmZanrovi";
            this.Text = "frmZanrovi";
            this.Load += new System.EventHandler(this.frmZanrovi_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZanrovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSkracenica;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvZanrovi;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZanrId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Skracenica;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}