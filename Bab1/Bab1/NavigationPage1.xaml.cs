﻿using System;
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

        async void Navigate(object sender, EventArgs args)
        {
            string type = (string)((ToolbarItem)sender).CommandParameter;
            Type pageType = Type.GetType("Bab1." + type + ",Bab1");
            Page page = (Page)Activator.CreateInstance(pageType);
            await this.Navigation.PushAsync(page);
        }

        private async void BtnHal2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage2());
        }
    }
}
