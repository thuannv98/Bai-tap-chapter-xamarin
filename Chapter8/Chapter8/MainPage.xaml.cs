using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Chapter8
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void CustomRenderers(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CustomRenderers());
        }

        private void Effect(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Effects());
        }

        private void NativeViews(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NativeViews());
        }
    }
}
