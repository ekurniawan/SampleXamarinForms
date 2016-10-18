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
    public partial class SampleBindingModel : ContentPage
    {
        public SampleBindingModel()
        {
            InitializeComponent();

            BindingContext = new TextCellViewModel();
        }
    }
}
