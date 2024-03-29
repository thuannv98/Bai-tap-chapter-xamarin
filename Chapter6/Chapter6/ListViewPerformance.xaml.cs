﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Chapter6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPerformance : ContentPage
    {
        public ListViewPerformance()
        {
            InitializeComponent();

            BindingContext = new ListViewPerformanceViewModel();
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

        public class ListViewPerformanceViewModel : BindableObject
        {
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

            public ListViewPerformanceViewModel()
            {
                ListItems = Enumerable.Range(1, 500)
                    .Select(index => new ListItem { Source = "first.png", Title = index.ToString(), Description = "item số " + index.ToString(), Price = index.ToString() + "000 VNĐ" })
                    .ToList();
            }
        }
    }
}