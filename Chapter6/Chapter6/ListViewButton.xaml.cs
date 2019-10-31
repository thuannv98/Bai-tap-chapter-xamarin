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
    public partial class ListViewButton : ContentPage
    {
        public ListViewButton()
        {
            InitializeComponent();

            List<ListItem> ListItems = new List<ListItem> {
                new ListItem {Title = "First", Description="Item 1", Price="1000đ"},
                new ListItem {Title = "Second", Description="Item 2", Price="2000đ"},
                new ListItem {Title = "Third", Description="Item 3", Price="3000đ"}
            };
            ButtonList.ItemsSource = ListItems;
        }

        public async void mua(object sender, EventArgs e)
        {
            var b = (Button)sender;
            var item = (ListItem)b.CommandParameter;
            await DisplayAlert("Thông báo", item.Title.ToString() + " đã được chọn", "OK");
        }

        public class ListItem
        {
            public string Title { get; set; }
            public string Description { get; set; }
            public string Price { get; set; }
        }
    }
}