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
	public partial class OdigraoModalPage : ContentPage
	{
        private OdigraoModalViewModel viewModel { get { return BindingContext as OdigraoModalViewModel; } set { BindingContext = value; } }
        public OdigraoModalPage (Model.Igre igra)
		{
			InitializeComponent ();
            viewModel = new OdigraoModalViewModel();
            viewModel.Igra = igra;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            viewModel.InitCommand.Execute(null);
        }
        protected override bool OnBackButtonPressed()
        {
            return true;
        }

        private async void SacuvajButton_Clicked(object sender, EventArgs e)
        {
            viewModel.SacuvajCommand.Execute(null);
            await Navigation.PopModalAsync();
        }


        private void OcjenaSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            viewModel.TrenutniKorisnikIgre.Ocjena = (int)Math.Round(e.NewValue,MidpointRounding.AwayFromZero);
        }

        private void PosjedujeSwitch_Toggled(object sender, ToggledEventArgs e)
        {
            viewModel.TrenutniKorisnikIgre.PosjedujeIgru = e.Value;
        }

        private void RecenzijaEditor_Completed(object sender, EventArgs e)
        {
            viewModel.TrenutniKorisnikIgre.Recenzija = ((Editor)sender).Text;
        }
    }
}