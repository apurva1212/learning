using SalesTax.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTax.Factory
{
    public class MedicalFactory : ProductFactory
    {
        private static MedicalFactory Instance = new MedicalFactory();
        public static MedicalFactory GetInstance()
        {
            return Instance;
        }
        public override Product createProduct(string name, decimal price)
        {
            return new Medical(name, price);
        }
    }
}