using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTax.Exception
{
    [Serializable]
    public class SalesTaxException : SystemException
    {
        public SalesTaxException(string message) : base(message)
        {
        }

        public SalesTaxException() : base()
        {
        }
    }
}
