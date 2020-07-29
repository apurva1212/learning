using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace SalesTax.Model
{
  public  class Book : Product
    {
      public  Book(string name, Decimal price) : base(name,price)
        {

        }

        public Book() { }
    }
}
