﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Chapter8
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomButton : Button
    {
        public CustomButton()
        {
            InitializeComponent();
        }
    }
}