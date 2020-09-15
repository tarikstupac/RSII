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
    public class KorisniciViewModel:BaseViewModel
    {
        private readonly APIService _korisnikService = new APIService("Korisnici");
        private readonly APIService _drzaveService = new APIService("Drzave");
        private readonly APIService _recommendService = new APIService("SlicniKorisnici");
        Model.Drzave _selectedDrzava = null;
        public KorisniciViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<Model.Korisnici> KorisniciList { get; set; } = new ObservableCollection<Model.Korisnici>();
        public ObservableCollection<Model.Korisnici> SlicniKorisnici { get; set; } = new ObservableCollection<Model.Korisnici>();
        public ObservableCollection<Model.Drzave> DrzaveList { get; set; } = new ObservableCollection<Model.Drzave>();
        public string UsernameSearch { get; set; }
        public ICommand InitCommand { get; private set; }
        public Model.Drzave SelectedDrzava
        {
            get { return _selectedDrzava; }
            set
            {
                SetProperty(ref _selectedDrzava, value);
                if (value != null && value.DrzavaId!=0)
                {
                    InitCommand.Execute(null);
                }
            }
        }

        private async Task Init()
        {
            IsBusy = true;
            KorisniciSearchRequest search = new KorisniciSearchRequest() { Username = UsernameSearch };
            KorisniciList.Clear();
            SlicniKorisnici.Clear();
            if (DrzaveList.Count == 0)
            {
                DrzaveList.Insert(0, new Model.Drzave() { DrzavaId = 0, Naziv = "Sve Države" });
                var drzaveList = await _drzaveService.Get<List<Model.Drzave>>(null);
                foreach (var drzava in drzaveList)
                {
                    DrzaveList.Add(drzava);
                }
                SelectedDrzava = DrzaveList[0];
            }
            if (SelectedDrzava != null && SelectedDrzava.DrzavaId!=0)
            {
                search.DrzavaId = SelectedDrzava.DrzavaId;
            }
            var list = await _korisnikService.Get<List<Model.Korisnici>>(search);
            if (list.Count != 0)
            {
                foreach (var item in list)
                {
                    if (item.KorisnikId != APIService.KorisnikId)
                        KorisniciList.Add(item);
                }
            }
            var slicniList = await _recommendService.GetSlicni<List<Model.Korisnici>>(APIService.KorisnikId);
            if(slicniList.Count != 0)
            {
                foreach (var k in slicniList)
                {
                    SlicniKorisnici.Add(k);
                }
            }
            IsBusy = false;
        }
    }
}
