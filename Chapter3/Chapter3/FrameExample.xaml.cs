﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Chapter3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FrameExample : ContentPage
    {
        public FrameExample()
        {
            InitializeComponent();
        }
    }
}