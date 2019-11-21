using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Chapter7
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            string[] PageNames = { "First", "Second", "Third" };
            menu.ItemsSource = PageNames;

            menu.ItemTapped += (sender, e) =>
            {
                ContentPage gotoPage = new NavPage();
                switch (e.Item.ToString())
                {
                    case "First":
                        gotoPage = new FirstPage();
                        break;
                    case "Second":
                        gotoPage = new SecondPage();
                        break;
                    case "Third":
                        gotoPage = new ThirdPage();
                        break;
                }
                Detail = new NavigationPage(gotoPage);
                ((ListView)sender).SelectedItem = null;
                this.IsPresented = false;
            };

            NavigationPage navbar = new NavigationPage(new FirstPage());
            if (Device.RuntimePlatform == Device.Android)
            {
                navbar.BarTextColor = Color.White; 
            }
            Detail = navbar;
        }
    }
}
