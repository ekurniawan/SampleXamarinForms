using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Bab1.Models;

namespace Bab1.ViewModels
{
    public class CustomButtonViewModel : BindableObject
    {
        private List<ListItemWithButton> lstItems;
        public List<ListItemWithButton> ListItems
        {
            get { return lstItems; }
            set { lstItems = value; OnPropertyChanged("ListItems"); }
        }

        public CustomButtonViewModel()
        {
            lstItems = new List<ListItemWithButton>
            {
                new ListItemWithButton { IsApprove=false, Price=200, Title="Xamarin Forms",
                    Description ="Tools untuk membuat aplikasi cross platform" },
                new ListItemWithButton {IsApprove=false, Price=300, Title="Xamarin for Android",
                Description="Framework untuk membangun aplikasi Android dengan CSharp"},
                new ListItemWithButton {IsApprove=false, Price=400, Title="Xamarin for IOS",
                Description="Framework untuk membangun aplikasi IOS dengan CSharp"}
            };

            MessagingCenter.Subscribe<ListItemWithButton>(this, "BuyRequested", BuyRequested);
            MessagingCenter.Subscribe<ListItemWithButton>(this, "SellRequested", SellRequested);
        }

        private void SellRequested(ListItemWithButton obj)
        {
            obj.IsApprove = false;
        }

        private void BuyRequested(ListItemWithButton obj)
        {
            obj.IsApprove = true;
        }
    }
}
