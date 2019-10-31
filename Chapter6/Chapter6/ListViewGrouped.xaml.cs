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
    public partial class ListViewGrouped : ContentPage
    {
        public ListViewGrouped()
        {
            List<Group> itemsGrouped;
            InitializeComponent();
            itemsGrouped = new List<Group> {
                new Group("Nhóm 1", new List<ListItem>
                {
                    new ListItem {Title = "First", Description="Item 1"},
                    new ListItem {Title = "Second", Description="Item 2"}
                }),
                new Group("Nhóm 2", new List<ListItem>
                {
                    new ListItem {Title = "Third", Description="Item 3"}
                })
            };
            GroupedList.ItemsSource = itemsGrouped;
        }

        public class Group : List<ListItem>
        {
            public string Key
            {
                get;
                private set;
            }

            public Group(string key, List<ListItem> listItems)
            {
                Key = key;
                foreach (var item in listItems)
                    this.Add(item);
            }
        }

        public class ListItem
        {
            public string Title { get; set; }
            public string Description { get; set; }
        }
    }
}