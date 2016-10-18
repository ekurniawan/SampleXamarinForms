using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Bab1
{
    public partial class BindingListString : ContentPage
    {
        public BindingListString()
        {
            InitializeComponent();

            List<string> lstItems = 
                new List<string> { "CSharp", "ASP.NET Core", "ASP.NET MVC", "Phyton" };
            listView.ItemsSource = lstItems;

            listView.ItemTapped += ListView_ItemTapped;
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            await DisplayAlert("Keterangan", "Anda memilih data: " + e.Item.ToString(),
                "OK");
            ((ListView)sender).SelectedItem = null;
        }


    }
}
