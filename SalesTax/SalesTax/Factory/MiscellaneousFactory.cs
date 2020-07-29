
using SalesTax.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTax.Factory
{
    public class MiscellaneousFactory : ProductFactory
    {
        private static MiscellaneousFactory Instance = new MiscellaneousFactory();
        public static MiscellaneousFactory GetInstance()
        {
            return Instance;
        }
        public override Product createProduct(string name, decimal price)
        {
            return new Miscellaneous(name, price);
        }
    }
}