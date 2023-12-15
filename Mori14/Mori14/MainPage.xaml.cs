using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Xamarin.Forms;

namespace Mori14
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            PurchaseService service = new PurchaseService();
            List<Purchase> purchases = new List<Purchase>();

            for (int i = 0; i < 3; i++)
                purchases.Add(new Purchase { Date = txtDate.Text, Client = txtClient.Text, Total = txtTotal.Text, Seller = txtSeller.Text });

            //service.Create(new Person { LastName = txtLastName.Text, FirstName = txtName.Text });

            service.CreateRange(purchases);

       
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            PurchaseService service = new PurchaseService();
            lvPurchases.ItemsSource = service.Get();
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            PurchaseService service = new PurchaseService();
            lvPurchases.ItemsSource = service.GetByText(txtFilter.Text.Trim());
        }
    }
}
