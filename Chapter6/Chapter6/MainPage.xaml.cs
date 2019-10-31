using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Chapter6
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel(Navigation);
        }
        public class MainPageViewModel : BindableObject
        {

            private readonly INavigation navigation;

            public Command<string> NavigateCommand
            {
                get;
                set;
            }

            public MainPageViewModel(INavigation navigation)
            {
                this.navigation = navigation;
                NavigateCommand = new Command<string>(NagivigateRequested);
            }


            async void NagivigateRequested(string pageName)
            {
                var pageType = Type.GetType("Chapter6." + pageName);
                Page page = (Page)Activator.CreateInstance(pageType);
                await navigation.PushAsync(page);
            }
        }
    }
}
