using ShoppingCart.Processor;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Model
{
    class Invoice
    {
        public List<IndividualItemInVoice> iteminvoices { get; set; }

        public string customername { get; set; }

        public Double TotalInvoiceAMount { get; set; }

        public Double TotalInvoiceDiscountAMount { get; set; }

        InvoiceProcessor invoiceProcessor = new InvoiceProcessor();

        public Invoice(List<IndividualItemInVoice> iteminvoices, string customername)
        {
            this.iteminvoices = iteminvoices;
            this.customername = customername;
            this.TotalInvoiceAMount = invoiceProcessor.gettotalinvoiceamount(iteminvoices);
            this.TotalInvoiceDiscountAMount = invoiceProcessor.gettotalinvlicediscountamount(iteminvoices);
        }
    }
}
