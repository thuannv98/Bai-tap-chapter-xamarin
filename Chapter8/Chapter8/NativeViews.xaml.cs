using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Chapter8
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NativeViews : ContentPage
    {
        public NativeViews()
        {
            InitializeComponent();
        }

        private void NativeView(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NativeViews());
        }

        private void FactoryMethod(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FactoryMethodsPage());
        }
    }
}