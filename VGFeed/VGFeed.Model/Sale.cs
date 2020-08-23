using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VGFeed.Model
{
   public class Sale
    {
        public int SaleId { get; set; }
        public string Naziv { get; set; }
        public DateTime DatumStart { get; set; }
        public DateTime DatumEnd { get; set; }
        public string SaleLink { get; set; }
        public int StoreId { get; set; }
        public string StoreNaziv { get; set; }
    }
}
