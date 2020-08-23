using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VGFeed.Model.Requests
{
    public class DonacijeInsertRequest
    {
        public string Token { get; set; }
        public double Kolicina { get; set; }
        public DateTime DatumUplate { get; set; }
        public int KorisnikId { get; set; }
    }
}
