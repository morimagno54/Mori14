using System;
using System.Collections.Generic;
using System.Text;

namespace Mori14
{
    public class Purchase
    {
        public int PurchaseID { get; set; }
        public string Date { get; set; }
        public string Client { get; set; }
        public int Total { get; set; }
        public string Seller { get; set; }
    }
}
