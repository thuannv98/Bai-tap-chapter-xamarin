using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Chapter2
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            string[] myPageNames = { "Namespace", "Static", "Array", "Reference", "Constructors", "Property Values" };
            examples.ItemsSource = myPageNames;

            examples.ItemTapped += (sender, e) =>
            {
                ContentPage gotoPage;
                switch (e.Item.ToString())
                {
                    case "Namespace":
                        gotoPage = new NamespacePage();
                        break;
                    case "Static":
                        gotoPage = new StaticPage();
                        break;
                    case "Array":
                        gotoPage = new ArrayPage();
                        break;
                    case "Reference":
                        gotoPage = new ReferencePage();
                        break;
                    case "Constructors":
                        gotoPage = new ConstructorsPage();
                        break;
                    case "Property Values":
                        gotoPage = new PropertyValuesPage();
                        break;
                    default:
                        gotoPage = new NamespacePage();
                        break;
                }
                Detail = new NavigationPage(gotoPage);
                ((ListView)sender).SelectedItem = null;
                this.IsPresented = false;
            };

            Detail = new NavigationPage(new NamespacePage());
        }
    }
}
