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
    public class PorukeViewModel : BaseViewModel
    {
        private readonly APIService _porukeService = new APIService("Poruke");
        private readonly APIService _korisniciService = new APIService("Korisnici");
        private bool _prazan;
        public PorukeViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ICommand InitCommand { get; private set; }
        public ObservableCollection<Model.KorisnikPoruke> SvePoruke { get; set; } = new ObservableCollection<Model.KorisnikPoruke>();
        public bool Prazan { get { return _prazan; } set { SetProperty(ref _prazan, value); } }
        async Task Init()
        {
            IsBusy = true;
            SvePoruke.Clear();
            Prazan = false;
            var korisnici = await _korisniciService.Get<List<Model.Korisnici>>(null);
            foreach (var korisnik in korisnici)
            {
                if(korisnik.KorisnikId!= APIService.KorisnikId)
                {
                    PorukeSearchRequest search = new PorukeSearchRequest() { Kontakt = korisnik.KorisnikId, TrenutniKorisnik = APIService.KorisnikId };
                    var poruke = await _porukeService.Get<List<Model.Poruke>>(search);
                    if (poruke.Count != 0)
                    {
                        var zadnja = new Model.KorisnikPoruke()
                        {
                            Username = korisnik.Username,
                            Poruka = poruke[(poruke.Count - 1)],
                            Status = !poruke[(poruke.Count - 1)].StatusPoruke,
                            Korisnik = korisnik
                        };
                        SvePoruke.Add(zadnja);
                    }
                }   
            }
            if (SvePoruke.Count == 0)
                Prazan = true;
            IsBusy = false;
        }
    }
}
