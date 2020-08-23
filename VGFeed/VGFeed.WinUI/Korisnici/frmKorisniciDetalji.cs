using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VGFeed.WinUI.Korisnici
{
    public partial class frmKorisniciDetalji : Form
    {
        private int? _id = null;
        private readonly APIService _service = new APIService("Korisnici");
        private readonly APIService _drzave = new APIService("Drzave");
        private readonly APIService _uloge = new APIService("Uloge");
        public frmKorisniciDetalji(int? korisnikId = null)
        {
            InitializeComponent();
            _id = korisnikId;         
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var drzavaidObj = cmbDrzava.SelectedValue;
                var ulogaidObj = cmbUloga.SelectedValue;
                var request = new Model.Requests.KorisniciInsertRequest()
                {
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    Username = txtUsername.Text,
                    Password = txtPassword.Text,
                    PasswordConfirmation = txtPasswordPotvrda.Text,
                    DatumRodjenja = dtpDatumRodjenja.Value,
                    Email = txtEmail.Text,
                    BrojTelefona = txtBrojTelefona.Text,
                    Spol = cmbSpol.SelectedItem.ToString(),
                    Aktivan = chbAktivan.Checked  
                };

                if (int.TryParse(drzavaidObj.ToString(), out int drzavaid))
                {
                    request.DrzavaId = drzavaid;
                }
                if (int.TryParse(ulogaidObj.ToString(), out int ulogaid))
                {
                    request.UlogaId = ulogaid;
                }

                Model.Korisnici entity = null;
                if (_id.HasValue)
                {
                   entity = await _service.Update<Model.Korisnici>(_id, request);
                }
                else
                {
                   entity = await _service.Insert<Model.Korisnici>(request);
                }

                if (entity != null)
                {
                    MessageBox.Show("Operacija uspješna");
                }
                
            }
           
        }

        private async void frmKorisniciDetalji_Load(object sender, EventArgs e)
        {
            await LoadDrzave();
            await LoadUloge();
            if (_id.HasValue)
            {
                var korisnik = await _service.GetById<Model.Korisnici>(_id);
                txtIme.Text = korisnik.Ime;
                txtPrezime.Text = korisnik.Prezime;
                txtUsername.Text = korisnik.Username;
                txtEmail.Text = korisnik.Email;
                txtBrojTelefona.Text = korisnik.BrojTelefona;
                dtpDatumRodjenja.Value = korisnik.DatumRodjenja;
                cmbSpol.Items.AddRange(new object[] { "M", "Z" });
                cmbSpol.SelectedItem = korisnik.Spol;
                chbAktivan.Checked = korisnik.Aktivan;
                cmbDrzava.SelectedValue = korisnik.DrzavaId;
                cmbUloga.SelectedValue = korisnik.UlogaId;
                txtPassword.Text = "********";
                txtPasswordPotvrda.Text = "********";
            }
            else
            {
                cmbSpol.Items.AddRange(new object[] { "M", "Z" });
                chbAktivan.Checked = true;
            }
        }
        private async Task LoadDrzave()
        {
            var result = await _drzave.Get<List<Model.Drzave>>(null);
            result.Insert(0, new Model.Drzave());
            cmbDrzava.DisplayMember = "Naziv";
            cmbDrzava.ValueMember = "DrzavaId";
            cmbDrzava.DataSource = result;
        }
        private async Task LoadUloge()
        {
            var result = await _uloge.Get<List<Model.Uloge>>(null);
            result.Insert(0, new Model.Uloge());
            cmbUloga.DisplayMember = "Naziv";
            cmbUloga.ValueMember = "UlogaId";
            cmbUloga.DataSource = result;
        }

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIme.Text) || txtIme.Text.Length < 3)
            {
                errorProvider.SetError(txtIme, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtIme, null);
            }
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || txtUsername.Text.Length < 4)
            {
                errorProvider.SetError(txtUsername, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtUsername, null);
            }
            
        }

        private void txtPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrezime.Text) || txtPrezime.Text.Length < 2)
            {
                errorProvider.SetError(txtPrezime, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPrezime, null);
            } 
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
            {
                errorProvider.SetError(txtEmail, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtEmail, null);
            }
            
        }

        private void dtpDatumRodjenja_Validating(object sender, CancelEventArgs e)
        {
          
            if (string.IsNullOrWhiteSpace(dtpDatumRodjenja.Text))
            {
                errorProvider.SetError(dtpDatumRodjenja, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(dtpDatumRodjenja, null);
            }
            
        }

        private void cmbSpol_Validating(object sender, CancelEventArgs e)
        {
            if (cmbSpol.SelectedItem == null)
            {
                errorProvider.SetError(cmbSpol, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cmbSpol, null);
            }
            
        }

        private void cmbDrzava_Validating(object sender, CancelEventArgs e)
        {
            if (cmbDrzava.SelectedItem == null)
            {
                errorProvider.SetError(cmbDrzava, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cmbDrzava, null);
            }

        }

        private void txtBrojTelefona_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBrojTelefona.Text))
            {
                errorProvider.SetError(txtBrojTelefona, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtBrojTelefona, null);
            }

        }

        private void cmbUloga_Validating(object sender, CancelEventArgs e)
        {
            if (cmbUloga.SelectedItem == null)
            {
                errorProvider.SetError(cmbUloga, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cmbUloga, null);
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text) || txtPassword.Text.Length < 8)
            {
                errorProvider.SetError(txtPassword, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPassword, null);
            }
        }

        private void txtPasswordPotvrda_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPasswordPotvrda.Text) || !txtPasswordPotvrda.Text.Contains(txtPassword.Text))
            {
                errorProvider.SetError(txtPasswordPotvrda, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPasswordPotvrda, null);
            }
        }
    }
}
