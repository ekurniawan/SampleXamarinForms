using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Bab1.ViewModels;
using Bab1.Models;

namespace Bab1
{
    public partial class ImageCellListBinding : ContentPage
    {
        public ImageCellListBinding()
        {
            InitializeComponent();
            BindingContext = new ImageCellViewModel();

            listView.ItemTapped += ListView_ItemTapped;
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            ListItem item = (ListItem)e.Item;
            await DisplayAlert("Keterangan","Anda memilih : "+item.Title,"OK");

            ((ListView)sender).SelectedItem = null;
        }
    }
}
