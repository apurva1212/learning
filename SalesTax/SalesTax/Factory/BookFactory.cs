using SalesTax.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTax.Factory
{
    public class BookFactory : ProductFactory
    {
        private static BookFactory Instance = new BookFactory();
        public static BookFactory GetInstance()
        {
            return Instance;
        }
        public override Product createProduct(string name, decimal price)
        {
            return new Book(name, price);
        }
    }
}
