using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VGFeed.Model.Requests
{
    public class KorisniciInsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        [MinLength(3)]
        public string Ime { get; set; }
        [Required(AllowEmptyStrings = false)]
        [MinLength(2)]
        public string Prezime { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DatumRodjenja { get; set; }
        [Required(AllowEmptyStrings = false)]
        [MaxLength(1)]
        public string Spol { get; set; }
        [EmailAddress]
        [Required(AllowEmptyStrings = false)]
        public string Email { get; set; }
        [Required(AllowEmptyStrings = false)]
        [DataType(DataType.PhoneNumber)]
        public string BrojTelefona { get; set; }
        [Required(AllowEmptyStrings = false)]
        [MinLength(4)]
        public string Username { get; set; }
        [Required(AllowEmptyStrings = false)]
        [MinLength(8)]
        public string Password { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string PasswordConfirmation { get; set; }
        [Required]
        public bool Aktivan { get; set; }
        [Required]
        public int DrzavaId { get; set; }
        [Required]
        public int UlogaId { get; set; }

    }
}
