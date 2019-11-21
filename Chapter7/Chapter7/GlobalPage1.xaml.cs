using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Chapter7
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GlobalPage1 : ContentPage
    {
        public GlobalPage1()
        {
            InitializeComponent();
            Global.Instance.myData = "12345";
        }

        private async void Navigate(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GlobalPage2());
        }

    }
}