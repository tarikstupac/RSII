using VGFeed.MobileApp.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VGFeed.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.Igre, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Igre:
                        MenuPages.Add(id, new NavigationPage(new IgrePage()));
                        break;
                    case (int)MenuItemType.Zainteresiran:
                        MenuPages.Add(id, new NavigationPage(new ZainteresiranPage()));
                        break;
                    case (int)MenuItemType.Odigrao:
                        MenuPages.Add(id, new NavigationPage(new OdigraoPage()));
                        break;
                    case (int)MenuItemType.KorisnikSocials:
                        MenuPages.Add(id, new NavigationPage(new KorisnikSocialsPage()));
                        break;
                    case (int)MenuItemType.Sale:
                        MenuPages.Add(id, new NavigationPage(new SalePage()));
                        break;
                    case (int)MenuItemType.Korisnici:
                        MenuPages.Add(id, new NavigationPage(new KorisniciPage()));
                        break;
                    case (int)MenuItemType.Doniraj:
                        MenuPages.Add(id, new NavigationPage(new DonacijaPage()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}