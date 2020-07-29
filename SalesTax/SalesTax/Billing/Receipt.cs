using SalesTax.Model;
using SalesTax.TaxCalculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTax.Billing
{
    class Receipt
    {
        private List<BasketItem> basketItems = new List<BasketItem>();

        private Decimal totalTax = Decimal.Zero;
        private Decimal totalAmount = Decimal.Zero;

        public decimal TotalTax { get => totalTax; set => totalTax = value; }
        public decimal TotalAmount { get => totalAmount; set => totalAmount = value; }
        internal List<BasketItem> BasketItems { get => basketItems; set => basketItems = value; }

        public void generateReceipt()
        {
            foreach(BasketItem item in basketItems)
            {
                Decimal taxAmount = Decimal.Zero;
                foreach(ITaxCalculator taxcalculator in item._taxcalculator)
                {
                    taxAmount = taxAmount + taxcalculator.calculateTax(item.Product.price);
                }
                Decimal qty = item.Quantity;
                item.SellingPrice = item.Product.price + taxAmount * qty;
                item.TaxAmount = taxAmount * qty;
                Console.WriteLine(item.Quantity + " " + item.Product.name + " " + item.SellingPrice);
                totalTax = totalTax + item.TaxAmount;
                totalAmount = totalAmount + item.SellingPrice;
            }
            Console.WriteLine("Sales Taxes: " + totalTax);
            Console.WriteLine("Total: " + totalAmount);
        }
    }
}
