using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamarin_main_ludogenos.Models
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Paygo : ContentPage
    {

        private string[] Strings = { "R$10", "R$50", "R$60", "R$100" };
        public Paygo()
        {
            InitializeComponent();
            printerName.Text = "                                   Não Definido";
            printerParcelamento.Text = "                                À Vista";

        }

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

    }
}