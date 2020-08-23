using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VGFeed.Model
{
    public partial class Korisnici
    {

        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Spol { get; set; }
        public string Email { get; set; }
        public string BrojTelefona { get; set; }
        public string Username { get; set; }
        public bool Aktivan { get; set; }
        public int DrzavaId { get; set; }
        public int UlogaId { get; set; }
        public Uloge Uloga { get; set; }
        public int? BrojOdigranih { get; set; }
        public int? BrojZainteresovanih { get; set; }
        public int? UkupnaAktivnost { get; set; }
    }
}
