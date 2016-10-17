using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Bab1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            btnSubmit.Clicked += BtnSubmit_Clicked;

            btnTambah.Clicked += BtnAritmatik_Clicked;
            btnKurang.Clicked += BtnAritmatik_Clicked;
            btnKali.Clicked += BtnAritmatik_Clicked;
        }

        private void BtnAritmatik_Clicked(object sender, EventArgs e)
        {
            int bil1 = Convert.ToInt32(entryBil1.Text);
            int bil2 = Convert.ToInt32(entryBil2.Text);
            int hasil;

            var strTombol = ((Button)sender).Text;

            if (strTombol=="Tambah")
            {
                hasil = bil1 + bil2;
            }
            else if(strTombol=="Kurang")
            {
                hasil = bil1 - bil2;
            }
            else
            {
                hasil = bil1 * bil2;
            }

            DisplayAlert("Hasil", hasil.ToString(), "OK");
        }

        private void BtnSubmit_Clicked(object sender, EventArgs e)
        {
            lblNama.Text = entryNama.Text;
        }

        private void BtnDisplay_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Keterangan", entryNama.Text, "OK");
        }
    }
}
