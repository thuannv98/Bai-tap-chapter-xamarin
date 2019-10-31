using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Chapter5
{
    public class PasswordValidationTriggerAction : TriggerAction<Entry>
    {
        protected override void Invoke(Entry entry)
        {
            if (entry.Text.Length > 0)
            {
                entry.BackgroundColor = Color.Red;
            }
            else
            {
                entry.BackgroundColor = Color.Gray;
            }
        }
    }
}
