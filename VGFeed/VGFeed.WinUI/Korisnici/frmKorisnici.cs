using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flurl;
using Flurl.Http;
using VGFeed.Model.Requests;

namespace VGFeed.WinUI.Korisnici
{
    public partial class frmKorisnici : Form
    {
        private readonly APIService _apiService = new APIService("korisnici");
        private readonly APIService _drzave = new APIService("Drzave");
        private readonly APIService _uloge = new APIService("Uloge");
        public frmKorisnici()
        {
            InitializeComponent();
        }

        private async void frmKorisnici_Load(object sender, EventArgs e)
        {
            await LoadDrzave();
            await LoadUloge();
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            var drzavaidObj = cmbDrzava.SelectedValue;
            var ulogaidObj = cmbUloga.SelectedValue;
            var search = new KorisniciSearchRequest()
            {
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
                Username = txtUsername.Text,
            };
            if (int.TryParse(drzavaidObj.ToString(), out int drzavaid))
            {
                search.DrzavaId = drzavaid;
            }
            if (int.TryParse(ulogaidObj.ToString(), out int ulogaid))
            {
                search.UlogaId = ulogaid;
            }

            var result = await _apiService.Get<List<Model.Korisnici>>(search);

            dgvKorisnici.AutoGenerateColumns = false;
            dgvKorisnici.DataSource = result;   
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

        private void dgvKorisnici_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgvKorisnici.SelectedRows[0] != null)
            {
                var id = dgvKorisnici.SelectedRows[0].Cells[0].Value;

                frmKorisniciDetalji frm = new frmKorisniciDetalji(int.Parse(id.ToString()));
                frm.Show();
            }
        }
    }
}
