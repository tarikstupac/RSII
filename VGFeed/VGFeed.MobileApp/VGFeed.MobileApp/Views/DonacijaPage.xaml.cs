﻿using System;
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
	public partial class DonacijaPage : ContentPage
	{
        private DonacijaViewModel viewModel
        {
            get { return BindingContext as DonacijaViewModel; }
            set { BindingContext = value; }
        }
        public DonacijaPage ()
		{
			InitializeComponent ();
            viewModel = new DonacijaViewModel();
		}
        protected override void OnAppearing()
        {
            Submit_Button.IsEnabled = false;
            ErrorLabel_CardNumber.IsVisible = false;
            ErrorLabel_Cvv.IsVisible = false;
            ErrorLabel_Month.IsVisible = false;
            ErrorLabel_Year.IsVisible = false;
            ErrorLabel_Iznos.IsVisible = false;
        }
        private void CardNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (CardNumber.Text.Length > 16)
            {
                ErrorLabel_CardNumber.IsVisible = true;
                CardNumber.Text = RemoveLastCharacter(CardNumber.Text);
                ErrorLabel_CardNumber.Text = "Invalid Card number";
            }
            else if (CardNumber.Text.Length < 1)
            {
                ErrorLabel_CardNumber.IsVisible = true;
                ErrorLabel_CardNumber.Text = "Card number can not be empty !!";

            }
            else
            {
                ErrorLabel_CardNumber.IsVisible = false;

            }
            EnableSubmitButton();
        }
        private void CardNumber_Completed(object sender, System.EventArgs e)
        {
            if (CardNumber.Text.Length > 16 || CardNumber.Text.Length < 12)
            {
                ErrorLabel_CardNumber.IsVisible = true;
                ErrorLabel_CardNumber.Text = "Invalid Card number";
                EnableSubmitButton();
            }
            else
            {
                ErrorLabel_CardNumber.IsVisible = false;
            }
            CardNumber.Unfocus();
            Month.Focus();
            EnableSubmitButton();
        }

        private void Month_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Month.Text.Length < 1)
            {
                ErrorLabel_Month.IsVisible = true;
                ErrorLabel_Month.Text = "Month can not be empty !!";
            }
            else if (Month.Text.Length > 2)
            {
                Month.Text = RemoveLastCharacter(Month.Text);
                ErrorLabel_Month.IsVisible = true;
                ErrorLabel_Month.Text = "Invalid month !!";
            }
            else
            {
                ErrorLabel_Month.IsVisible = false;
                EnableSubmitButton();
            }
            EnableSubmitButton();
        }
        private void Month_Completed(object sender, System.EventArgs e)
        {
            Month.Unfocus();
            Year.Focus();
        }

        private void Year_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Year.Text.Length < 1)
            {
                ErrorLabel_Year.IsVisible = true;
                ErrorLabel_Year.Text = "Year can not be empty !!";
            }
            else if (Year.Text.Length > 2)
            {
                Year.Text = RemoveLastCharacter(Year.Text);
                ErrorLabel_Year.IsVisible = true;
                ErrorLabel_Year.Text = "Invalid year !!";
            }
            else
            {
                ErrorLabel_Year.IsVisible = false;
                EnableSubmitButton();
            }
            EnableSubmitButton();
        }
        private void Year_Completed(object sender, System.EventArgs e)
        {
            Year.Unfocus();
            Cvv.Focus();
        }

        private void Cvv_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Cvv.Text.Length < 1)
            {
                ErrorLabel_Cvv.IsVisible = true;
                ErrorLabel_Cvv.Text = "CVV can not be empty !!";
            }
            else if (Cvv.Text.Length > 3)
            {
                Cvv.Text = RemoveLastCharacter(Cvv.Text);
                ErrorLabel_Cvv.IsVisible = true;
                ErrorLabel_Cvv.Text = "Invalid Cvv !!";
            }
            else
            {
                ErrorLabel_Cvv.IsVisible = false;
                EnableSubmitButton();
            }

            EnableSubmitButton();
        }
        private void Cvv_Completed(object sender, System.EventArgs e)
        {
            Cvv.Unfocus();
            Iznos.Focus();
        }
        private void Iznos_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Iznos.Text.Length < 1)
            {
                ErrorLabel_Cvv.IsVisible = true;
                ErrorLabel_Cvv.Text = "Iznos ne smije biti prazan !!";
            }
            else
            {
                ErrorLabel_Cvv.IsVisible = false;
                EnableSubmitButton();
            }

            EnableSubmitButton();
        }
        private void Iznos_Completed(object sender, EventArgs e)
        {
            Iznos.Unfocus();
        }

        private void EnableSubmitButton()
        {
            if (ErrorLabel_CardNumber.IsVisible || ErrorLabel_Cvv.IsVisible || ErrorLabel_Month.IsVisible || ErrorLabel_Year.IsVisible || ErrorLabel_Iznos.IsVisible)
            {
                Submit_Button.IsEnabled = false;
            }
            else
            {
                Submit_Button.IsEnabled = true;
            }
        }
        private string RemoveLastCharacter(string str)
        {
            int l = str.Length;
            string text = str.Remove(l - 1, 1);
            return text;
        }

        private void Submit_Button_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MainPage();
        }

       
    }
}