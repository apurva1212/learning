using ShoppingCart.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Model
{
    class Discount
    {
        //private DiscountType discountType;
        //double discountAmount;
        //int buy;
        //int free;

        public DiscountType discountType { get; set; }
        public Double discountAmount { get; set; }
        public int buy { get; set; }
        public int free { get; set; }
        public Discount(DiscountType discountType, Double discountAmount, int buy, int free)
        {
            this.discountType = discountType;
            this.discountAmount = discountAmount;
            this.buy = buy;
            this.free = free;
        }

    }
}
