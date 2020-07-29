using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace SalesTax.Model
{
  public  class Medical : Product
    {
     public   Medical(string name, Decimal price) : base(name, price)
        {

        }
        public Medical()
        {

        }
    }
}
