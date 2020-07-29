using SalesTax.TaxCalculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTax.Model
{
    class BasketItem
    {
        private Product product;
        // int quantity;
        //   Decimal SellingPrice;
        // Decimal TaxAmount;
          public List<ITaxCalculator> _taxcalculator = new List<ITaxCalculator>();

        public BasketItem() { }

        public BasketItem(Product product, int quantity) {
            this.Product = product;
            this.Quantity = quantity;
        }

        public int Quantity { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal SellingPrice { get; set; }
       // public List<ITaxCalculator> _taxcalculator { get; set; }
        public Product Product { get; set; }

        public BasketItem AddBAsicSalesTaxCalculator()
        {
            return AddTaxCalculator(new BasicSalesTaxCalculator());
        }
        //public string PrintOutput() 
        //{
        //    return String.Format("%d %s: %-2f", this.Quantity, this.Product.name);
        //}

        public BasketItem AddAllTaxCalculator()
        {
            AddImportTaxCalculator();
            AddBAsicSalesTaxCalculator();
            return this;
        }
        public BasketItem AddImportTaxCalculator()
        {
            return AddTaxCalculator(new ImportTaxCalculator());
        }
        public BasketItem AddTaxCalculator(ITaxCalculator _itaxcalculator)
        {
            this._taxcalculator.Add(_itaxcalculator);
            return this;
        }

    }
}
