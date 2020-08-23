using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VGFeed.Model.Requests
{
   public class SaleSearchRequest
    {
        public string Naziv { get; set; }
        public DateTime DatumStart { get; set; }
        public DateTime DatumEnd { get; set; }
    }
}
