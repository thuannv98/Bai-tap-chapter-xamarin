using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CSSExample
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        const string placeHolderText = "Type your message here";

        void HandleSubject(object sender, Xamarin.Forms.FocusEventArgs e)
        {

        }

        void HandleFeedback(object sender, Xamarin.Forms.FocusEventArgs e)
        {
            var text = Feedback.Text;

            if (Feedback.Text == placeHolderText)
            {
                Feedback.Text = string.Empty;
                Feedback.TextColor = Color.Navy;
                return;
            }

            if (Feedback.Text == string.Empty)
            {
                Feedback.Text = placeHolderText;
                Feedback.TextColor = Color.Silver;
                return;
            }
        }

        public MainPage()
        {
            InitializeComponent();
            Feedback.Text = placeHolderText;
            Feedback.TextColor = Color.Silver;
        }
    }
}
