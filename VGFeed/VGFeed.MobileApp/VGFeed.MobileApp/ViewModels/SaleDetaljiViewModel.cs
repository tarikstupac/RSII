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
    public class SaleDetaljiViewModel:BaseViewModel
    {
        private Model.Sale _sale = null;
        private readonly APIService _saleDetaljiService = new APIService("SaleDetalji");
        public SaleDetaljiViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<Model.SaleDetalji> SaleDetaljiList { get; set; } = new ObservableCollection<Model.SaleDetalji>();
        public ICommand InitCommand { get; set; }
        public Model.Sale Sale
        {
            get { return _sale; }
            set { SetProperty(ref _sale, value); }
        }
        async Task Init()
        {
            IsBusy = true;
            SaleDetaljiList.Clear();
            SaleDetaljiSearchRequest search = new SaleDetaljiSearchRequest()
            {
                SaleId = Sale.SaleId
            };
            var saleDetaljiList = await _saleDetaljiService.Get<List<Model.SaleDetalji>>(search);
            foreach (var item in saleDetaljiList)
            {
                SaleDetaljiList.Add(item);
            }
            IsBusy = false;
        }
    }
}
