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
    public partial class DrilldownListViewByPage : ContentPage
    {
        public DrilldownListViewByPage()
        {
            InitializeComponent();
            List.ItemsSource = new ListItemPage[] {
                new ListItemPage {TieuDe = "Item 1", Loai= typeof(FirstPage)},
                new ListItemPage {TieuDe = "Item 2", Loai= typeof(SecondPage)},
                new ListItemPage {TieuDe = "Item 3", Loai= typeof(ThirdPage)}
            };
        }

        private async void ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as ListItemPage;
            if (item == null) return;
            Page page = (Page)Activator.CreateInstance(item.Loai);
            await Navigation.PushAsync(page);
            List.SelectedItem = null;
        }
    }
    public class ListItemPage
    {
        public string TieuDe { get; set; }
        public Type Loai { get; set; }
    }
}