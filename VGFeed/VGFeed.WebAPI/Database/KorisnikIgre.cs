using System;
using System.Collections.Generic;

namespace VGFeed.WebAPI.Database
{
    public partial class KorisnikIgre
    {
        public int KorisnikIgreId { get; set; }
        public bool? Igrao { get; set; }
        public int? Ocjena { get; set; }
        public bool? Zainteresiran { get; set; }
        public string Recenzija { get; set; }
        public bool? PosjedujeIgru { get; set; }
        public int KorisnikId { get; set; }
        public int IgraId { get; set; }

        public Igre Igra { get; set; }
        public Korisnici Korisnik { get; set; }
    }
}
