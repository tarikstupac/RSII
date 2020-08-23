using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using Stripe;
using VGFeed.Model;
using VGFeed.Model.Requests;
using Xamarin.Forms;

namespace VGFeed.MobileApp.ViewModels
{
    public class DonacijaViewModel:BaseViewModel
    {
        private APIService _donacijaService = new APIService("Donacije");
        private CreditCardModel _creditCardModel;
        private TokenService Tokenservice;
        private Token stripeToken;
        private bool _isCardValid;
        private bool _isTransactionSuccess;
        private string _expMonth;
        private string _expYear;


        private string StripeTestApiKey = "pk_test_51H5xfqFd8ooSbuNAR6xZkNeEM6X45pWTqbuX29qqG0KZ3tRd7k2ouoiDfXKg0qBJfyf2fuljFFuf65Tf1F1PUWnb004nOvV1mz";
        public string ExpMonth
        {
            get { return _expMonth; }
            set { SetProperty(ref _expMonth, value); }
        }

        public bool IsCardValid
        {
            get { return _isCardValid; }
            set { SetProperty(ref _isCardValid, value); }
        }

        public bool IsTransactionSuccess
        {
            get { return _isTransactionSuccess; }
            set { SetProperty(ref _isTransactionSuccess, value); }
        }

        public string ExpYear
        {
            get { return _expYear; }
            set { SetProperty(ref _expYear, value); }
        }
        decimal _iznos;
        public decimal Iznos
        {
            get { return _iznos; }
            set { SetProperty(ref _iznos, value); }
        }

        public CreditCardModel CreditCardModel
        {
            get { return _creditCardModel; }
            set { SetProperty(ref _creditCardModel, value); }
        }

        public ICommand SubmitCommand { get; private set; }

        public DonacijaViewModel()
        {
            CreditCardModel = new CreditCardModel();
            SubmitCommand = new Command(async () => await Submit());
        }



        public async Task Submit ()
        {
            CreditCardModel.ExpMonth = Convert.ToInt64(ExpMonth);
            CreditCardModel.ExpYear = Convert.ToInt64(ExpYear);
            CancellationTokenSource tokenSource = new CancellationTokenSource();
            CancellationToken token = tokenSource.Token;
            try
            {
                IsBusy = true;
                await Task.Run(async () =>
                {

                    var Token = CreateToken();
                    Console.Write("Payment Gateway" + "Token :" + Token);
                    if (Token != null)
                    {
                        await MakePayment(Token);
                    }
                    else
                    {
                        await Xamarin.Forms.Application.Current.MainPage.DisplayAlert("Greška", "Pogrešni podaci kreditne kartice", "OK");
                    }
                });
            }
            catch (Exception ex)
            {
                IsBusy = false;
                await Xamarin.Forms.Application.Current.MainPage.DisplayAlert("Greška", ex.Message, "OK");
                Console.Write("Payment Gatway" + ex.Message);

            }

            if (IsTransactionSuccess)
            {
                Console.Write("Payment Gateway" + "Payment Successful ");
                await Xamarin.Forms.Application.Current.MainPage.DisplayAlert("Vaša uplata je uspješna", "Uspješna uplata", "OK");
                IsBusy = false;

            }
            else
            {
                IsBusy = false;
                await Xamarin.Forms.Application.Current.MainPage.DisplayAlert("Greška", "Uplata nije uspjela", "OK");
                Console.Write("Payment Gateway" + "Payment Failure ");
            }


        }



        private string CreateToken()
        {
            try
            {
                StripeConfiguration.ApiKey = StripeTestApiKey;
                var service = new ChargeService();
                var Tokenoptions = new TokenCreateOptions
                {
                    Card = new CreditCardOptions
                    {
                        Number = CreditCardModel.Number,
                        ExpYear = CreditCardModel.ExpYear,
                        ExpMonth = CreditCardModel.ExpMonth,
                        Cvc = CreditCardModel.Cvc,
                        Name = APIService.Username,
                        AddressLine1 = "Adresa 1",
                        AddressLine2 = "Adresa 2",
                        AddressCity = "Mostar",
                        AddressZip = "88000",
                        AddressState = "HNK",
                        AddressCountry = "Bosnia and Herzegovina",
                        Currency = "usd",
                    }
                };

                Tokenservice = new TokenService();
                stripeToken = Tokenservice.Create(Tokenoptions);
                return stripeToken.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task MakePayment(string token)
        {
            DonacijeInsertRequest request = new DonacijeInsertRequest()
            {
                DatumUplate=DateTime.Now,
                Kolicina=(double)Iznos,
                Token=token,
                KorisnikId=APIService.KorisnikId
            };
            var donacija=await _donacijaService.Insert<Model.Donacije>(request);
            if (donacija != null)
                IsTransactionSuccess = true;
        }

        private bool ValidateCard()
        {
            if (CreditCardModel.Number.Length == 16 && ExpMonth.Length == 2 && ExpYear.Length == 2 && CreditCardModel.Cvc.Length == 3)
            {
                return true;
            }
            return false;
        }

    }
}
