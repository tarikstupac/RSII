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
	public partial class KorisniciPage : ContentPage
	{
        private KorisniciViewModel ViewModel
        {
            get { return BindingContext as KorisniciViewModel; }
            set { BindingContext = value; }
        }
        public KorisniciPage ()
		{
			InitializeComponent ();
            ViewModel = new KorisniciViewModel();
		}
        protected override void OnAppearing()
        {
            base.OnAppearing();
            ViewModel.InitCommand.Execute(null);
        }

        private void SearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            ViewModel.UsernameSearch = ((SearchBar)sender).Text;
            ViewModel.InitCommand.Execute(null);
        }

        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            var korisnik = e.SelectedItem as Model.Korisnici;
            await Navigation.PushAsync(new KorisniciDetaljiPage(korisnik));
            listView.SelectedItem = null;
        }
    }
}