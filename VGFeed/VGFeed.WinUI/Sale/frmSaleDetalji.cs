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

namespace VGFeed.WinUI.Sale
{
    public partial class frmSaleDetalji : Form
    {
        private readonly int _id;
        private readonly APIService _sale = new APIService("Sale");
        private readonly APIService _saleDetalji = new APIService("SaleDetalji");
        private readonly APIService _store = new APIService("Store");
        SaleInsertRequest request = new SaleInsertRequest();
        private Model.Sale sale = new Model.Sale();
        private List<Model.SaleDetalji> saleDetalji = new List<Model.SaleDetalji>();
        public frmSaleDetalji(int saleid)
        {
            InitializeComponent();
            _id = saleid;
            request.SaleDetaljiStavke = new List<SaleDetaljiStavka>();
        }

        private async void frmSaleDetalji_Load(object sender, EventArgs e)
        {
            sale = await _sale.GetById<Model.Sale>(_id);
            await LoadSaleDetalji();
            await LoadStore();
            LoadStavke();
            cmbStore.SelectedValue = sale.SaleId;
            txtNaziv.Text = sale.Naziv;
            dtpDatumStart.Value = sale.DatumStart;
            dtpDatumEnd.Value = sale.DatumEnd;
            txtLink.Text = sale.SaleLink;    
        }

        private void LoadStavke()
        {
            foreach (var item in saleDetalji)
            {
                var stavka = new SaleDetaljiStavka();
                stavka.SaleDetaljiId = item.SaleDetaljiId;
                stavka.Cijena = item.Cijena;
                stavka.FizickaKopija = item.FizickaKopija;
                stavka.IgraId = item.IgraId;
                stavka.Popust = item.Popust;
                stavka.SaleId = item.SaleId;
                stavka.StoreLink = item.StoreLink;
                request.SaleDetaljiStavke.Add(stavka);
            }
        }

        private async Task LoadStore()
        {
            var result = await _store.Get<List<Model.Store>>(null);
            cmbStore.ValueMember = "StoreId";
            cmbStore.DisplayMember = "Naziv";
            cmbStore.DataSource = result;
        }

        private async Task LoadSaleDetalji()
        {
            SaleDetaljiSearchRequest search = new SaleDetaljiSearchRequest();
            search.SaleId = _id;
            saleDetalji = await _saleDetalji.Get<List<Model.SaleDetalji>>(search);
            dgvIgre.AutoGenerateColumns = false;
            dgvIgre.DataSource = saleDetalji;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnIzmjena_Click(object sender, EventArgs e)
        {
            if (dgvIgre.SelectedRows.Count > 0 && dgvIgre.SelectedRows.Count < 2)
            {
                if (this.ValidateChildren())
                {

                    int index = dgvIgre.SelectedRows[0].Index;                      
                    saleDetalji[index].Popust = int.Parse(txtPopust.Text);
                    saleDetalji[index].FizickaKopija = chbFizicka.Checked;
                    saleDetalji[index].StoreLink = txtIgraLink.Text;
                    var trencijena = saleDetalji[index].IgraTrenutnaCijena;
                    double popustdecimal = double.Parse(txtPopust.Text) / 100;
                    double popust = trencijena * popustdecimal;
                    double cijena = trencijena - popust;
                    saleDetalji[index].Cijena = cijena;
                    request.SaleDetaljiStavke[index].Popust = saleDetalji[index].Popust;
                    request.SaleDetaljiStavke[index].FizickaKopija = saleDetalji[index].FizickaKopija;
                    request.SaleDetaljiStavke[index].StoreLink = saleDetalji[index].StoreLink;
                    request.SaleDetaljiStavke[index].Cijena = saleDetalji[index].Cijena;
                    dgvIgre.DataSource = null;
                    dgvIgre.DataSource = saleDetalji;
                }
            }
            else
            {
                MessageBox.Show("Morate odabrati jednu igru!");
            }
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            request.Naziv = txtNaziv.Text;
            request.DatumStart = dtpDatumStart.Value;
            request.DatumEnd = dtpDatumEnd.Value;
            request.SaleLink = txtLink.Text;
            var storeidObj = cmbStore.SelectedValue.ToString();
            if (int.TryParse(storeidObj, out int storeid))
            {
                request.StoreId = storeid;
            }
            Model.Sale entity = null;
            entity = await _sale.Update<Model.Sale>(_id,request);
            if (entity != null)
            {
                MessageBox.Show("Operacija uspješno izvršena");
            }
        }

        private void cmbStore_Validating(object sender, CancelEventArgs e)
        {
            if (cmbStore.SelectedItem == null)
            {
                errorProvider.SetError(cmbStore, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cmbStore, null);
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

        private void dtpDatumStart_Validating(object sender, CancelEventArgs e)
        {
            if (dtpDatumStart.Value == null)
            {
                errorProvider.SetError(dtpDatumStart, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(dtpDatumStart, null);
            }
        }

        private void dtpDatumEnd_Validating(object sender, CancelEventArgs e)
        {
            if (dtpDatumEnd.Value == null)
            {
                errorProvider.SetError(dtpDatumEnd, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(dtpDatumEnd, null);
            }
        }

        private void txtPopust_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPopust.Text) || !double.TryParse(txtPopust.Text, out var result) || result < 0 || result > 100)
            {
                errorProvider.SetError(txtPopust, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPopust, null);
            }
        }
    }
}
