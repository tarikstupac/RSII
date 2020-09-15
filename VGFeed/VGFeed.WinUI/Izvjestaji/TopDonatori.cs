using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VGFeed.WinUI.Izvjestaji
{
    public partial class TopDonatori : Form
    {
        private readonly APIService _donacije = new APIService("Donacije");
        private readonly APIService _korisnici = new APIService("Korisnici");
        public TopDonatori()
        {
            InitializeComponent();
            finalnaLista = new List<Donatori>();
        }
        public class Donatori
        {
            public string Korisnik { get; set; }
            public double TOTAL { get; set; }
        }
        public List<Donatori> finalnaLista { get; set; }

        private async void btnUcitaj_Click(object sender, EventArgs e)
        {
            dgvDonatori.DataSource = null;
            var sviKorisnici = await _korisnici.Get<List<Model.Korisnici>>(null);
            var sveDonacije = await _donacije.Get<List<Model.Donacije>>(null);
            
            foreach (var korisnik in sviKorisnici)
            {
                double sum = 0;
                foreach (var donacija in sveDonacije)
                {
                    if (donacija.KorisnikId == korisnik.KorisnikId)
                        sum += donacija.Kolicina;
                }
                if (sum > 0)
                {
                    var temp = new Donatori() { Korisnik = korisnik.Username, TOTAL = sum };
                    finalnaLista.Add(temp);
                }
            }
            finalnaLista = finalnaLista.OrderByDescending(x => x.TOTAL).ToList();
            dgvDonatori.DataSource = finalnaLista;
        }
        Bitmap bmp;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            int height = dgvDonatori.Height;
            dgvDonatori.Height = dgvDonatori.RowCount * dgvDonatori.RowTemplate.Height * 2;
            bmp = new Bitmap(dgvDonatori.Width, dgvDonatori.Height);
            dgvDonatori.DrawToBitmap(bmp, new Rectangle(0, 0, dgvDonatori.Width, dgvDonatori.Height));
            dgvDonatori.Height = height;
            printPreviewDialog1.ShowDialog();
        }  
    }
}
