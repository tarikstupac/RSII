using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using VGFeed.Model;
using VGFeed.Model.Requests;
using Xamarin.Forms;

namespace VGFeed.MobileApp.ViewModels
{
    public class IgreViewModel : BaseViewModel
    {
        private readonly APIService _igreService = new APIService("Igre");
        private readonly APIService _platformeService = new APIService("Platforme");
        private readonly APIService _zanroviService = new APIService("Zanrovi");
        Model.Platforme _selectedPlatforma = null;
        Model.Zanrovi _selectedZanr = null;
        public IgreViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ObservableCollection<Model.Igre> IgreList { get; set; } = new ObservableCollection<Model.Igre>();

        public ObservableCollection<Model.Platforme> PlatformeList { get; set; } = new ObservableCollection<Model.Platforme>();

        public ObservableCollection<Model.Zanrovi> ZanroviList { get; set; } = new ObservableCollection<Model.Zanrovi>();

        public ICommand InitCommand { get; private set; }
        public string NazivSearch { get; set; } 
        public Model.Platforme SelectedPlatforma
        {
            get { return _selectedPlatforma; }
            set
            {
                SetProperty(ref _selectedPlatforma, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }
            }
        }
        public Model.Zanrovi SelectedZanr
        {
            get { return _selectedZanr; }
            set
            {
                SetProperty(ref _selectedZanr, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }
            }
        }

        async Task Init()
        {
            IgreSearchRequest search = new IgreSearchRequest() {Naziv= NazivSearch };
            List<Model.Igre> list = new List<Igre>();
            IsBusy = true;
            if (PlatformeList.Count == 0)
            {
                PlatformeList.Insert(0, new Platforme() {PlatformId=0, Naziv="Sve Platforme"});
                var platformList = await _platformeService.Get<List<Model.Platforme>>(null);
                foreach (var platform in platformList)
                {
                    PlatformeList.Add(platform);
                }
                SelectedPlatforma = PlatformeList[0];
            }
            if (ZanroviList.Count == 0)
            {
                ZanroviList.Insert(0, new Zanrovi() { ZanrId = 0, Naziv = "Svi Žanrovi" });
                var zanroviList = await _zanroviService.Get<List<Model.Zanrovi>>(null);
                foreach (var item in zanroviList)
                {
                    ZanroviList.Add(item);
                }
                SelectedZanr = ZanroviList[0];
            }

            if (SelectedPlatforma != null)
            {                
                search.PlatformaId = SelectedPlatforma.PlatformId;
            }
            if (SelectedZanr != null)
            {
                search.ZanrId = SelectedZanr.ZanrId;
            }

            list = await _igreService.Get<List<Model.Igre>>(search);

            IgreList.Clear();
            foreach (var item in list)
            {
                IgreList.Add(item);
            }
            IsBusy = false;
        }
    }
}
