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
    public class OdigraoViewModel:BaseViewModel
    {
        private readonly APIService _korisnikIgreService = new APIService("KorisnikIgre");
        private bool _showOdigrao;
        public OdigraoViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<Model.KorisnikIgre> KorisnikIgreList { get; set; } = new ObservableCollection<Model.KorisnikIgre>();
        public ICommand InitCommand { get; private set; }
        public bool ShowOdigrao
        {
            get { return _showOdigrao; }
            set { SetProperty(ref _showOdigrao, value); }
        }
        async Task Init()
        {
            IsBusy = true;
            KorisnikIgreList.Clear();
            KorisnikIgreSearchRequest search = new KorisnikIgreSearchRequest()
            {
                KorisnikId = APIService.KorisnikId,
                Igrao = true
            };
            var list = await _korisnikIgreService.Get<List<Model.KorisnikIgre>>(search);
            if (list.Count == 0 || list == null)
            {
                ShowOdigrao = true;
            }
            else
            {
                foreach (var item in list)
                {
                    KorisnikIgreList.Add(item);
                }
            }
            IsBusy = false;
        }
    }
}
