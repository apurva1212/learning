using ShoppingCart.Processor;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Model
{
    class IndividualItemInVoice
    {
        public Item item { get; set; }
        public Double quantity { get; set; }
        public Double totalamount { get; set; }
        public Double discountAmount  { get; set; }

        private DiscountProcessor discountProcessor = new DiscountProcessor();

        public IndividualItemInVoice(Item item, Double quantity)
        {
            this.item = item;
            this.quantity = quantity;

            this.discountAmount = discountProcessor.getdiscountamount(item,quantity);
            this.totalamount = item.price * quantity - this.discountAmount;


        }
    }
}
    