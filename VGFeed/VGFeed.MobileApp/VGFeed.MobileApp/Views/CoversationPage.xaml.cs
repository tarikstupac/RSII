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
    public partial class CoversationPage : ContentPage
    {
        private ConversationViewModel viewModel { get { return BindingContext as ConversationViewModel; } set { BindingContext = value; } }
        public CoversationPage(Model.Korisnici korisnik)
        {
            InitializeComponent();
            viewModel = new ConversationViewModel();
            viewModel.Korisnik = korisnik;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            viewModel.InitCommand.Execute(null);
        }

        private void Send_Button_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(viewModel.PorukaTekst))
            {
                viewModel.InitCommand.Execute(null);
                NovaPoruka.Text = "";
            }
            else
            {
                Application.Current.MainPage.DisplayAlert("Greška", "Poruka ne smije biti prazna", "OK");
            }
        }
    }
}