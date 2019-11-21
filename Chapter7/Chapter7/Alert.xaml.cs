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
    public partial class Alert : ContentPage
    {
        public Alert()
        {
            InitializeComponent();
        }

        private void alert(object sender, EventArgs e)
        {
            DisplayAlert("Thông báo", "This's an alert", "OK");
        }
    }
}