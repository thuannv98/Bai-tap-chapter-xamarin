﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StyleExamples
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImportResourcesPage : ContentPage
    {
        public ImportResourcesPage()
        {
            InitializeComponent();
            Feedback.Text = (string)Resources["FeedbackPlaceholder"];
            Feedback.TextColor = (Color)Resources["InputPlaceholderColor"];
            Subject.Text = "";
            Resources["PageBgColor"] = Resources["PageBgColorNoSubject"];
            Resources["BtSubmitColor"] = Resources["BtInactiveColor"];
            Resources["BtCancelColor"] = Resources["BtInactiveColor"];
        }
        void HandleSubject(object sender, Xamarin.Forms.FocusEventArgs e)
        {
            if (Subject.Text == string.Empty)
            {
                Resources["PageBgColor"] = Resources["PageBgColorNoSubject"];
                Resources["BtSubmitColor"] = Resources["BtInactiveColor"];
                Resources["BtCancelColor"] = Resources["BtInactiveColor"];
            }
            else
            {
                Resources["PageBgColor"] = Resources["PageBgColorWithSubject"];
                Resources["BtSubmitColor"] = Resources["BtSubmitActiveColor"];
                Resources["BtCancelColor"] = Resources["BtCancelActiveColor"];
            }
        }
        void HandleFeedback(object sender, Xamarin.Forms.FocusEventArgs e)
        {
            var text = Feedback.Text;
            var placeHolderText = (string)Resources["FeedbackPlaceholder"];

            if (Feedback.Text == placeHolderText)
            {
                Feedback.Text = string.Empty;
                Feedback.TextColor = (Color)Resources["InputTextColor"];
                return;
            }

            if (Feedback.Text == string.Empty)
            {
                Feedback.Text = placeHolderText;
                Feedback.TextColor = (Color)Resources["InputPlaceholderColor"];
                return;
            }
        }
    }
}