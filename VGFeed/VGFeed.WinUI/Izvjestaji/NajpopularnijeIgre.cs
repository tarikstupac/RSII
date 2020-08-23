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
    public partial class NajpopularnijeIgre : Form
    {
        private readonly APIService _platforme = new APIService("Platforme");
        private readonly APIService _zanrovi = new APIService("Zanrovi");
        private readonly APIService _service = new APIService("Igre");
        private readonly APIService _korisnikIgre = new APIService("KorisnikIgre");
        public NajpopularnijeIgre()
        {
            InitializeComponent();
            finalnaLista = new List<Model.Igre>();
        }
        public List<Model.Igre> finalnaLista { get; set; }
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
        private async Task LoadNajpopularnije(List<Model.Igre> list)
        {
            foreach (var item in list)
            {
                KorisnikIgreSearchRequest search1 = new KorisnikIgreSearchRequest()
                {
                    IgraId = item.IgraId,
                    Zainteresiran = true
                };
                var zainteresiran = await _korisnikIgre.Get<List<Model.KorisnikIgre>>(search1);
                item.BrojZainteresovanih = zainteresiran.Count;
                KorisnikIgreSearchRequest search2 = new KorisnikIgreSearchRequest()
                {
                    IgraId = item.IgraId,
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
            dgvIgre.DataSource = null;
            finalnaLista.Clear();
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
            await LoadNajpopularnije(result);
            finalnaLista = finalnaLista.OrderByDescending(k => k.UkupnaAktivnost).ToList();
            dgvIgre.AutoGenerateColumns = false;
            dgvIgre.DataSource = finalnaLista;
        }
        Bitmap bmp;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private async void NajpopularnijeIgre_Load(object sender, EventArgs e)
        {
            await LoadPlatforme();
            await LoadZanrovi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int height = dgvIgre.Height;
            dgvIgre.Height = dgvIgre.RowCount * dgvIgre.RowTemplate.Height * 2;
            bmp = new Bitmap(dgvIgre.Width, dgvIgre.Height);
            dgvIgre.DrawToBitmap(bmp, new Rectangle(0, 0, dgvIgre.Width, dgvIgre.Height));
            dgvIgre.Height = height;
            printPreviewDialog1.ShowDialog();
        }
    }
}
