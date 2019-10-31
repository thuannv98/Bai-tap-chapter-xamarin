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
    public partial class ListViewCustomWithImage : ContentPage
    {
        public ListViewCustomWithImage()
        {
            InitializeComponent();

            BindingContext = new ListViewCustomViewWithImageModel(DisplayAlert);
        }

        async void ListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            ListItem item = (ListItem)e.Item;
            await DisplayAlert("Đã chạm mục ", item.Title, "OK");
            ((ListView)sender).SelectedItem = null;
        }

        public class ListItem : BindableObject
        {
            public string Source { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public string Price { get; set; }
        }

        public class ListViewCustomViewWithImageModel : BindableObject
        {

            readonly Func<string, string, string, Task> displayAlertAction;

            List<ListItem> listItems;
            public List<ListItem> ListItems
            {
                get
                {
                    return listItems;
                }
                set
                {
                    listItems = value;
                    OnPropertyChanged("ListItems");
                }
            }

            public ListViewCustomViewWithImageModel(Func<string, string, string, Task> displayAlertAction)
            {
                this.displayAlertAction = displayAlertAction;

                ListItems = new List<ListItem> {
                    new ListItem {Source = "first.png", Title = "First", Description="Item 1", Price="1000đ"},
                    new ListItem {Source = "second.png", Title = "Second", Description="Item 2", Price="2000đ"},
                    new ListItem {Source = "third.png", Title = "Third", Description="Item 3", Price="3000đ"}
                };
            }
        }
    }
}