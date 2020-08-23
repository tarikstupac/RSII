using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VGFeed.Model.Requests
{
   public class PlatformeInsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        [MinLength(5)]
        public string Naziv { get; set; }
        [Required(AllowEmptyStrings = false)]
        [MinLength(3)]
        public string Skracenica { get; set; }
        [Required]
        public byte[] Logo { get; set; }
    }
}
