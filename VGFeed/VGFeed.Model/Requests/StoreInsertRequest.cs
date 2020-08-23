using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VGFeed.Model.Requests
{
    public class StoreInsertRequest
    {
        [Required(AllowEmptyStrings =false)]
        public string Naziv { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Opis { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Link { get; set; }
    }
}
