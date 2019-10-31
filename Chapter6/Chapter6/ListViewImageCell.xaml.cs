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
    public partial class ListViewImageCell : ContentPage
    {
        public ListViewImageCell()
        {
            InitializeComponent();
            List<ListItem> ListItems = new List<ListItem>
            {
                new ListItem {Source = "first.png", Title = "First", Description="Item 1"},
                new ListItem {Source = "second.png", Title = "Second", Description="Item 2"},
                new ListItem {Source = "third.png", Title = "Third", Description="Item 3"}
            };
            ImageList.ItemsSource = ListItems;
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
        }
    }
}