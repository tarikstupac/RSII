using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using VGFeed.Model.Requests;
using Xamarin.Forms;

namespace VGFeed.MobileApp.ViewModels
{
   public class OdigraoModalViewModel:BaseViewModel
    {
        private readonly APIService _korisnikIgreService = new APIService("KorisnikIgre");
        private Model.Igre _igra = null;
        private Model.KorisnikIgre _trenutniKorisnikIgre = null;

        public OdigraoModalViewModel()
        {
            InitCommand = new Command(async () => await Init());
            SacuvajCommand = new Command(async () => await Sacuvaj());
        }
        public ICommand InitCommand { get; private set; }
        public ICommand SacuvajCommand { get; private set; }
        public Model.Igre Igra
        {
            get { return _igra; }
            set { SetProperty(ref _igra, value); }
        }
        public Model.KorisnikIgre TrenutniKorisnikIgre
        {
            get { return _trenutniKorisnikIgre; }
            set { SetProperty(ref _trenutniKorisnikIgre, value); }
        }
        async Task Init()
        {
            IsBusy = true;
            KorisnikIgreSearchRequest search = new KorisnikIgreSearchRequest()
            {
                IgraId = Igra.IgraId,
                KorisnikId = APIService.KorisnikId
            };
            var korisnikigra = await _korisnikIgreService.Get<List<Model.KorisnikIgre>>(search);
            TrenutniKorisnikIgre = korisnikigra[0];
            TrenutniKorisnikIgre.Ocjena = 3;
            TrenutniKorisnikIgre.PosjedujeIgru = false;
            TrenutniKorisnikIgre.Recenzija = "";
            IsBusy = false;
        }
        async Task Sacuvaj()
        {
            IsBusy = true;
            KorisnikIgreInsertRequest request = new KorisnikIgreInsertRequest()
            {
                IgraId=Igra.IgraId,
                KorisnikId=APIService.KorisnikId,
                Igrao=true,
                Ocjena=TrenutniKorisnikIgre.Ocjena,
                PosjedujeIgru=TrenutniKorisnikIgre.PosjedujeIgru,
                Recenzija=TrenutniKorisnikIgre.Recenzija,
                Zainteresiran=TrenutniKorisnikIgre.Zainteresiran
            };
            TrenutniKorisnikIgre = await _korisnikIgreService.Update<Model.KorisnikIgre>(TrenutniKorisnikIgre.KorisnikIgreId, request);
            IsBusy = false;
        }
    }
}
