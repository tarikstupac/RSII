using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VGFeed.Model.Requests
{
    public class SaleInsertRequest
    {
        [Required(AllowEmptyStrings =false)]
        public string Naziv { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DatumStart { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DatumEnd { get; set; }
        public string SaleLink { get; set; }
        [Required]
        public int StoreId { get; set; }
        public List<SaleDetaljiStavka> SaleDetaljiStavke { get; set; }

    }
    public class SaleDetaljiStavka
    {
        public int? SaleDetaljiId { get; set; }
        [Required]
        [Range(0,100)]
        public int Popust { get; set; }
        [Required]
        public bool FizickaKopija { get; set; }
        public string StoreLink { get; set; }
        [Required]
        [Range(0, double.MaxValue)]
        public double Cijena { get; set; }
        public int? SaleId { get; set; }
        [Required]
        public int IgraId { get; set; }
    }
}
