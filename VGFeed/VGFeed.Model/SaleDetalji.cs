using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VGFeed.Model
{
    public class SaleDetalji
    {
        public int SaleDetaljiId { get; set; }
        public int Popust { get; set; }
        public bool FizickaKopija { get; set; }
        public string StoreLink { get; set; }
        public double Cijena { get; set; }
        public int SaleId { get; set; }
        public int IgraId { get; set; }
        public string IgraNaziv { get; set; }
        public string IgraPlatformNaziv { get; set; }
        public double IgraTrenutnaCijena { get; set; }
        public byte[] IgraSlikaThumb { get; set; }
    }
}
