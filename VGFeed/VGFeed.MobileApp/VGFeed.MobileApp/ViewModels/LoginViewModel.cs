using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using VGFeed.MobileApp.Views;
using Xamarin.Forms;

namespace VGFeed.MobileApp.ViewModels
{
   public class LoginViewModel:BaseViewModel
    {
        private readonly APIService _service = new APIService("Korisnici");
        string _username = string.Empty;
        string _password = string.Empty;
        public LoginViewModel()
        {
            LoginCommand = new Command(async() => await Login());
        }

        public ICommand LoginCommand { get; set; }

        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }

       
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }


        async Task Login()
        {
            IsBusy = true;
            APIService.Username = Username;
            APIService.Password = Password;

            try
            {
                var entity = await _service.Authenticate<Model.Korisnici>(Username,Password);
                APIService.KorisnikId = entity.KorisnikId;
                Application.Current.MainPage = new MainPage();
            }
            catch (Exception ex)
            {
                Username = "";
                Password = "";
                IsBusy = false;
            }

        }
    }
}
