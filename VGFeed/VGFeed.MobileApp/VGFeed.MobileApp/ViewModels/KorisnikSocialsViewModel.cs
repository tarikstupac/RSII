using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using VGFeed.Model.Requests;
using Xamarin.Forms;

namespace VGFeed.MobileApp.ViewModels
{
    public class KorisnikSocialsViewModel:BaseViewModel
    {
        private readonly APIService _korisnikSocialsService = new APIService("KorisnikSocials");
        private Model.KorisnikSocials _trenutniKorisnik = null;
        public KorisnikSocialsViewModel()
        {
            InitCommand = new Command(async () => await Init());
            SacuvajCommand = new Command(async () => await Sacuvaj());
        }
        public ObservableCollection<Model.KorisnikSocials> KorisnikIgreList { get; set; } = new ObservableCollection<Model.KorisnikSocials>();
        public ICommand InitCommand { get; private set; }
        public ICommand SacuvajCommand { get; set; }
        public Model.KorisnikSocials TrenutniKorisnik
        {
            get { return _trenutniKorisnik; }
            set { SetProperty(ref _trenutniKorisnik, value); }
        }
        async Task Init()
        {
            IsBusy = true;
            KorisnikSocialsSearchRequest search = new KorisnikSocialsSearchRequest()
            {
                KorisnikId = APIService.KorisnikId
            };
            var korisniksocials = await _korisnikSocialsService.Get<List<Model.KorisnikSocials>>(search);
            if (korisniksocials.Count != 0)
            {
                TrenutniKorisnik = korisniksocials[0];
            }
            else
            {
                KorisnikSocialsInsertRequest request = new KorisnikSocialsInsertRequest()
                {
                   BattleNetName="",
                   BattleNetProfilLink="",
                   DiscordName = "",
                   EpicStoreName = "",
                   EpicStoreProfilLink = "",
                   KorisnikId=APIService.KorisnikId,
                   NintendoName = "",
                   NintendoProfilLink = "",
                   OriginName = "",
                   OriginProfilLink = "",
                   Psnname = "",
                   PsnprofilLink = "",
                   SteamName = "",
                   SteamProfilLink = "",
                   XboxName = "",
                   XboxProfilLink = ""
                };
                TrenutniKorisnik = await _korisnikSocialsService.Insert<Model.KorisnikSocials>(request);
            }
            IsBusy = false;
        }
        async Task Sacuvaj()
        {
            IsBusy = true;
            KorisnikSocialsInsertRequest request = new KorisnikSocialsInsertRequest()
            {
                BattleNetName=TrenutniKorisnik.BattleNetName,
                BattleNetProfilLink=TrenutniKorisnik.BattleNetProfilLink,
                XboxProfilLink=TrenutniKorisnik.XboxProfilLink,
                XboxName=TrenutniKorisnik.XboxName,
                DiscordName=TrenutniKorisnik.DiscordName,
                EpicStoreName=TrenutniKorisnik.EpicStoreName,
                EpicStoreProfilLink=TrenutniKorisnik.EpicStoreProfilLink,
                KorisnikId=APIService.KorisnikId,
                NintendoName=TrenutniKorisnik.NintendoName,
                NintendoProfilLink=TrenutniKorisnik.NintendoProfilLink,
                OriginName=TrenutniKorisnik.OriginName,
                OriginProfilLink=TrenutniKorisnik.OriginProfilLink,
                Psnname=TrenutniKorisnik.Psnname,
                PsnprofilLink= TrenutniKorisnik.PsnprofilLink,
                SteamName=TrenutniKorisnik.SteamName,
                SteamProfilLink=TrenutniKorisnik.SteamProfilLink
            };
            TrenutniKorisnik = await _korisnikSocialsService.Update<Model.KorisnikSocials>(TrenutniKorisnik.KorisnikSocialsId, request);
            IsBusy = false;
        }
    }
}
