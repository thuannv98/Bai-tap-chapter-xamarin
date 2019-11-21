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
    public partial class DrilldownListViewByItem : ContentPage
    {
        public DrilldownListViewByItem()
        {
            InitializeComponent();
            List.ItemsSource = new ListItem[] {
                new ListItem {TieuDe = "Item1", MoTa="Item 1"},
                new ListItem {TieuDe = "Item2", MoTa="Item 2"},
                new ListItem {TieuDe = "Item3", MoTa="Item 3"}
            };
        }

        private async void ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as ListItem;
            if (item == null) return;
            await Navigation.PushAsync(new DetailPage(item));
            List.SelectedItem = null;
        }
    }



    public class ListItem
    {
        public string TieuDe { get; set; }
        public string MoTa { get; set; }
    }
}