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
    public partial class frmSaleDodaj : Form
    {
        private readonly APIService _sales = new APIService("Sale");
        private readonly APIService _stores = new APIService("Store");
        private readonly APIService _igre = new APIService("Igre");
        private readonly APIService _platforme = new APIService("Platforme");
        private List<IgrePopust> _igrePopust = new List<IgrePopust>();
        private SaleInsertRequest request = new SaleInsertRequest();
        private Model.Sale entity = new Model.Sale();
        public frmSaleDodaj()
        {
            InitializeComponent();
        }

        private async void SaleDodaj_Load(object sender, EventArgs e)
        {
            await LoadStores();
            dgvIgre.AutoGenerateColumns = false;
            request.SaleDetaljiStavke = new List<SaleDetaljiStavka>();
        }

        private async Task LoadStores()
        {
            var result = await _stores.Get<List<Model.Store>>(null);
            result.Insert(0, new Model.Store());
            cmbStore.DisplayMember = "Naziv";
            cmbStore.ValueMember = "StoreId";
            cmbStore.DataSource = result;
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
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
                entity = await _sales.Insert<Model.Sale>(request);
                if (entity != null)
                {
                    MessageBox.Show("Operacija uspješno izvršena");
                }
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var search = new IgreSearchRequest();
            search.Naziv = txtIgraNaziv.Text;
            List<Model.Igre> igre = await _igre.Get<List<Model.Igre>>(search);
            foreach (var igra in igre)
            {
                var platforma = await _platforme.GetById<Model.Platforme>(igra.PlatformId);
                igra.PlatformNaziv = platforma.Naziv;
            }
            dgvIgre.DataSource = igre;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (dgvIgre.SelectedRows.Count > 0 && dgvIgre.SelectedRows.Count < 2)
            {
                if (this.ValidateChildren())
                {
                    bool igradodana = false;
                    int id = int.Parse(dgvIgre.SelectedRows[0].Cells[0].Value.ToString());
                    foreach (var x in request.SaleDetaljiStavke)
                    {
                        if (x.IgraId == id)
                        {
                            igradodana = true;
                        }
                    }
                    if (!igradodana)
                    {
                        IgrePopust item = new IgrePopust();
                        SaleDetaljiStavka stavka = new SaleDetaljiStavka();
                        stavka.IgraId = int.Parse(dgvIgre.SelectedRows[0].Cells[0].Value.ToString());
                        stavka.Popust = int.Parse(txtPopust.Text);
                        stavka.FizickaKopija = chbFizicka.Checked;
                        stavka.StoreLink = txtIgraLink.Text;
                        item.Naziv = dgvIgre.SelectedRows[0].Cells[1].Value.ToString();
                        item.Platforma = dgvIgre.SelectedRows[0].Cells[2].Value.ToString();
                        var trencijena = double.Parse(dgvIgre.SelectedRows[0].Cells[3].Value.ToString());
                        double popustdecimal = double.Parse(txtPopust.Text) / 100;
                        double popust = trencijena * popustdecimal;
                        double cijena = trencijena - popust;
                        item.Cijena = cijena;
                        stavka.Cijena = cijena;
                        _igrePopust.Add(item);
                        request.SaleDetaljiStavke.Add(stavka);
                        dgvIgrePopust.DataSource = null;
                        dgvIgrePopust.DataSource = _igrePopust;
                    }
                    if (igradodana)
                    {
                        MessageBox.Show("Igra je već dodana!");
                    }
                } 
            }
            else
            {
                MessageBox.Show("Morate odabrati jednu igru!");
            }
        }

        private void cmbStore_Validating(object sender, CancelEventArgs e)
        {
            if (cmbStore.SelectedItem == null)
            {
                errorProvider.SetError(cmbStore, Properties.Resources.Validation_RequiredField);
                e.Cancel=true;
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
            if (string.IsNullOrWhiteSpace(txtPopust.Text) || !double.TryParse(txtPopust.Text, out var result) || result<0 || result>100)
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
    public class IgrePopust
    {
        public string Naziv { get; set; }
        public double Cijena { get; set; }
        public string Platforma { get; set; }
    }
}
