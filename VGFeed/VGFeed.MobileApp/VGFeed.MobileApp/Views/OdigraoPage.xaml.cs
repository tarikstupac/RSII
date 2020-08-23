using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VGFeed.MobileApp.ViewModels;
using VGFeed.Model.Requests;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VGFeed.MobileApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class OdigraoPage : ContentPage
	{
        private OdigraoViewModel viewModel { get { return BindingContext as OdigraoViewModel; } set { BindingContext = value; } }
        private readonly APIService _igreService = new APIService("Igre");
        public OdigraoPage ()
		{
			InitializeComponent ();
            viewModel = new OdigraoViewModel();
		}
        protected override void OnAppearing()
        {
            base.OnAppearing();
            viewModel.InitCommand.Execute(null);
        }

        private async void IzmjeniButton_Clicked(object sender, EventArgs e)
        {
            var item = (Model.KorisnikIgre)((Button)sender).BindingContext;
            var igra = await _igreService.GetById<Model.Igre>(item.IgraId);
            var modalpage = new OdigraoModalPage(igra);
            var waitHandle = new EventWaitHandle(false, EventResetMode.AutoReset);
            modalpage.Disappearing += (sender2, e2) =>
              {
                  waitHandle.Set();
              };
            await Navigation.PushModalAsync(modalpage);
            await Task.Run(() => waitHandle.WaitOne());
            viewModel.InitCommand.Execute(null);
        }
    }
}