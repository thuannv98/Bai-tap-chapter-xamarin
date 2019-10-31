using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Chapter6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewStrings : ContentPage
    {
        public ListViewStrings()
        {
            InitializeComponent();
            List<string> Items = new List<string>
            {
                "First",
                "Second",
                "Third"
            };

            BindingContext = Items;
        }

        async void ListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            string item = (string)e.Item;
            await DisplayAlert("Đã chạm mục ", item, "OK");
            ((ListView)sender).SelectedItem = null;
        }

        async void ListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            string item = (string)e.SelectedItem;
            await DisplayAlert("Đã chọn mục ", item, "OK");
        }
    }
}