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
    public partial class TabPageDatabound : TabbedPage
    {
        public TabPageDatabound()
        {
            InitializeComponent();
            this.ItemsSource = new TabItem[] {
                new TabItem ("Item 1", 1),
                new TabItem ("Item 2", 2),
                new TabItem ("Item 3", 3),
                new TabItem ("Item 4", 4),
                new TabItem ("Item 5", 5),
                new TabItem ("Item 6", 6)
            };
        }
    }

    class TabItem
    {
        public string Name { private set; get; }
        public int Number { private set; get; }

        public TabItem(string name, int number)
        {
            this.Name = name;
            this.Number = number;
        }
    }
}