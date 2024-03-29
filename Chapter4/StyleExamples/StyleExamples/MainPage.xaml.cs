﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StyleExamples
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            string[] myPageNames = { "Feedback Page", "Local Design", "Static Resources", "Dynamic Resources", "Explicit Styles", "Implicit Styles", "Overriding Styles", "Static Style Inheritance", "Dynamic Style Inheritance", "Import Resources", "Styled Feedback Page", "Light Theme", "Dark Theme", "Device Styles", "Custom Dark Theme" };
            examples.ItemsSource = myPageNames;

            examples.ItemTapped += (sender, e) =>
            {
                ContentPage gotoPage;
                switch (e.Item.ToString())
                {
                    case "Feedback Page":
                        gotoPage = new FeedbackPage();
                        break;
                    case "Local Design":
                        gotoPage = new LocalDesignPage();
                        break;
                    case "Static Resources":
                        gotoPage = new StaticResourcesPage();
                        break;
                    case "Dynamic Resources":
                        gotoPage = new DynamicResourcesPage();
                        break;
                    case "Import Resources":
                        gotoPage = new ImportResourcesPage();
                        break;
                    case "Explicit Styles":
                        gotoPage = new ExplicitStylePage();
                        break;
                    case "Implicit Styles":
                        gotoPage = new ImplicitStylePage();
                        break;
                    case "Overriding Styles":
                        gotoPage = new OverridingStylesPage();
                        break;
                    case "Static Style Inheritance":
                        gotoPage = new ButtonStylesWithStaticInheritancePage();
                        break;
                    case "Dynamic Style Inheritance":
                        gotoPage = new ButtonStylesWithDynamicInheritancePage();
                        break;
                    case "Styled Feedback Page":
                        gotoPage = new StylesPage();
                        break;
                    case "Light Theme":
                        gotoPage = new LightThemePage();
                        break;
                    case "Dark Theme":
                        gotoPage = new DarkThemePage();
                        break;
                    case "Device Styles":
                        gotoPage = new DeviceStylesPage();
                        break;
                    case "Custom Dark Theme":
                        gotoPage = new CustomDarkThemePage();
                        break;
                    default:
                        gotoPage = new FeedbackPage();
                        break;
                }
                Navigation.PushAsync(gotoPage);
            };
        }
    }
}
