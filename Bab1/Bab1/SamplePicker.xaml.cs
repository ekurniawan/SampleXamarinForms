using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Bab1
{
    public partial class SamplePicker : ContentPage
    {
        public SamplePicker()
        {
            InitializeComponent();

            var options = new List<string> { "CSharp", "VB", "Java", "Phyton", "Ruby" };
            foreach(string optionName in options)
            {
                picker.Items.Add(optionName);
            }

            picker.SelectedIndexChanged += Picker_SelectedIndexChanged;
            datePicker.DateSelected += DatePicker_DateSelected;
            timePicker.PropertyChanged += TimePicker_PropertyChanged;
        }

        private void TimePicker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if(e.PropertyName==TimePicker.TimeProperty.PropertyName)
            {
                DisplayAlert("Keterangan", "Anda memilih :" + timePicker.Time.ToString(),"OK");
            }
        }

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            DisplayAlert("Keterangan", "Anda memilih :" + e.NewDate.ToString(), "OK");
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayAlert("Keterangan", "Anda memilih: " +
                picker.Items[picker.SelectedIndex], "OK");
        }
    }
}
