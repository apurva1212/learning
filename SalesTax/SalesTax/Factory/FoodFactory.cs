using SalesTax.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTax.Factory
{
    public class FoodFactory : ProductFactory
    {
        private static FoodFactory Instance = new FoodFactory();
        public static FoodFactory GetInstance()
        {
            return Instance;
        }
        public override Product createProduct(string name, decimal price)
        {
            return new Food(name, price);
        }
    }
}
