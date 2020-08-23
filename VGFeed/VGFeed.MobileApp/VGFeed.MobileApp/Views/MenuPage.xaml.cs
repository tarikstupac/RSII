using VGFeed.MobileApp.Models;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VGFeed.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Igre, Title="Igre"},
                new HomeMenuItem {Id = MenuItemType.Zainteresiran, Title="Zainteresiran" },
                new HomeMenuItem {Id = MenuItemType.Odigrao, Title="Odigrao" },
                new HomeMenuItem {Id = MenuItemType.KorisnikSocials, Title="Korisnik Socials"},
                new HomeMenuItem {Id = MenuItemType.Sale, Title="Rasprodaje"},
                new HomeMenuItem {Id = MenuItemType.Korisnici, Title="Korisnici"},
                new HomeMenuItem {Id = MenuItemType.Doniraj, Title="Doniraj"}
            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }
    }
}