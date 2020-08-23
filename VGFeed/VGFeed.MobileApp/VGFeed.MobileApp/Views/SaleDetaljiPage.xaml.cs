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
	public partial class SaleDetaljiPage : ContentPage
	{
        private SaleDetaljiViewModel viewModel { get { return BindingContext as SaleDetaljiViewModel; } set { BindingContext = value; } }
        public SaleDetaljiPage (Model.Sale sale)
		{
			InitializeComponent ();
            viewModel = new SaleDetaljiViewModel();
            viewModel.Sale = sale;
		}
        protected override void OnAppearing()
        {
            base.OnAppearing();
            viewModel.InitCommand.Execute(null);
        }
    }
}