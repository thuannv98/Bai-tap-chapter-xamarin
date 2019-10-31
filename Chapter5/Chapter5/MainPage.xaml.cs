using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Chapter5
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

        private void btncontrol(object sender, EventArgs e)
        {
            Navigation.PushAsync(new control());
        }

        private void btncustomcontrol(object sender, EventArgs e)
        {
            Navigation.PushAsync(new customControl());
        }

        private void btntrigger(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Trigger());
        }

        private void btnbehavior(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Behavior());
        }
    }
}
