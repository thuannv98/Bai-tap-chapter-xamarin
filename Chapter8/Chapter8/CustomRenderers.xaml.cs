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
    public partial class CustomRenderers : ContentPage
    {
        public CustomRenderers()
        {
            InitializeComponent();
        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            DisplayAlert("Thông báo", "Đây là một Button tùy chỉnh của riêng bạn", "OK");
        }
    }
}