using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VGFeed.Model.Requests
{
    public class IgreInsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        public string Naziv { get; set; }
        [Required(AllowEmptyStrings = false)]  
        [Range(0,double.MaxValue)]
        public double OriginalnaCijena { get; set; }
        [Required(AllowEmptyStrings = false)]
        [Range(0, double.MaxValue)]
        public double TrenutnaCijena { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Opis { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Developer { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Izdavac { get; set; }
        [Required]
        public bool Multiplayer { get; set; }
        [Required]
        public byte[] Slika { get; set; }
        [Required]
        public byte[] SlikaThumb { get; set; }
        [Required]
        public int ZanrId { get; set; }
        [Required]
        public int PlatformId { get; set; }
        [Required(AllowEmptyStrings = false)]
        [DataType(DataType.Date)]
        public DateTime DatumIzlaska { get; set; }
        [Required(AllowEmptyStrings = false)]
        [Range(0,100)]
        public int MetacriticOcjena { get; set; }

    }
}
