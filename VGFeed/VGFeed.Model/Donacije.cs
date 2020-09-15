using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VGFeed.Model
{
   public class Donacije
    {
        public int DonacijaId { get; set; }
        public string Token { get; set; }
        public double Kolicina { get; set; }
        public DateTime DatumUplate { get; set; }
        public int KorisnikId { get; set; }
        public Model.Korisnici Korisnik { get; set; }
    }
}
