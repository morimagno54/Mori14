using Mori14.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mori14.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PurchaseView : ContentPage
    {
        public PurchaseView()
        {
            InitializeComponent();
            this.BindingContext = new ViewModelPurchase();
        }
    }
}