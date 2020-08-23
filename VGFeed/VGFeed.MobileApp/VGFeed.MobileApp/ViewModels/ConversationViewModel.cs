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
    public class ConversationViewModel:BaseViewModel
    {
        private Model.Korisnici _korisnik = null;
        private readonly APIService _porukeService = new APIService("Poruke");
        private bool _nemaPoruka;
        private string _porukaTekst;
        public ConversationViewModel()
        {
            InitCommand = new Command(async () => await Init());
            SendCommand = new Command(async () => await Send());
        }
        public ObservableCollection<KorisnikPoruke> SvePoruke { get; set; } = new ObservableCollection<KorisnikPoruke>();
        public ICommand InitCommand { get; private set; }
        public ICommand SendCommand { get; private set; }
        public string PorukaTekst
        {
            get { return _porukaTekst; }
            set { SetProperty(ref _porukaTekst, value); }
        }
        public bool ShowNemaPoruka
        {
            get { return _nemaPoruka; }
            set { SetProperty(ref _nemaPoruka, value); }
        }
        public Model.Korisnici Korisnik
        {
            get { return _korisnik; }
            set { SetProperty(ref _korisnik, value); }
        }
        public class KorisnikPoruke
        {
            public string Username { get; set; }
            public Model.Poruke Poruka { get; set; }
            public string Status { get; set; }
        }
        async Task Init()
        {
            IsBusy = true;
            SvePoruke.Clear();
            PorukeSearchRequest search = new PorukeSearchRequest()
            {
                TrenutniKorisnik = APIService.KorisnikId,
                Kontakt = Korisnik.KorisnikId
            };
            var porukeList = await _porukeService.Get<List<Model.Poruke>>(search);
            if (porukeList.Count != 0)
            {
                foreach (var item in porukeList)
                {
                    if (item.Primalac == APIService.KorisnikId)
                    {
                        var request = new PorukeInsertRequest()
                        {
                            DatumKreiranja = item.DatumKreiranja,
                            Posiljalac = Korisnik.KorisnikId,
                            Primalac = APIService.KorisnikId,
                            Tekst = item.Tekst,
                            StatusPoruke = true
                        };
                       await _porukeService.Update<Model.Poruke>(item.PorukaId, request);
                    }
                    if (item.Posiljalac == APIService.KorisnikId)
                    {
                        var temp = new KorisnikPoruke()
                        {
                            Username = "You",
                            Poruka = item
                        };
                        if(item.StatusPoruke)
                        {
                            temp.Status = "Primljena, " + item.DatumKreiranja.ToString();
                        }
                        if (!item.StatusPoruke)
                        {
                            temp.Status = "Poslana, " + item.DatumKreiranja.ToString();
                        }
                        SvePoruke.Add(temp);
                    }
                    if(item.Posiljalac == Korisnik.KorisnikId)
                    {
                        var temp = new KorisnikPoruke()
                        {
                            Username = Korisnik.Username,
                            Poruka = item
                        };
                        if (item.StatusPoruke)
                        {
                            temp.Status = "Primljena, " + item.DatumKreiranja.ToString();
                        }
                        if (!item.StatusPoruke)
                        {
                            temp.Status = "Poslana, " + item.DatumKreiranja.ToString();
                        }
                        SvePoruke.Add(temp);
                    }
                    
                }
                ShowNemaPoruka = false;              
            }
            else
            {
                ShowNemaPoruka = true;
            }
            IsBusy = false;
        }
        async Task Send()
        {
            if (!string.IsNullOrWhiteSpace(PorukaTekst))
            {
                var request = new PorukeInsertRequest()
                {
                    DatumKreiranja = DateTime.Now,
                    Posiljalac = APIService.KorisnikId,
                    Primalac = Korisnik.KorisnikId,
                    StatusPoruke = false,
                    Tekst = PorukaTekst
                };
                var p = await _porukeService.Insert<Model.Poruke>(request);
                var nova = new KorisnikPoruke()
                {
                    Poruka = p,
                    Status = "Poslana, " + p.DatumKreiranja.ToString(),
                    Username = "You"
                };
                SvePoruke.Add(nova);
            }           
        }
    }
}
