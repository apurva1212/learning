using SalesTax.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTax.Billing
{
    class Basket
    {
        public List<BasketItem> basketItems = new List<BasketItem>();

        public void add(BasketItem basketItem)
        {
            basketItems.Add(basketItem);
        }
        public List<BasketItem> getItemsList()
        {
            return basketItems;
        }
        public void checkout()
        {
            Receipt rp = new Receipt();
            rp.BasketItems = basketItems;
            rp.generateReceipt();
        }

    }
}
