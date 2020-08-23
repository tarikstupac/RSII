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
	public partial class ZainteresiranPage : ContentPage
	{
        private ZainteresiranViewModel viewModel { get { return BindingContext as ZainteresiranViewModel; } set { BindingContext = value; } }
        public ZainteresiranPage ()
		{
			InitializeComponent ();
            viewModel = new ZainteresiranViewModel();
		}
        protected override void OnAppearing()
        {
            base.OnAppearing();
            viewModel.InitCommand.Execute(null);
        }

        private void UkloniButton_Clicked(object sender, EventArgs e)
        {
            var item = (Model.KorisnikIgre)((Button)sender).BindingContext;
            viewModel.UkloniCommand.Execute(item);
        }
    }
}