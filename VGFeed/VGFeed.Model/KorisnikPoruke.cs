using System;
using System.Collections.Generic;
using System.Text;

namespace VGFeed.Model
{
    public class KorisnikPoruke
    {
        public string Username { get; set; }
        public Model.Poruke Poruka { get; set; }
        public bool Status { get; set; }
        public Model.Korisnici Korisnik { get; set; }
    }
}
