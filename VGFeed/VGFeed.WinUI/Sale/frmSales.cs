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
    public partial class frmSales : Form
    {
        private readonly APIService _service = new APIService("Sale");
        public frmSales()
        {
            InitializeComponent();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var search = new SaleSearchRequest();
            search.Naziv = txtNaziv.Text;
            search.DatumStart = dtpDatumOd.Value;
            search.DatumEnd = dtpDatumDo.Value;

            var result = await _service.Get<List<Model.Sale>>(search);
            dgvSales.DataSource = result;
        }

        private async void frmSales_Load(object sender, EventArgs e)
        {
            var sales = await _service.Get<List<Model.Sale>>(null);
            dgvSales.AutoGenerateColumns = false;
            dgvSales.DataSource = sales;
        }

        private void dgvSales_DoubleClick(object sender, EventArgs e)
        {
            if (dgvSales.SelectedRows[0] != null)
            {
                var saleidObj = dgvSales.SelectedRows[0].Cells[0].Value.ToString();
                if (int.TryParse(saleidObj, out var saleid))
                {
                    frmSaleDetalji frm = new frmSaleDetalji(saleid);
                    frm.Show();
                }
            }
        }
    }
}
