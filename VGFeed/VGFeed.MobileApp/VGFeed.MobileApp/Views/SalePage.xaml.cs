using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VGFeed.MobileApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VGFeed.MobileApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SalePage : ContentPage
	{
        private SaleViewModel viewModel
        {
            get { return BindingContext as SaleViewModel; }
            set { BindingContext = value; }
        }
        public SalePage ()
		{
			InitializeComponent ();
            viewModel = new SaleViewModel();
		}
        protected override void OnAppearing()
        {
            base.OnAppearing();
            viewModel.InitComand.Execute(null);
        }

        private void DatumOd_DateSelected(object sender, DateChangedEventArgs e)
        {
            viewModel.DatumOd = e.NewDate;
            viewModel.InitComand.Execute(null);
        }

        private void DatumDo_DateSelected(object sender, DateChangedEventArgs e)
        {
            viewModel.DatumDo = e.NewDate;
            viewModel.InitComand.Execute(null);
        }

        private async void ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            var sale = e.SelectedItem as Model.Sale;
            await Navigation.PushAsync(new SaleDetaljiPage(sale));
            listView.SelectedItem = null;
        }

        private void SearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            viewModel.NazivSearch = ((SearchBar)sender).Text;
            viewModel.InitComand.Execute(null);
        }
    }
}