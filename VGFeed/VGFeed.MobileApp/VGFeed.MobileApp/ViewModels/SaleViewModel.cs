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
    public class SaleViewModel:BaseViewModel
    {
        private readonly APIService _saleService = new APIService("Sale");
        private DateTime _datumOd = DateTime.MinValue;
        private DateTime _datumDo= DateTime.Now.AddYears(5);

        public SaleViewModel()
        {
            InitComand = new Command(async () => await Init());
        }
        public ObservableCollection<Model.Sale> SaleList { get; set; } = new ObservableCollection<Model.Sale>();
        public ICommand InitComand { get; private set; }
        public DateTime DatumOd
        {
            get { return _datumOd; }
            set { SetProperty(ref _datumOd, value); }
        }
        public DateTime DatumDo
        {
            get { return _datumDo; }
            set { SetProperty(ref _datumDo, value); }
        }
        public string NazivSearch { get; set; }

        async Task Init()
        {
            IsBusy = true;
            SaleList.Clear();
            SaleSearchRequest search = new SaleSearchRequest()
            {
                DatumStart=DatumOd,
                DatumEnd=DatumDo,
                Naziv=NazivSearch
            };
            var list = await _saleService.Get<List<Model.Sale>>(search);
            foreach (var item in list)
            {
                SaleList.Add(item);
            }
            IsBusy = false;
        }
    }
}
