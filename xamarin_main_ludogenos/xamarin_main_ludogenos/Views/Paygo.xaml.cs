using BluetoothPrinter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamarin_main_ludogenos.Models
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Paygo : ContentPage
    {

        private string[] Strings = { "Não Definido", "Débito", "Crédito", "Carteira Digital"};

        public Paygo()
        {
            InitializeComponent();
            printerName.Text = "                    Não Definido";
            printerParcelamento.Text = "                 À Vista";

        }

        private string TextSize;
        private string NaoDefinido;
        private bool IsCM;
        private bool IsVC;
        private bool IsVLC;
        private bool IsIA;

        void CMChanged(object sender, CheckedChangedEventArgs e)
        {
            IsCM = e.Value;
        }
        void VCChanged(object sender, CheckedChangedEventArgs e)
        {
            IsVC = e.Value;
        }
        void VLCChanged(object sender, CheckedChangedEventArgs e)
        {
            IsVLC = e.Value;
        }
        void IAChanged(object sender, CheckedChangedEventArgs e)
        {
            IsIA = e.Value;
        }

        async void OnClickCharSet(object sender, EventArgs e)
        {
            string option = await DisplayActionSheet("", "cancelar", null, Strings);

            if (option != "cancelar" && option != null)
            {
                NaoDefinido = option;
                printerName.Text = option;
            }
        }

    }
}