using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Bab1
{
    public partial class NavigationPage2 : ContentPage
    {
        public NavigationPage2()
        {
            InitializeComponent();

            btnKembali.Clicked += BtnKembali_Clicked;
        }

        private async void BtnKembali_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
