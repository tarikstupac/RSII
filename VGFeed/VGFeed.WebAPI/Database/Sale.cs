using System;
using System.Collections.Generic;

namespace VGFeed.WebAPI.Database
{
    public partial class Sale
    {
        public Sale()
        {
            SaleDetalji = new HashSet<SaleDetalji>();
        }

        public int SaleId { get; set; }
        public string Naziv { get; set; }
        public DateTime DatumStart { get; set; }
        public DateTime DatumEnd { get; set; }
        public string SaleLink { get; set; }
        public int StoreId { get; set; }

        public Store Store { get; set; }
        public ICollection<SaleDetalji> SaleDetalji { get; set; }
    }
}
