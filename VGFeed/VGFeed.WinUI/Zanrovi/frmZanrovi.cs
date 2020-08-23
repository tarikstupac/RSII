using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VGFeed.Model.Requests;

namespace VGFeed.WinUI.Zanrovi
{
    public partial class frmZanrovi : Form
    {
        private readonly APIService _service = new APIService("Zanrovi");
        private int? _id = null;
        private ZanroviInsertRequest request = new ZanroviInsertRequest();
        private Model.Zanrovi zanr = new Model.Zanrovi();
        public frmZanrovi(int? zanrid=null)
        {
            InitializeComponent();
            _id = zanrid;
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                request.Naziv = txtNaziv.Text;
                request.Opis = txtOpis.Text;
                request.Skracenica = txtSkracenica.Text;
                Model.Zanrovi entity = null;
                if (_id != null)
                {
                    entity = await _service.Update<Model.Zanrovi>(_id, request);
                }
                if (_id == null)
                {
                    entity = await _service.Insert<Model.Zanrovi>(request);
                }
                if (entity != null)
                {
                    MessageBox.Show("Operacija uspješno izvršena");
                }
            }
        }

        private async void frmZanrovi_Load(object sender, EventArgs e)
        {
            await LoadZanrovi();
            if (_id != null)
            {
                zanr = await _service.GetById<Model.Zanrovi>(_id);
                txtNaziv.Text = zanr.Naziv;
                txtOpis.Text = zanr.Opis;
                txtSkracenica.Text = zanr.Skracenica;
            }
        }

        private async Task LoadZanrovi()
        {
            var result = await _service.Get<List<Model.Zanrovi>>(null);
            dgvZanrovi.AutoGenerateColumns = false;
            dgvZanrovi.DataSource = result;
        }

        private void dgvZanrovi_DoubleClick(object sender, EventArgs e)
        {
            if (dgvZanrovi.SelectedRows[0] != null)
            {
                var id = dgvZanrovi.SelectedRows[0].Cells[0].Value;

                frmZanrovi frm = new frmZanrovi(int.Parse(id.ToString()));
                frm.Show();
                this.Close();
            }
        }

        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                errorProvider.SetError(txtNaziv, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtNaziv, null);
            }
        }

        private void txtOpis_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtOpis.Text))
            {
                errorProvider.SetError(txtOpis, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtOpis, null);
            }
        }

        private void txtSkracenica_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSkracenica.Text))
            {
                errorProvider.SetError(txtSkracenica, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtSkracenica, null);
            }
        }
    }
}
