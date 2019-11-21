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
    public partial class Effects : MasterDetailPage
    {
        public Effects()
        {
            InitializeComponent();
            string[] myPageNames = { "Text Validator Effect", "Using Attached Property" };
            examples.ItemsSource = myPageNames;

            examples.ItemTapped += (sender, e) =>
            {
                ContentPage gotoPage;
                switch (e.Item.ToString())
                {
                    case "Text Validator Effect":
                        gotoPage = new TextValidatorEffectPage();
                        break;
                    case "Using Attached Property":
                        gotoPage = new UsingAttachedPropertyPage();
                        break;
                    default:
                        gotoPage = new TextValidatorEffectPage();
                        break;
                }
                Detail = new NavigationPage(gotoPage);
                ((ListView)sender).SelectedItem = null;
                this.IsPresented = false;
            };

            Detail = new NavigationPage(new TextValidatorEffectPage());
        }
    }
}