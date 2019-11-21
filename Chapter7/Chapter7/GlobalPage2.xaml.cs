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
    public partial class GlobalPage2 : ContentPage
    {
        String Data;

        public GlobalPage2()
        {
            InitializeComponent();
            Data = Global.Instance.myData.ToString();
            this.BindingContext = this;
        }
    }
}