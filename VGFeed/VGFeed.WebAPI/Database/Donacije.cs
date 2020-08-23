using System;
using System.Collections.Generic;

namespace VGFeed.WebAPI.Database
{
    public partial class Donacije
    {
        public int DonacijaId { get; set; }
        public string Token { get; set; }
        public double Kolicina { get; set; }
        public DateTime DatumUplate { get; set; }
        public int? KorisnikId { get; set; }

        public Korisnici Korisnik { get; set; }
    }
}
