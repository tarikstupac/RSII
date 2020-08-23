using System;
using System.Collections.Generic;

namespace VGFeed.WebAPI.Database
{
    public partial class Korisnici
    {
        public Korisnici()
        {
            Donacije = new HashSet<Donacije>();
            KorisnikIgre = new HashSet<KorisnikIgre>();
            KorisnikSocials = new HashSet<KorisnikSocials>();
            PorukePosiljalacNavigation = new HashSet<Poruke>();
            PorukePrimalacNavigation = new HashSet<Poruke>();
        }

        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Spol { get; set; }
        public string Email { get; set; }
        public string BrojTelefona { get; set; }
        public string Username { get; set; }
        public string PasswordSalt { get; set; }
        public string PasswordHash { get; set; }
        public DateTime DatumKreiranja { get; set; }
        public bool Aktivan { get; set; }
        public int DrzavaId { get; set; }
        public int UlogaId { get; set; }

        public Drzave Drzava { get; set; }
        public Uloge Uloga { get; set; }
        public ICollection<Donacije> Donacije { get; set; }
        public ICollection<KorisnikIgre> KorisnikIgre { get; set; }
        public ICollection<KorisnikSocials> KorisnikSocials { get; set; }
        public ICollection<Poruke> PorukePosiljalacNavigation { get; set; }
        public ICollection<Poruke> PorukePrimalacNavigation { get; set; }
    }
}
