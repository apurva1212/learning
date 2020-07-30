using ShoppingCart.Common;
using ShoppingCart.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Processor
{
    class DiscountProcessor
    { public Double getdiscountamount(Item item, Double quantity)
        {
            if (item.discount.discountType.Equals(DiscountType.PercentDiscount))
                return getpercentagediscountamount(item, quantity);
            else
                return getfreeitemdiscountamount(item, quantity);


        }
        private Double getfreeitemdiscountamount(Item item, Double quantity)
        {
            Double discount = 0;
           while(Convert.ToInt32(quantity) > item.discount.buy)
            {
                if(quantity.CompareTo(Convert.ToDouble(item.discount.buy + item.discount.free)) > 0 
                    || quantity.CompareTo(Convert.ToDouble(item.discount.buy + item.discount.free)) == 0)
                {
                   discount = discount + Convert.ToDouble(item.discount.free * item.price);
                    quantity = quantity - Convert.ToDouble(item.discount.buy + item.discount.free);
                }
            } return discount;
        }
        private Double getpercentagediscountamount(Item item, Double quantity)
        {
          Double MaxDiscountPercentage =   Math.Max(GetITemDiscount(item), 
              Math.Max(item.category.discount, item.category.parentCategory.discount));
        var f = (( item.price * quantity) * MaxDiscountPercentage) / 100;
            return Convert.ToDouble(f);
        }
        private Double GetITemDiscount(Item item)
        {
            return item.discount.discountAmount;
        }
    }
}
