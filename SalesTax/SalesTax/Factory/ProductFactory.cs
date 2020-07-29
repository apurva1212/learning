using SalesTax.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTax.Factory
{
  public abstract  class ProductFactory
    {
        public abstract Product createProduct(string name, Decimal price);
    }
}
