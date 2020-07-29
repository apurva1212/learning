using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTax.Common
{
   public class Consts
    {
        private Consts() { }

        public static readonly int round_factor = 20;

        public static readonly string book = "book";

        public static readonly string chocolate = "chocolate";

        public static readonly string pills = "pills";

        public static readonly string music = "music";

        public static readonly string perfume = "perfume";

        public static readonly string misc = "misc";
        public static readonly string imported = "imported";
        public static readonly Decimal NOTAX = 0;
        public static readonly Decimal BASICSALESTAX = Convert.ToDecimal(0.10);
        public static readonly Decimal IMPORTDUTYTAX = Convert.ToDecimal(0.05);
    }
}
