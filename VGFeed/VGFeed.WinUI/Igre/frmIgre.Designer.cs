namespace VGFeed.WinUI.Igre
{
    partial class frmIgre
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
            this.txtOrigCijena = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTrenCijena = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDeveloper = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIzdavac = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chbMultiplayer = new System.Windows.Forms.CheckBox();
            this.txtSlika = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSlika = new System.Windows.Forms.Button();
            this.pbSlika = new System.Windows.Forms.PictureBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.cmbPlatforma = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbZanr = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpDatumIzlaska = new System.Windows.Forms.DateTimePicker();
            this.txtMetacritic = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(340, 33);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(516, 38);
            this.txtNaziv.TabIndex = 1;
            this.txtNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.txtNaziv_Validating);
            // 
            // txtOrigCijena
            // 
            this.txtOrigCijena.Location = new System.Drawing.Point(340, 97);
            this.txtOrigCijena.Name = "txtOrigCijena";
            this.txtOrigCijena.Size = new System.Drawing.Size(516, 38);
            this.txtOrigCijena.TabIndex = 3;
            this.txtOrigCijena.Validating += new System.ComponentModel.CancelEventHandler(this.txtOrigCijena_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Originalna Cijena";
            // 
            // txtTrenCijena
            // 
            this.txtTrenCijena.Location = new System.Drawing.Point(340, 173);
            this.txtTrenCijena.Name = "txtTrenCijena";
            this.txtTrenCijena.Size = new System.Drawing.Size(516, 38);
            this.txtTrenCijena.TabIndex = 5;
            this.txtTrenCijena.Validating += new System.ComponentModel.CancelEventHandler(this.txtTrenCijena_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Trenutna Cijena";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(340, 245);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(516, 291);
            this.txtOpis.TabIndex = 7;
            this.txtOpis.Validating += new System.ComponentModel.CancelEventHandler(this.txtOpis_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Opis";
            // 
            // txtDeveloper
            // 
            this.txtDeveloper.Location = new System.Drawing.Point(340, 575);
            this.txtDeveloper.Name = "txtDeveloper";
            this.txtDeveloper.Size = new System.Drawing.Size(516, 38);
            this.txtDeveloper.TabIndex = 9;
            this.txtDeveloper.Validating += new System.ComponentModel.CancelEventHandler(this.txtDeveloper_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 581);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "Developer";
            // 
            // txtIzdavac
            // 
            this.txtIzdavac.Location = new System.Drawing.Point(340, 645);
            this.txtIzdavac.Name = "txtIzdavac";
            this.txtIzdavac.Size = new System.Drawing.Size(516, 38);
            this.txtIzdavac.TabIndex = 11;
            this.txtIzdavac.Validating += new System.ComponentModel.CancelEventHandler(this.txtIzdavac_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 651);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 32);
            this.label6.TabIndex = 10;
            this.label6.Text = "Izdavač";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 717);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 32);
            this.label7.TabIndex = 12;
            this.label7.Text = "Multiplayer";
            // 
            // chbMultiplayer
            // 
            this.chbMultiplayer.AutoSize = true;
            this.chbMultiplayer.Location = new System.Drawing.Point(340, 712);
            this.chbMultiplayer.Name = "chbMultiplayer";
            this.chbMultiplayer.Size = new System.Drawing.Size(89, 36);
            this.chbMultiplayer.TabIndex = 13;
            this.chbMultiplayer.Text = "Da";
            this.chbMultiplayer.UseVisualStyleBackColor = true;
            // 
            // txtSlika
            // 
            this.txtSlika.Location = new System.Drawing.Point(340, 768);
            this.txtSlika.Name = "txtSlika";
            this.txtSlika.Size = new System.Drawing.Size(516, 38);
            this.txtSlika.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 774);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 32);
            this.label8.TabIndex = 14;
            this.label8.Text = "Slika";
            // 
            // btnSlika
            // 
            this.btnSlika.Location = new System.Drawing.Point(880, 751);
            this.btnSlika.Name = "btnSlika";
            this.btnSlika.Size = new System.Drawing.Size(135, 55);
            this.btnSlika.TabIndex = 16;
            this.btnSlika.Text = "Dodaj";
            this.btnSlika.UseVisualStyleBackColor = true;
            this.btnSlika.Click += new System.EventHandler(this.btnSlika_Click);
            // 
            // pbSlika
            // 
            this.pbSlika.Location = new System.Drawing.Point(952, 33);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(427, 422);
            this.pbSlika.TabIndex = 17;
            this.pbSlika.TabStop = false;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(1225, 1076);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(154, 64);
            this.btnSacuvaj.TabIndex = 18;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // cmbPlatforma
            // 
            this.cmbPlatforma.FormattingEnabled = true;
            this.cmbPlatforma.Location = new System.Drawing.Point(340, 843);
            this.cmbPlatforma.Name = "cmbPlatforma";
            this.cmbPlatforma.Size = new System.Drawing.Size(516, 39);
            this.cmbPlatforma.TabIndex = 19;
            this.cmbPlatforma.SelectedIndexChanged += new System.EventHandler(this.cmbPlatforma_SelectedIndexChanged);
            this.cmbPlatforma.Validating += new System.ComponentModel.CancelEventHandler(this.cmbPlatforma_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 850);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 32);
            this.label9.TabIndex = 20;
            this.label9.Text = "Platforma";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 918);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 32);
            this.label10.TabIndex = 22;
            this.label10.Text = "Žanr";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // cmbZanr
            // 
            this.cmbZanr.FormattingEnabled = true;
            this.cmbZanr.Location = new System.Drawing.Point(340, 911);
            this.cmbZanr.Name = "cmbZanr";
            this.cmbZanr.Size = new System.Drawing.Size(516, 39);
            this.cmbZanr.TabIndex = 23;
            this.cmbZanr.Validating += new System.ComponentModel.CancelEventHandler(this.cmbZanr_Validating);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 990);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(193, 32);
            this.label11.TabIndex = 24;
            this.label11.Text = "Datum Izlaska";
            // 
            // dtpDatumIzlaska
            // 
            this.dtpDatumIzlaska.Location = new System.Drawing.Point(340, 983);
            this.dtpDatumIzlaska.Name = "dtpDatumIzlaska";
            this.dtpDatumIzlaska.Size = new System.Drawing.Size(516, 38);
            this.dtpDatumIzlaska.TabIndex = 25;
            this.dtpDatumIzlaska.Validating += new System.ComponentModel.CancelEventHandler(this.dtpDatumIzlaska_Validating);
            // 
            // txtMetacritic
            // 
            this.txtMetacritic.Location = new System.Drawing.Point(340, 1054);
            this.txtMetacritic.Name = "txtMetacritic";
            this.txtMetacritic.Size = new System.Drawing.Size(516, 38);
            this.txtMetacritic.TabIndex = 27;
            this.txtMetacritic.Validating += new System.ComponentModel.CancelEventHandler(this.txtMetacritic_Validating);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(39, 1060);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(235, 32);
            this.label12.TabIndex = 26;
            this.label12.Text = "Metacritic Ocjena";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmIgre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 1167);
            this.Controls.Add(this.txtMetacritic);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtpDatumIzlaska);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbZanr);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbPlatforma);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.pbSlika);
            this.Controls.Add(this.btnSlika);
            this.Controls.Add(this.txtSlika);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chbMultiplayer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtIzdavac);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDeveloper);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTrenCijena);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOrigCijena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label1);
            this.Name = "frmIgre";
            this.Text = "frmIgre";
            this.Load += new System.EventHandler(this.frmIgre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtOrigCijena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTrenCijena;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDeveloper;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIzdavac;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chbMultiplayer;
        private System.Windows.Forms.TextBox txtSlika;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSlika;
        private System.Windows.Forms.PictureBox pbSlika;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.ComboBox cmbPlatforma;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbZanr;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpDatumIzlaska;
        private System.Windows.Forms.TextBox txtMetacritic;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}