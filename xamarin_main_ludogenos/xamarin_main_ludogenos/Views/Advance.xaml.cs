using SunmiDemo.ViewModel;
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
    public partial class Advance : ContentPage
    {
        public Advance()
        {
            InitializeComponent();
        }
            private void avancarPapel(object sender, EventArgs e)
            {
                Xamarin.Forms.DependencyService.Register<INativePages>();
                
                DependencyService.Get<INativePages>().StartActivityInAndroid("LF");
            }

        } 
}
