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
    public partial class ListViewContextAction : ContentPage
    {
        public ListViewContextAction()
        {
            InitializeComponent();

            List<ListItem> ListItems = new List<ListItem> {
                new ListItem {Title = "First", Description="Item 1", Price="1000đ"},
                new ListItem {Title = "Second", Description="Item 2", Price="2000đ"},
                new ListItem {Title = "Third", Description="Item 3", Price="3000đ"}
            };

            ContextList.ItemsSource = ListItems;
        }

        public async void MoreClicked(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);
            var item = (ListItem)(mi.CommandParameter);
            await DisplayAlert("Thông báo", "Nút More của "+item.Title.ToString() + " đã được click", "OK");
        }

        public async void DeleteClicked(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);
            var item = (ListItem)mi.CommandParameter;
            await DisplayAlert("Thông báo", "Nút Delete của " + item.Title.ToString() + " đã được click", "OK");
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