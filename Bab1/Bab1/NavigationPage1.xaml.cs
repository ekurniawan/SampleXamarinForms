using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Bab1
{
    public partial class NavigationPage1 : ContentPage
    {
        public NavigationPage1()
        {
            InitializeComponent();

            btnHal2.Clicked += BtnHal2_Clicked;
        }

        private async void BtnHal2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage2());
        }
    }
}
