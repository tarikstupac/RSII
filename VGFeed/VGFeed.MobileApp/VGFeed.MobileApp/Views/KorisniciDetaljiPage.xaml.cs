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
    public partial class KorisniciDetaljiPage : ContentPage
    {
        private KorisniciDetaljiViewModel viewModel { get { return BindingContext as KorisniciDetaljiViewModel; } set { BindingContext = value; } }
        private APIService igreService = new APIService("Igre");
        public KorisniciDetaljiPage(Model.Korisnici korisnik)
        {
            InitializeComponent();
            viewModel = new KorisniciDetaljiViewModel();
            viewModel.Korisnik = korisnik;
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
            var korisnikIgra = e.SelectedItem as Model.KorisnikIgre;
            var igra = await igreService.GetById<Model.Igre>(korisnikIgra.IgraId);
            await Navigation.PushAsync(new IgreDetaljiPage(igra));
            listView.SelectedItem = null;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CoversationPage(viewModel.Korisnik));
        }
    }
}