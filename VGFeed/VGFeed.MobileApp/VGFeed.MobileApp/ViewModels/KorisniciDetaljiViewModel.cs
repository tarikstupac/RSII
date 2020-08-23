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
   public class KorisniciDetaljiViewModel:BaseViewModel
    {
        private Model.Korisnici _korisnik = null;
        private readonly APIService _korisnikIgreService = new APIService("KorisnikIgre");
        private readonly APIService _korisnikSocialsService = new APIService("KorisnikSocials");
        private Model.KorisnikSocials _trenutniKorisnikSocials;

        public KorisniciDetaljiViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<Model.KorisnikIgre> OdigraneIgre { get; set; } = new ObservableCollection<Model.KorisnikIgre>();
        public ObservableCollection<Model.KorisnikIgre> ZainteresiranIgre { get; set; } = new ObservableCollection<Model.KorisnikIgre>();
        public ICommand InitCommand { get; private set; }

        public Model.Korisnici Korisnik
        {
            get { return _korisnik; }
            set { SetProperty(ref _korisnik, value); }
        }
        public Model.KorisnikSocials TrenutniKorisnikSocials
        {
            get { return _trenutniKorisnikSocials; }
            set { SetProperty(ref _trenutniKorisnikSocials, value); }
        }

        async Task Init()
        {
            IsBusy = true;
            ZainteresiranIgre.Clear();
            OdigraneIgre.Clear();
            TrenutniKorisnikSocials = new Model.KorisnikSocials();
            KorisnikIgreSearchRequest search = new KorisnikIgreSearchRequest() { KorisnikId = Korisnik.KorisnikId };
            KorisnikSocialsSearchRequest search2 = new KorisnikSocialsSearchRequest() { KorisnikId = Korisnik.KorisnikId };
            var igrelist = await _korisnikIgreService.Get<List<Model.KorisnikIgre>>(search);
            var socialslist = await _korisnikSocialsService.Get<List<Model.KorisnikSocials>>(search2);
            if (igrelist.Count != 0)
            {
                foreach (var item in igrelist)
                {
                    if (item.Zainteresiran == true)
                        ZainteresiranIgre.Add(item);
                    if (item.Igrao == true)
                        OdigraneIgre.Add(item);
                }
            }
            if (socialslist.Count != 0)
            {
                TrenutniKorisnikSocials = socialslist[0];
            }
            IsBusy = false;
        }
    }
}
