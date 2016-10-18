using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Bab1.Models;

namespace Bab1.ViewModels
{
    public class CustomCellViewModel : BindableObject
    {
        private List<ListItem> lstItems;
        public List<ListItem> ListItems
        {
            get { return lstItems; }
            set { lstItems = value; OnPropertyChanged("ListItems"); }
        }

        public CustomCellViewModel()
        {
            lstItems = new List<ListItem>
            {
                new ListItem { Price=200, Title="Xamarin Forms",
                    Description ="Tools untuk membuat aplikasi cross platform" },
                new ListItem { Price=300, Title="Xamarin for Android",
                Description="Framework untuk membangun aplikasi Android dengan CSharp"},
                new ListItem { Price=400, Title="Xamarin for IOS",
                Description="Framework untuk membangun aplikasi IOS dengan CSharp"}
            };
        }
    }
}
