using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Bab1.Models;

namespace Bab1.ViewModels
{
    public class ImageCellViewModel : BindableObject
    {
        private List<ListItem> lstItems;
        public List<ListItem> ListItems
        {
            get { return lstItems; }
            set { lstItems = value; OnPropertyChanged("ListItems"); }
        }

        public ImageCellViewModel()
        {
            lstItems = new List<ListItem>
            {
                new ListItem { Gambar="actual.png", Title="Xamarin Forms",
                Description ="Tools untuk membuat aplikasi cross platform" },
                new ListItem { Gambar="icon.pgn", Title="Xamarin for Android",
                Description="Framework untuk membangun aplikasi Android dengan CSharp"},
                new ListItem { Gambar="actual.png", Title="Xamarin for IOS",
                Description="Framework untuk membangun aplikasi IOS dengan CSharp"}
            };
        }
    }
}
