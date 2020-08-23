using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VGFeed.Model
{
    public class KorisnikIgre
    {
        public int KorisnikIgreId { get; set; }
        public bool? Igrao { get; set; }
        public int? Ocjena { get; set; }
        public bool? Zainteresiran { get; set; }
        public string Recenzija { get; set; }
        public bool? PosjedujeIgru { get; set; }
        public int KorisnikId { get; set; }
        public int IgraId { get; set; }
        public string KorisnikUsername { get; set; }
        public string IgraNaziv { get; set; }
        public byte[] IgraSlikaThumb { get; set; }
        public string IgraDeveloper { get; set; }
        public string IgraIzdavac { get; set; }
    }
}
