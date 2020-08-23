using System;
using System.Collections.Generic;

namespace VGFeed.WebAPI.Database
{
    public partial class Igre
    {
        public Igre()
        {
            KorisnikIgre = new HashSet<KorisnikIgre>();
            SaleDetalji = new HashSet<SaleDetalji>();
        }

        public int IgraId { get; set; }
        public string Naziv { get; set; }
        public double OriginalnaCijena { get; set; }
        public double TrenutnaCijena { get; set; }
        public string Opis { get; set; }
        public string Developer { get; set; }
        public string Izdavac { get; set; }
        public bool Multiplayer { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        public int PlatformId { get; set; }
        public int ZanrId { get; set; }
        public DateTime DatumIzlaska { get; set; }
        public int MetacriticOcjena { get; set; }

        public Platforme Platform { get; set; }
        public Zanrovi Zanr { get; set; }
        public ICollection<KorisnikIgre> KorisnikIgre { get; set; }
        public ICollection<SaleDetalji> SaleDetalji { get; set; }
    }
}
