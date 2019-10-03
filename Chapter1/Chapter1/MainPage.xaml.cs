using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Chapter1
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
        protected void ButtonClicked(object sender, EventArgs e)
        {

            ((Button)sender).Text = "It is so!";
        }

        async protected void ImageTapped(object sender, EventArgs e)
        {

            Image image = ((Image)sender);

            image.Opacity = .5;
            await Task.Delay(200);
            image.Opacity = 1;
        }
    }
}
