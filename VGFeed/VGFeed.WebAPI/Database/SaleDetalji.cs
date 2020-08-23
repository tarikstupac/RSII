using System;
using System.Collections.Generic;

namespace VGFeed.WebAPI.Database
{
    public partial class SaleDetalji
    {
        public int SaleDetaljiId { get; set; }
        public int Popust { get; set; }
        public bool FizickaKopija { get; set; }
        public string StoreLink { get; set; }
        public double Cijena { get; set; }
        public int SaleId { get; set; }
        public int IgraId { get; set; }

        public Igre Igra { get; set; }
        public Sale Sale { get; set; }
    }
}
