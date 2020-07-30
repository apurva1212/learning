using ShoppingCart.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Model
{
    class Item
    {
        public string name { get; set; }
        public Double price { get; set; }
        public MeasurementUnit measurement{ get; set; }
        public Category category { get; set; }
        public Discount discount { get; set; }

        public Double quantity { get; set; }
    }
}
