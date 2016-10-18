using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Bab1.Models
{
    public class ListItemWithButton : BindableObject
    {
        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; OnPropertyChanged("Title"); }
        }

        private string description;
        public string Description
        {
            get { return description; }
            set { description = value; OnPropertyChanged("Description"); }
        }

        private decimal price;
        public decimal Price
        {
            get { return price; }
            set { price = value; OnPropertyChanged("Price"); }
        }

        private bool isApprove;
        public bool IsApprove
        {
            get { return isApprove; }
            set { isApprove = value; OnPropertyChanged("IsApprove"); }
        }



        private Command buyCommand;
        public Command BuyCommand
        {
            get { return buyCommand; }
            set { buyCommand = value; OnPropertyChanged("BuyCommand"); }
        }

        private Command sellCommand;
        public Command SellCommand
        {
            get { return sellCommand; }
            set { sellCommand = value; OnPropertyChanged("SellCommand"); }
        }

        public ListItemWithButton()
        {
            BuyCommand = new Command(BuyRequested);
            SellCommand = new Command(SellRequested);
        }

        void SellRequested()
        {
            MessagingCenter.Send<ListItemWithButton>(this, "SellRequested");
        }

        void BuyRequested()
        {
            MessagingCenter.Send<ListItemWithButton>(this, "BuyRequested");
        }


    }
}
