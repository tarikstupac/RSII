using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VGFeed.Model
{
   public partial class Igre
    {

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
        public DateTime DatumIzlaska { get; set; }
        public int MetacriticOcjena { get; set; }
        public int PlatformId { get; set; }
        public int ZanrId { get; set; }
        public string PlatformNaziv { get; set; }
        public string ZanrNaziv { get; set; }
        public int? BrojOdigranih { get; set; }
        public int? BrojZainteresovanih { get; set; }
        public int? UkupnaAktivnost { get; set; }
    }
}
