using System;
using System.Collections.Generic;

namespace VGFeed.WebAPI.Database
{
    public partial class Poruke
    {
        public int PorukaId { get; set; }
        public string Tekst { get; set; }
        public DateTime DatumKreiranja { get; set; }
        public bool StatusPoruke { get; set; }
        public int Posiljalac { get; set; }
        public int Primalac { get; set; }

        public Korisnici PosiljalacNavigation { get; set; }
        public Korisnici PrimalacNavigation { get; set; }
    }
}
