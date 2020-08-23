using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VGFeed.Model.Requests
{
   public class KorisnikIgreSearchRequest
    {
        public int? IgraId { get; set; }
        public int? KorisnikId { get; set; }
        public bool? Igrao { get; set; }
        public bool? Zainteresiran { get; set; }
    }
}
