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
    public class IgreDetaljiViewModel : BaseViewModel
    {
        private Model.Igre _igra = null;
        private float _prosjecnaOcjena = 0;
        private readonly APIService _korisnikIgreService = new APIService("KorisnikIgre");
        private readonly APIService _recommendedService = new APIService("Recommend");
        private Model.KorisnikIgre _trenutniKorisnikIgre = null;
        private bool _disableOdigrao;
        private bool _disableZainteresiran;
        public IgreDetaljiViewModel()
        {
            InitCommand = new Command(async () => await Init());
            ZainteresiranClickedCommand = new Command(async () => await ZainteresiranClicked());
            OdigraoClickedCommand = new Command(async () => await OdigraoClicked());
        }
        public ObservableCollection<Model.KorisnikIgre> IgraReviewOcjena { get; set; } = new ObservableCollection<Model.KorisnikIgre>();
        public ObservableCollection<Model.Igre> SlicneIgre { get; set; } = new ObservableCollection<Model.Igre>();
        public ICommand InitCommand { get; private set; }
        public ICommand ZainteresiranClickedCommand { get; set; }
        public ICommand OdigraoClickedCommand { get; set; }
        public bool DisableOdigrao
        {
            get { return _disableOdigrao; }
            set { SetProperty(ref _disableOdigrao, value); }
        }
        public bool DisableZainteresiran
        {
            get { return _disableZainteresiran; }
            set { SetProperty(ref _disableZainteresiran, value); }
        }
        public Model.Igre Igra {
            get { return _igra; }
            set { SetProperty(ref _igra, value); }
        }
        public float ProsjecnaOcjena
        {
            get { return _prosjecnaOcjena; }
            set { SetProperty(ref _prosjecnaOcjena, value); }
        }
        public Model.KorisnikIgre TrenutniKorisnikIgre
        {
            get { return _trenutniKorisnikIgre; }
            set { SetProperty(ref _trenutniKorisnikIgre, value); }
        }

        async Task LoadProsjecnaOcjena()
        {
            IgraReviewOcjena.Clear();
            KorisnikIgreSearchRequest search = new KorisnikIgreSearchRequest()
            {
                IgraId = Igra.IgraId,
                Igrao = true
            };
            var list = await _korisnikIgreService.Get<List<Model.KorisnikIgre>>(search);
            int sum = 0;
            if (list.Count != 0)
            {
                foreach (var item in list)
                {
                    if (item.Ocjena.HasValue && item.Ocjena != 0)
                    {
                        IgraReviewOcjena.Add(item);
                        sum += item.Ocjena.Value;
                    }
                }
                ProsjecnaOcjena = sum / IgraReviewOcjena.Count;
            }
        }
        async Task LoadSlicneIgre()
        {
            SlicneIgre.Clear();
            var list = await _recommendedService.GetSlicni<List<Model.Igre>>(Igra.IgraId);
            if (list.Count != 0)
            {
                foreach (var item in list)
                {
                    SlicneIgre.Add(item);
                }
            }
        }
        async Task Init()
        {
            IsBusy = true;
            await LoadProsjecnaOcjena();
            await LoadSlicneIgre();
            KorisnikIgreSearchRequest search = new KorisnikIgreSearchRequest()
            {
                IgraId = Igra.IgraId,
                KorisnikId = APIService.KorisnikId
            };
            var korisnikigra = await _korisnikIgreService.Get<List<Model.KorisnikIgre>>(search);
            if (korisnikigra.Count != 0)
            {
                TrenutniKorisnikIgre = korisnikigra[0];               
            }
            else
            {
                KorisnikIgreInsertRequest request = new KorisnikIgreInsertRequest()
                {
                    IgraId = Igra.IgraId,
                    KorisnikId = APIService.KorisnikId,
                    Igrao = false,
                    Zainteresiran = false
                };
                TrenutniKorisnikIgre = await _korisnikIgreService.Insert<Model.KorisnikIgre>(request);
            }
            DisableOdigrao = !TrenutniKorisnikIgre.Igrao.Value;
            DisableZainteresiran = !TrenutniKorisnikIgre.Zainteresiran.Value;
            IsBusy = false;
        }

        async Task ZainteresiranClicked()
        {
            IsBusy = true;
            KorisnikIgreInsertRequest request = new KorisnikIgreInsertRequest()
            {
                IgraId = Igra.IgraId,
                KorisnikId = APIService.KorisnikId,
                Zainteresiran = true,
                Igrao= TrenutniKorisnikIgre.Igrao,
                Ocjena=TrenutniKorisnikIgre.Ocjena,
                PosjedujeIgru= TrenutniKorisnikIgre.PosjedujeIgru,
                Recenzija = TrenutniKorisnikIgre.Recenzija
            };
            TrenutniKorisnikIgre = await _korisnikIgreService.Update<Model.KorisnikIgre>(TrenutniKorisnikIgre.KorisnikIgreId, request);
            DisableZainteresiran = !TrenutniKorisnikIgre.Zainteresiran.Value;
            IsBusy = false;
        }

        async Task OdigraoClicked()
        {
            IsBusy = true;
            TrenutniKorisnikIgre = await _korisnikIgreService.GetById<Model.KorisnikIgre>(TrenutniKorisnikIgre.KorisnikIgreId);
            DisableOdigrao = false;
            TrenutniKorisnikIgre.Igrao = true;
            IsBusy = false;
        }

    }
}
