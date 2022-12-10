using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using xamarin_main_ludogenos.Models;
using xamarin_main_ludogenos.Views;

namespace xamarin_main_ludogenos
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }
        private void ImageButtonTest_ClickedAsync(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Models.Test());
        }

        private void ImageButtonQR_ClickedAsync(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Models.QRCode());
        }

        private void ImageButtonBarcode_ClickedAsync(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Models.Barcode());
        }


        private void ImageButtonTxt_ClickedAsync(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Models.Text());
        }

        private void SettingsButton(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Models.Settings());
        }

        private void ImageButtonForm(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Models.Form());
        }

        private void ImageButtonImagem(object sender, EventArgs e)
        {

        }

        private void ImageButtonAdvancePaper(object sender, EventArgs e)
        {

        }

        private void ImageButtonMsitef(object sender, EventArgs e)
        {

        }

        private void ImageButtonPayGo(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Models.Paygo());
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1Settings());
        }

    }
}
