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
	public partial class IgrePage : ContentPage
	{
        private IgreViewModel ViewModel {
            get { return BindingContext as IgreViewModel; }
            set { BindingContext= value; }
        }
		public IgrePage ()
		{
			InitializeComponent ();
            ViewModel = new IgreViewModel();
		}

        protected  override void OnAppearing()
        {
            base.OnAppearing();
            ViewModel.InitCommand.Execute(null);            
        }

        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            var igra = e.SelectedItem as Model.Igre;
            await Navigation.PushAsync(new IgreDetaljiPage(igra));
            listView.SelectedItem = null;
        }

        private void SearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            ViewModel.NazivSearch = ((SearchBar)sender).Text;
            ViewModel.InitCommand.Execute(null);
        }
    }
}