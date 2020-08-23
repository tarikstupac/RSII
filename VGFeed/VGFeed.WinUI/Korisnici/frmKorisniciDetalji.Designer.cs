namespace VGFeed.WinUI.Korisnici
{
    partial class frmKorisniciDetalji
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
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbSpol = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPasswordPotvrda = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.chbAktivan = new System.Windows.Forms.CheckBox();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.dtpDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbDrzava = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBrojTelefona = new System.Windows.Forms.MaskedTextBox();
            this.cmbUloga = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(13, 117);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(490, 38);
            this.txtIme.TabIndex = 0;
            this.txtIme.Validating += new System.ComponentModel.CancelEventHandler(this.txtIme_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(545, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prezime";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(545, 117);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(490, 38);
            this.txtPrezime.TabIndex = 2;
            this.txtPrezime.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrezime_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(13, 219);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(490, 38);
            this.txtUsername.TabIndex = 4;
            this.txtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsername_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "Datum rodjenja";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(539, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 32);
            this.label6.TabIndex = 11;
            this.label6.Text = "Spol";
            // 
            // cmbSpol
            // 
            this.cmbSpol.FormattingEnabled = true;
            this.cmbSpol.Location = new System.Drawing.Point(545, 429);
            this.cmbSpol.Name = "cmbSpol";
            this.cmbSpol.Size = new System.Drawing.Size(99, 39);
            this.cmbSpol.TabIndex = 12;
            this.cmbSpol.Validating += new System.ComponentModel.CancelEventHandler(this.cmbSpol_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(545, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 32);
            this.label7.TabIndex = 14;
            this.label7.Text = "Broj telefona";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(545, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 32);
            this.label8.TabIndex = 16;
            this.label8.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(545, 219);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(239, 38);
            this.txtPassword.TabIndex = 15;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(807, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 32);
            this.label9.TabIndex = 18;
            this.label9.Text = "Potvrda";
            // 
            // txtPasswordPotvrda
            // 
            this.txtPasswordPotvrda.Location = new System.Drawing.Point(807, 219);
            this.txtPasswordPotvrda.Name = "txtPasswordPotvrda";
            this.txtPasswordPotvrda.PasswordChar = '*';
            this.txtPasswordPotvrda.Size = new System.Drawing.Size(239, 38);
            this.txtPasswordPotvrda.TabIndex = 17;
            this.txtPasswordPotvrda.Validating += new System.ComponentModel.CancelEventHandler(this.txtPasswordPotvrda_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(710, 379);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 32);
            this.label10.TabIndex = 19;
            this.label10.Text = "Status";
            // 
            // chbAktivan
            // 
            this.chbAktivan.AutoSize = true;
            this.chbAktivan.Location = new System.Drawing.Point(716, 430);
            this.chbAktivan.Name = "chbAktivan";
            this.chbAktivan.Size = new System.Drawing.Size(147, 36);
            this.chbAktivan.TabIndex = 20;
            this.chbAktivan.Text = "Aktivan";
            this.chbAktivan.UseVisualStyleBackColor = true;
            // 
            // btnSnimi
            // 
            this.btnSnimi.Location = new System.Drawing.Point(872, 582);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(163, 57);
            this.btnSnimi.TabIndex = 21;
            this.btnSnimi.Text = "Sačuvaj";
            this.btnSnimi.UseVisualStyleBackColor = true;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // dtpDatumRodjenja
            // 
            this.dtpDatumRodjenja.Location = new System.Drawing.Point(13, 430);
            this.dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            this.dtpDatumRodjenja.Size = new System.Drawing.Size(490, 38);
            this.dtpDatumRodjenja.TabIndex = 22;
            this.dtpDatumRodjenja.Validating += new System.ComponentModel.CancelEventHandler(this.dtpDatumRodjenja_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // cmbDrzava
            // 
            this.cmbDrzava.FormattingEnabled = true;
            this.cmbDrzava.Location = new System.Drawing.Point(13, 521);
            this.cmbDrzava.Name = "cmbDrzava";
            this.cmbDrzava.Size = new System.Drawing.Size(490, 39);
            this.cmbDrzava.TabIndex = 23;
            this.cmbDrzava.Validating += new System.ComponentModel.CancelEventHandler(this.cmbDrzava_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 483);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 32);
            this.label11.TabIndex = 24;
            this.label11.Text = "Država";
            // 
            // txtBrojTelefona
            // 
            this.txtBrojTelefona.Location = new System.Drawing.Point(545, 324);
            this.txtBrojTelefona.Mask = "(999) 000-000";
            this.txtBrojTelefona.Name = "txtBrojTelefona";
            this.txtBrojTelefona.Size = new System.Drawing.Size(484, 38);
            this.txtBrojTelefona.TabIndex = 25;
            this.txtBrojTelefona.Validating += new System.ComponentModel.CancelEventHandler(this.txtBrojTelefona_Validating_1);
            // 
            // cmbUloga
            // 
            this.cmbUloga.FormattingEnabled = true;
            this.cmbUloga.Location = new System.Drawing.Point(545, 521);
            this.cmbUloga.Name = "cmbUloga";
            this.cmbUloga.Size = new System.Drawing.Size(484, 39);
            this.cmbUloga.TabIndex = 26;
            this.cmbUloga.Validating += new System.ComponentModel.CancelEventHandler(this.cmbUloga_Validating);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(545, 483);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 32);
            this.label12.TabIndex = 27;
            this.label12.Text = "Uloga";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(13, 324);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(490, 38);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // frmKorisniciDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 698);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbUloga);
            this.Controls.Add(this.txtBrojTelefona);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbDrzava);
            this.Controls.Add(this.dtpDatumRodjenja);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.chbAktivan);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPasswordPotvrda);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbSpol);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIme);
            this.Name = "frmKorisniciDetalji";
            this.Text = "frmKorisniciDetalji";
            this.Load += new System.EventHandler(this.frmKorisniciDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbSpol;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPasswordPotvrda;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chbAktivan;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.DateTimePicker dtpDatumRodjenja;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbDrzava;
        private System.Windows.Forms.MaskedTextBox txtBrojTelefona;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbUloga;
        private System.Windows.Forms.TextBox txtEmail;
    }
}