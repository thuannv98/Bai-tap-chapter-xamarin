using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Chapter2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PropertyValuesPage : ContentPage
    {
        public PropertyValuesPage()
        {
            InitializeComponent();
        }
        void ButtonClicked(object sender, System.EventArgs e)
        {
            ((Button)sender).Text = "It is so!";
        }
    }
}