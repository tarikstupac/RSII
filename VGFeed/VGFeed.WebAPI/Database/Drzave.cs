using System;
using System.Collections.Generic;

namespace VGFeed.WebAPI.Database
{
    public partial class Drzave
    {
        public Drzave()
        {
            Korisnici = new HashSet<Korisnici>();
        }

        public int DrzavaId { get; set; }
        public string Naziv { get; set; }

        public ICollection<Korisnici> Korisnici { get; set; }
    }
}
