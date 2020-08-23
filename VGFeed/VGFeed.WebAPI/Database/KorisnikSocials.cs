using System;
using System.Collections.Generic;

namespace VGFeed.WebAPI.Database
{
    public partial class KorisnikSocials
    {
        public int KorisnikSocialsId { get; set; }
        public string Psnname { get; set; }
        public string PsnprofilLink { get; set; }
        public string XboxName { get; set; }
        public string XboxProfilLink { get; set; }
        public string SteamName { get; set; }
        public string SteamProfilLink { get; set; }
        public string DiscordName { get; set; }
        public string EpicStoreName { get; set; }
        public string EpicStoreProfilLink { get; set; }
        public string OriginName { get; set; }
        public string OriginProfilLink { get; set; }
        public string BattleNetName { get; set; }
        public string BattleNetProfilLink { get; set; }
        public string NintendoName { get; set; }
        public string NintendoProfilLink { get; set; }
        public int KorisnikId { get; set; }

        public Korisnici Korisnik { get; set; }
    }
}
