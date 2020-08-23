using System;
using System.Collections.Generic;

namespace VGFeed.WebAPI.Database
{
    public partial class Zanrovi
    {
        public Zanrovi()
        {
            Igre = new HashSet<Igre>();
        }

        public int ZanrId { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public string Skracenica { get; set; }

        public ICollection<Igre> Igre { get; set; }
    }
}
