using System;
using System.Collections.Generic;
using System.Text;

namespace VGFeed.MobileApp.Models
{
    public enum MenuItemType
    {
        Igre,
        Zainteresiran,
        Odigrao,
        KorisnikSocials,
        Sale,
        Korisnici,
        Doniraj
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
