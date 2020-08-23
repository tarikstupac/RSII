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
	public partial class KorisnikSocialsPage : ContentPage
	{
        private KorisnikSocialsViewModel viewModel { get { return BindingContext as KorisnikSocialsViewModel; } set { BindingContext = value; } }
        public KorisnikSocialsPage ()
		{
			InitializeComponent ();
            viewModel = new KorisnikSocialsViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            viewModel.InitCommand.Execute(null);
        }

        private void SacuvajButton_Clicked(object sender, EventArgs e)
        {
            viewModel.SacuvajCommand.Execute(null);
        }

        private void PsnnameEntry_Completed(object sender, EventArgs e)
        {
            viewModel.TrenutniKorisnik.Psnname = ((Entry)sender).Text;
        }

        private void PsnprofilLinkEntry_Completed(object sender, EventArgs e)
        {
            viewModel.TrenutniKorisnik.PsnprofilLink = ((Entry)sender).Text;
        }

        private void XboxNameEntry_Completed(object sender, EventArgs e)
        {
            viewModel.TrenutniKorisnik.XboxName = ((Entry)sender).Text;
        }

        private void XboxProfilLinkEntry_Completed(object sender, EventArgs e)
        {
            viewModel.TrenutniKorisnik.XboxProfilLink = ((Entry)sender).Text;
        }

        private void SteamNameEntry_Completed(object sender, EventArgs e)
        {
            viewModel.TrenutniKorisnik.SteamName = ((Entry)sender).Text;
        }

        private void SteamProfilLinkEntry_Completed(object sender, EventArgs e)
        {
            viewModel.TrenutniKorisnik.SteamProfilLink = ((Entry)sender).Text;
        }

        private void DiscordNameEntry_Completed(object sender, EventArgs e)
        {
            viewModel.TrenutniKorisnik.DiscordName = ((Entry)sender).Text;
        }

        private void EpicStoreNameEntry_Completed(object sender, EventArgs e)
        {
            viewModel.TrenutniKorisnik.EpicStoreName = ((Entry)sender).Text;
        }

        private void EpicStoreProfilLinkEntry_Completed(object sender, EventArgs e)
        {
            viewModel.TrenutniKorisnik.EpicStoreProfilLink = ((Entry)sender).Text;
        }

        private void OriginNameEntry_Completed(object sender, EventArgs e)
        {
            viewModel.TrenutniKorisnik.OriginName = ((Entry)sender).Text;
        }

        private void OriginProfilLinkEntry_Completed(object sender, EventArgs e)
        {
            viewModel.TrenutniKorisnik.OriginProfilLink = ((Entry)sender).Text;
        }

        private void BattleNetNameEntry_Completed(object sender, EventArgs e)
        {
            viewModel.TrenutniKorisnik.BattleNetName = ((Entry)sender).Text;
        }

        private void BattleNetProfilLinkEntry_Completed(object sender, EventArgs e)
        {
            viewModel.TrenutniKorisnik.BattleNetProfilLink = ((Entry)sender).Text;
        }

        private void NintendoNameEntry_Completed(object sender, EventArgs e)
        {
            viewModel.TrenutniKorisnik.NintendoName = ((Entry)sender).Text;
        }

        private void NintendoProfilLinkEntry_Completed(object sender, EventArgs e)
        {
            viewModel.TrenutniKorisnik.NintendoProfilLink = ((Entry)sender).Text;
        }
    }
}