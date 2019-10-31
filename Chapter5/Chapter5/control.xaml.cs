using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Chapter5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class control : ContentPage
    {
        public control()
        {
            InitializeComponent();
        }

        void PickerSelectedIndexChanged(object sender, EventArgs e)
        {
            EventValue.Text = ThePicker.Items[ThePicker.SelectedIndex];
            PageValue.Text = ThePicker.Items[ThePicker.SelectedIndex];
        }

        void SwitchToggled(object sender, ToggledEventArgs e)
        {
            EventValue.Text = String.Format("Đang {0}", e.Value ? "Bật" : "Tắt");
            PageValue.Text = TheSwitch.IsToggled.ToString();
        }

        void SliderValueChanged(object sender, ValueChangedEventArgs e)
        {
            EventValue.Text = String.Format("Giá trị thanh trượt: {0:F1}", e.NewValue);
            PageValue.Text = TheSlider.Value.ToString();
        }


        void StepperValueChanged(object sender, ValueChangedEventArgs e)
        {
            EventValue.Text = String.Format("Giá trị bộ tăng giảm: {0:F1}", e.NewValue);
            PageValue.Text = TheStepper.Value.ToString();
        }

        
        void DatePickerDateSelected(object sender, DateChangedEventArgs e)
        {
            EventValue.Text = e.NewDate.ToString();
            PageValue.Text = TheDatePicker.Date.ToString();
        }


        private void TimePickerPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == TimePicker.TimeProperty.PropertyName)
            {
                EventValue.Text = "";
                PageValue.Text = TheTimePicker.Time.ToString();
            }
        }
    }
}