using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Bab1.ViewModels;

namespace Bab1
{
    public partial class CustomButtonList : ContentPage
    {
        public CustomButtonList()
        {
            InitializeComponent();

            BindingContext = new CustomButtonViewModel();
        }
    }
}
