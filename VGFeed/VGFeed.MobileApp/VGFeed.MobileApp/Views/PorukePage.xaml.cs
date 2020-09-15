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
	public partial class PorukePage : ContentPage
	{
        private PorukeViewModel viewModel { get { return BindingContext as PorukeViewModel; } set { BindingContext = value; } }
        public PorukePage ()
		{
			InitializeComponent ();
            viewModel = new PorukeViewModel();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
            viewModel.InitCommand.Execute(null);
        }

        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            var korisnik = e.SelectedItem as Model.KorisnikPoruke;
            await Navigation.PushAsync(new CoversationPage(korisnik.Korisnik));
            listView.SelectedItem = null;
        }
    }
}