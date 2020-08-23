using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VGFeed.Model
{
   public class Poruke
    {
        public int PorukaId { get; set; }
        public string Tekst { get; set; }
        public DateTime DatumKreiranja { get; set; }
        public bool StatusPoruke { get; set; }
        public int Posiljalac { get; set; }
        public int Primalac { get; set; }
    }
}
