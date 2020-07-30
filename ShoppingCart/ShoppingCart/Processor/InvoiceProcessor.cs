using ShoppingCart.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Processor
{
    class InvoiceProcessor
    {
        public Double gettotalinvoiceamount(List<IndividualItemInVoice> individualItemInvoices)
        {
            Double sum = 0;
            foreach(IndividualItemInVoice invoice in individualItemInvoices)
            {
                sum = sum + Convert.ToDouble(invoice.totalamount);
            }
            return sum;
        }

        public Double gettotalinvlicediscountamount(List<IndividualItemInVoice> individualItemInvoices)
        {
            Double sum = 0;
            foreach (IndividualItemInVoice invoice in individualItemInvoices)
            {
                sum = sum + Convert.ToDouble(invoice.discountAmount);
            }
            return sum;
        }
    }
}
