using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace SalesTax.Model
{
 public  class Food : Product
    {
        public Food(string name, Decimal price) : base(name,price)
        {

        }

        public Food()
        { }
    }
}
