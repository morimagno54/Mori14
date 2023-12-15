using System;
using System.Collections.Generic;
using System.Linq;

namespace Mori14
{
    public class PurchaseService
    {
        private readonly AppDbContext _context;

        public PurchaseService() => _context = App.GetContext();

        public bool Create(Purchase item)
        {
            try
            {
                _context.Purchases.Add(item);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool CreateRange(List<Purchase> items)
        {
            try { 
                _context.Purchases.AddRange(items);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Purchase> Get()
        {
            return _context.Purchases.ToList();
        }

        public List<Purchase> GetByText(string text) {
            return _context.Purchases.Where(x => x.Client.Contains(text)).ToList();
        }
    }
}
