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
    public partial class ListViewCustom : ContentPage
    {
        public ListViewCustom()
        {
            InitializeComponent();
            List<ListItem> ListItems = new List<ListItem>
            {
                new ListItem {Title = "First", Description="Item 1", Price="1000đ"},
                new ListItem {Title = "Second", Description="Item 2", Price="2000đ"},
                new ListItem {Title = "Third", Description="Item 3", Price="3000đ"}
            };
            CustomList.ItemsSource = ListItems;
        }

        async void ListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            ListItem item = (ListItem)e.Item;
            await DisplayAlert("Đã chạm mục ", item.Title, "OK");
            ((ListView)sender).SelectedItem = null;
        }

        public class ListItem
        {
            public string Source { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public string Price { get; set; }
        }
    }
}