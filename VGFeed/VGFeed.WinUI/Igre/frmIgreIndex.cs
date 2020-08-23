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
using VGFeed.WinUI.Platforme;
using VGFeed.WinUI.Zanrovi;

namespace VGFeed.WinUI.Igre
{
    public partial class frmIgreIndex : Form
    {
        private readonly APIService _platforme = new APIService("Platforme");
        private readonly APIService _zanrovi = new APIService("Zanrovi");
        private readonly APIService _service = new APIService("Igre");
        public frmIgreIndex()
        {
            InitializeComponent();
        }

        private async void frmIgreIndex_Load(object sender, EventArgs e)
        {
            await LoadPlatforme();
            await LoadZanrovi();
            var igre = await _service.Get<List<Model.Igre>>(null);
            dgvIgre.AutoGenerateColumns = false;
            dgvIgre.DataSource = igre;
        }
        private async Task LoadPlatforme()
        {
            var result = await _platforme.Get<List<Model.Platforme>>(null);
            result.Insert(0, new Model.Platforme());
            cmbPlatforme.DisplayMember = "Naziv";
            cmbPlatforme.ValueMember = "PlatformId";
            cmbPlatforme.DataSource = result;
        }
        private async Task LoadZanrovi()
        {
            var result = await _zanrovi.Get<List<Model.Zanrovi>>(null);
            result.Insert(0, new Model.Zanrovi());
            cmbZanr.DisplayMember = "Naziv";
            cmbZanr.ValueMember = "ZanrId";
            cmbZanr.DataSource = result;
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
             var search = new IgreSearchRequest();
            var platformidObj = cmbPlatforme.SelectedValue;
            if (int.TryParse(platformidObj.ToString(), out int platid))
            {
                search.PlatformaId = platid;
            }
            var zanridObj = cmbZanr.SelectedValue;
            if (int.TryParse(zanridObj.ToString(), out int zanrid))
            {
                search.ZanrId = zanrid;
            }
            search.Naziv = txtNaziv.Text;
            var result = await _service.Get<List<Model.Igre>>(search);
            dgvIgre.DataSource = result;
        }

        private void dgvIgre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvIgre_DoubleClick(object sender, EventArgs e)
        {
            if (dgvIgre.SelectedRows[0] != null)
            {
                var id = dgvIgre.SelectedRows[0].Cells[0].Value;

                frmIgre frm = new frmIgre(int.Parse(id.ToString()));
                frm.Show();
            }
        }

        private void btnPlatforme_Click(object sender, EventArgs e)
        {
            frmPlatforma frm = new frmPlatforma();
            frm.Show();
        }

        private void btnZanrovi_Click(object sender, EventArgs e)
        {
            frmZanrovi frm = new frmZanrovi();
            frm.Show();
        }
    }
}
