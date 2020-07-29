using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace SalesTax.Model
{
   public class Product
    {
      public  string name
        { get; set; }
        public Decimal price { get; set; }

        public Product(string name, Decimal price)
        {
            this.name = name;
            this.price = price;
        }

        public Product()
        { }
    }
}
