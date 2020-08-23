using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VGFeed.Model.Requests
{
    public class KorisniciSearchRequest
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Username { get; set; }
        public int DrzavaId { get; set; }
        public int UlogaId { get; set; }
    }
}
