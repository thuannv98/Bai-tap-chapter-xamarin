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
    public partial class Springboard : ContentPage
    {
        public Springboard()
        {
            InitializeComponent();

            var tapFirst = new TapGestureRecognizer();
            var tapSecond = new TapGestureRecognizer();
            var tapThird = new TapGestureRecognizer();

            tapFirst.Tapped += async (s, e) =>
            {
                await this.Navigation.PushAsync(new FirstPage());
            };

            tapSecond.Tapped += async (s, e) =>
            {
                await this.Navigation.PushAsync(new SecondPage());
            };

            tapThird.Tapped += async (s, e) =>
            {
                await this.Navigation.PushAsync(new ThirdPage());
            };

            FirstImage.GestureRecognizers.Add(tapFirst);
            SecondImage.GestureRecognizers.Add(tapSecond);
            ThirdImage.GestureRecognizers.Add(tapThird);
        }
    }
}