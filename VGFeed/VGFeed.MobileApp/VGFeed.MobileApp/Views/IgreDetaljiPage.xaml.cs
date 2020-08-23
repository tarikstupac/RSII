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
	public partial class IgreDetaljiPage : ContentPage
	{
        private IgreDetaljiViewModel viewModel { get { return BindingContext as IgreDetaljiViewModel; } set { BindingContext = value; } }
		public IgreDetaljiPage (Model.Igre igra)
		{
			InitializeComponent ();
            viewModel = new IgreDetaljiViewModel();
            viewModel.Igra = igra;
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
            viewModel.InitCommand.Execute(null);
        }

        private async void OdigraoButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new OdigraoModalPage(viewModel.Igra));
            viewModel.OdigraoClickedCommand.Execute(null);
        }

        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            var igra = e.SelectedItem as Model.Igre;
            await Navigation.PushAsync(new IgreDetaljiPage(igra));
            listView.SelectedItem = null;
        }
    }
}