using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Model
{
    class Category
    {
       // private Category parentCategory;
       // private String name;
       //private double discount;

        public Category parentCategory { get; set; }

        public string name { get; set; }

        public Double discount { get; set; }
    }
}
