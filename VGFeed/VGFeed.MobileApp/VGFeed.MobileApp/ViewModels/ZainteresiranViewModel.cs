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
    public class ZainteresiranViewModel:BaseViewModel
    {
        private readonly APIService _korisnikIgreService = new APIService("KorisnikIgre");
        private bool _showZainteresiran;

        public ZainteresiranViewModel()
        {
            InitCommand = new Command(async () => await Init());
            UkloniCommand = new Command<Model.KorisnikIgre>(async p => await Ukloni(p));
        }
        public ObservableCollection<Model.KorisnikIgre> KorisnikIgreList { get; set; } = new ObservableCollection<Model.KorisnikIgre>();
        public ICommand InitCommand { get; private set; }
        public ICommand UkloniCommand  { get; private set; }
        public bool ShowZainteresiran
        {
            get { return _showZainteresiran; }
            set { SetProperty(ref _showZainteresiran, value); }
        }

        async Task Init()
        {
            IsBusy = true;
            KorisnikIgreList.Clear();
            KorisnikIgreSearchRequest search = new KorisnikIgreSearchRequest()
            {
                KorisnikId=APIService.KorisnikId,
                Zainteresiran=true
            };
            var list = await _korisnikIgreService.Get<List<Model.KorisnikIgre>>(search);
            if(list.Count==0 || list == null)
            {
                ShowZainteresiran = true;
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
        async Task Ukloni(Model.KorisnikIgre p)
        {
            if (p == null)
                return;
           
            KorisnikIgreInsertRequest request = new KorisnikIgreInsertRequest()
            {
                IgraId = p.IgraId,
                KorisnikId = APIService.KorisnikId,
                Igrao = p.Igrao,
                Ocjena = p.Ocjena,
                PosjedujeIgru = p.PosjedujeIgru,
                Recenzija = p.Recenzija,
                Zainteresiran = false
            };
            await _korisnikIgreService.Update<Model.KorisnikIgre>(p.KorisnikIgreId, request);
            KorisnikIgreList.Remove(p);
        }
    }
}
