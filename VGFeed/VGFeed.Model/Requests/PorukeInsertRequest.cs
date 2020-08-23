using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VGFeed.Model.Requests
{
   public class PorukeInsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        public string Tekst { get; set; }
        [Required(AllowEmptyStrings = false)]
        [DataType(DataType.Date)]
        public DateTime DatumKreiranja { get; set; }
        [Required]
        public bool StatusPoruke { get; set; }
        [Required(AllowEmptyStrings = false)]
        public int Posiljalac { get; set; }
        [Required(AllowEmptyStrings = false)]
        public int Primalac { get; set; }
    }
}
