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
    public partial class PopupMenu : ContentPage
    {
        public PopupMenu()
        {
            InitializeComponent();
        }

        private async void ShowMenu(object sender, EventArgs e)
        {
            String action = await DisplayActionSheet("Options", "Cancel", null, "Here", "There", "Everywhere");
            Message.Text = "Lựa chọn :" + action;
        }
    }
}