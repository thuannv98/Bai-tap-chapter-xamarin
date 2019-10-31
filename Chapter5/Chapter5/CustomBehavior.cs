using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Chapter5
{
    public class CustomBehavior : Behavior<Entry>
    {
        protected override void OnAttachedTo(Entry bindable)
        {
            bindable.TextChanged += NumberValidation;
            base.OnAttachedTo(bindable);
        }
        protected override void OnDetachingFrom(Entry bindable)
        {

            base.OnDetachingFrom(bindable);
        }

        void NumberValidation(object sender, TextChangedEventArgs args)
        {
            int result;
            bool isValid = int.TryParse(args.NewTextValue, out result);
            ((Entry)sender).TextColor = isValid ? Color.Green : Color.Red;
        }
    }
}
