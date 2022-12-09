using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace xamarin_main_ludogenos
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        private void ImageButtonBarcode_ClickedAsync(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Models.Barcode());
        }

        private void ImageButtonQR_ClickedAsync(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Models.QRCode());
        }

        private void ImageButtonTest_ClickedAsync(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Models.Test());
        }

        private void ImageButtonTxt_ClickedAsync(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Models.Text());
        }

        private void SettingsButton(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Models.Settings());
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {

        }

        private void ImageButton_Clicked_1(object sender, EventArgs e)
        {

        }

        private void ImageButton_Clicked_2(object sender, EventArgs e)
        {

        }

        private void ImageButton_Clicked_3(object sender, EventArgs e)
        {

        }

        private void ImageButton_Clicked_4(object sender, EventArgs e)
        {

        }
    }
}
