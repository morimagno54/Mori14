using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using static Xamarin.Essentials.Permissions;

namespace Mori14.ViewModels
{
    public class ViewModelPurchase : BaseViewModel
    {
        private string date;
        public string Date
        {
            get { return this.date; }
            set { SetValue(ref this.date, value); }
        }

        private string client;
        public string Client
        {
            get { return this.client; }
            set { SetValue(ref this.client, value); }
        }

        private int total;
        public int Total
        {
            get { return this.total; }
            set { SetValue(ref this.total, value); }
        }

        private string seller;
        public string Seller
        {
            get { return this.seller; }
            set { SetValue(ref this.seller, value); }
        }

        private string filter;
        public string Filter
        {
            get { return this.filter; }
            set { SetValue(ref this.filter, value); }
        }

        private List<Purchase> purchases;
        public List<Purchase> Purchases
        {
            get { return this.purchases; }
            set { SetValue(ref this.purchases, value); }
        }

        public ICommand Save { get; set; }
        public ICommand Show { get; set; }


        public ViewModelPurchase()
        {
            Show = new Command(() =>
            {
                PurchaseService service = new PurchaseService();
                Purchases = service.GetByText(Filter);
            });

            Save = new Command(() =>
            {
                PurchaseService service = new PurchaseService();
                int newCompraId = service.Get().Count + 1;
                service.Create(new Purchase
                {
                    Date = Date,
                    Client = Client,
                    Total = Total,
                    Seller = Seller
                });

                App.Current.MainPage.DisplayAlert("Success", "The data was saved correctly", "Ok");
            });
        }
    }
}
