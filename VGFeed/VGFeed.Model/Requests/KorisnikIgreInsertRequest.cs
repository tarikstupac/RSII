using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VGFeed.Model.Requests
{
    public class KorisnikIgreInsertRequest
    {

        public bool? Igrao { get; set; }
        [Range(0,5)]
        public int? Ocjena { get; set; }
        public bool? Zainteresiran { get; set; }
        public string Recenzija { get; set; }
        public bool? PosjedujeIgru { get; set; }
        [Required]
        public int KorisnikId { get; set; }
        [Required]
        public int IgraId { get; set; }
    }
}
