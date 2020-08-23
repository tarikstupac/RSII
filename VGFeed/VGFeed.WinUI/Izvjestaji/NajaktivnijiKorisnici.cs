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

namespace VGFeed.WinUI.Izvjestaji
{
    public partial class NajaktivnijiKorisnici : Form
    {
        private readonly APIService _apiService = new APIService("korisnici");
        private readonly APIService _drzave = new APIService("Drzave");
        private readonly APIService _uloge = new APIService("Uloge");
        private readonly APIService _korisnikIgre = new APIService("KorisnikIgre");
        public NajaktivnijiKorisnici()
        {
            InitializeComponent();
            finalnaLista = new List<Model.Korisnici>();
        }
        public List<Model.Korisnici> finalnaLista { get; set; }

        private async void NajaktivnijiKorisnici_Load(object sender, EventArgs e)
        {
            await LoadDrzave();
        }
        private async Task LoadDrzave()
        {
            var result = await _drzave.Get<List<Model.Drzave>>(null);
            result.Insert(0, new Model.Drzave());
            cmbDrzava.DisplayMember = "Naziv";
            cmbDrzava.ValueMember = "DrzavaId";
            cmbDrzava.DataSource = result;
        }
        private async Task LoadNajaktivnije(List<Model.Korisnici> list)
        {
            foreach (var item in list)
            {
                KorisnikIgreSearchRequest search1 = new KorisnikIgreSearchRequest()
                {
                    KorisnikId = item.KorisnikId,
                    Zainteresiran = true
                };
                var zainteresiran = await _korisnikIgre.Get<List<Model.KorisnikIgre>>(search1);
                item.BrojZainteresovanih = zainteresiran.Count;
                KorisnikIgreSearchRequest search2 = new KorisnikIgreSearchRequest()
                {
                    KorisnikId = item.KorisnikId,
                    Igrao = true
                };
                var igrao = await _korisnikIgre.Get<List<Model.KorisnikIgre>>(search2);
                item.BrojOdigranih = igrao.Count;
                item.UkupnaAktivnost = item.BrojOdigranih + item.BrojZainteresovanih;
                finalnaLista.Add(item);
            }
            
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            dgvKorisnici.DataSource = null;
            finalnaLista.Clear();
            var drzavaidObj = cmbDrzava.SelectedValue;
            var search = new KorisniciSearchRequest()
            {
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
                Username = txtUsername.Text
            };
            if (int.TryParse(drzavaidObj.ToString(), out int drzavaid))
            {
                search.DrzavaId = drzavaid;
            }

            var result = await _apiService.Get<List<Model.Korisnici>>(search);
            await LoadNajaktivnije(result);
            dgvKorisnici.AutoGenerateColumns = false;
            finalnaLista = finalnaLista.OrderByDescending(k => k.UkupnaAktivnost).ToList();
            dgvKorisnici.DataSource = finalnaLista;
        }
        Bitmap bmp;
        private void button1_Click(object sender, EventArgs e)
        {
            int height = dgvKorisnici.Height;
            dgvKorisnici.Height = dgvKorisnici.RowCount * dgvKorisnici.RowTemplate.Height * 2;
            bmp = new Bitmap(dgvKorisnici.Width, dgvKorisnici.Height);
            dgvKorisnici.DrawToBitmap(bmp, new Rectangle(0, 0, dgvKorisnici.Width, dgvKorisnici.Height));
            dgvKorisnici.Height = height;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
