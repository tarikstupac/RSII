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

namespace VGFeed.WinUI.Store
{
    public partial class frmStore : Form
    {
        private readonly APIService _service = new APIService("Store");
        private int? _id = null;
        private StoreInsertRequest request = new StoreInsertRequest();
        private Model.Store store = new Model.Store();
        public frmStore(int? storeid = null)
        {
            InitializeComponent();
            _id = storeid;
        }

        private async void frmStore_Load(object sender, EventArgs e)
        {
            await LoadStores();
            if (_id != null)
            {
                store = await _service.GetById<Model.Store>(_id);
                txtNaziv.Text = store.Naziv;
                txtOpis.Text = store.Opis;
                txtLink.Text = store.Link;
            }
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                request.Naziv = txtNaziv.Text;
                request.Opis = txtOpis.Text;
                request.Link = txtLink.Text;
                Model.Store entity = null;
                if (_id != null)
                {
                    entity = await _service.Update<Model.Store>(_id, request);
                }
                if (_id == null)
                {
                    entity = await _service.Insert<Model.Store>(request);
                }
                if (entity != null)
                {
                    MessageBox.Show("Operacija uspješno izvršena");
                }
            }

        }
        private async Task LoadStores()
        {
            var result = await _service.Get<List<Model.Store>>(null);
            dgvStores.AutoGenerateColumns = false;
            dgvStores.DataSource = result;
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

        private void txtLink_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLink.Text))
            {
                errorProvider.SetError(txtLink, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtLink, null);
            }
        }

        private void dgvStores_DoubleClick(object sender, EventArgs e)
        {
            if (dgvStores.SelectedRows[0] != null)
            {
                var id = dgvStores.SelectedRows[0].Cells[0].Value;

                frmStore frm = new frmStore(int.Parse(id.ToString()));
                frm.Show();
                this.Close();
            }
        }
    }
}
