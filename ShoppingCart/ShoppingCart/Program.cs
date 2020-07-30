using ShoppingCart.Model;
using System;
using System.Collections.Generic;

namespace ShoppingCart
{
    class Program
    {
      static  Dictionary<string, Item> dictitem = new Dictionary<string, Item>();
        static void Main(string[] args)
        {

            init();
            IndividualItemInVoice appleinvoice = new IndividualItemInVoice(dictitem["Apple"], 6);
            IndividualItemInVoice orangerinvoice = new IndividualItemInVoice(dictitem["Orange"], 2);
            IndividualItemInVoice potatoinvoice = new IndividualItemInVoice(dictitem["Potato"], 14);

            IndividualItemInVoice tomatoinvoice = new IndividualItemInVoice(dictitem["Tomato"], 3);
            IndividualItemInVoice cowmilkinvoice = new IndividualItemInVoice(dictitem["Cowmilk"], 8);
            IndividualItemInVoice goudainvoice = new IndividualItemInVoice(dictitem["Gouda"], 2);

            List<IndividualItemInVoice> invlicelist = new List<IndividualItemInVoice>();
            invlicelist.Add(appleinvoice);
            invlicelist.Add(orangerinvoice);
            invlicelist.Add(potatoinvoice);

            invlicelist.Add(tomatoinvoice);
            invlicelist.Add(cowmilkinvoice);
            invlicelist.Add(goudainvoice);

            Invoice invoice = new Invoice(invlicelist,"Anish Kumar");

            Console.WriteLine("Customer Name: " + invoice.customername);
            Console.WriteLine("Item" + "Quantity" + "Amount");


            foreach(IndividualItemInVoice invoice1 in invlicelist)
            {
                Console.WriteLine(invoice1.item.name + invoice1.item.quantity + invoice1.totalamount);
            }
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("TotalAmount : " + invoice.TotalInvoiceAMount);
            Console.WriteLine("You saved: " + invoice.TotalInvoiceDiscountAMount);

        }

        private static void init()
        {
            Category produce = new Category();
            produce.name = "Produce";
            produce.discount = 10;

            Category fruits = new Category();
            fruits.name = "Fruits";
            fruits.discount = 18;
            fruits.parentCategory = produce;

            Category veg = new Category();
            veg.name = "Veg";
            veg.parentCategory = produce;
            produce.discount = 5;

            Category diary = new Category();
            diary.name = "Diary";
            diary.discount = 15;

            Category cheesse = new Category();
            cheesse.name = "Cheese";
            cheesse.parentCategory = diary;
            cheesse.discount = 20;

            Category Milk = new Category();
            Milk.name = "Milk";
            Milk.parentCategory = diary;
            Milk.discount = 20;

            Item apple = new Item();
            apple.name = "Apple";
            apple.category = fruits;
            apple.price = 50;
            apple.measurement = Common.MeasurementUnit.Kilo;
            apple.discount = new Discount(Common.DiscountType.FreeItemDiscount, 0, 3, 1);


            Item orange = new Item();
            orange.name = "orange";
            orange.category = fruits;
            orange.price = 80;
            orange.measurement = Common.MeasurementUnit.Kilo;
            orange.discount = new Discount(Common.DiscountType.PercentDiscount, 20,0,0);

            Item potato = new Item();
            potato.name = "potato";
            potato.category = veg;
            potato.price = 30;
            potato.measurement = Common.MeasurementUnit.Kilo;
            potato.discount = new Discount(Common.DiscountType.FreeItemDiscount, 0, 5, 2);

            Item tomato = new Item();
            tomato.name = "tomato";
            tomato.category = veg;
            tomato.price = 70;
            tomato.measurement = Common.MeasurementUnit.Kilo;
            tomato.discount = new Discount(Common.DiscountType.PercentDiscount, 10,0,0);

            Item cowmilk = new Item();
            cowmilk.name = "cowmilk";
            cowmilk.category = Milk;
            cowmilk.price = 50;
            cowmilk.measurement = Common.MeasurementUnit.Litre;
            cowmilk.discount = new Discount(Common.DiscountType.FreeItemDiscount, 0, 3, 1);

            Item soyamilk = new Item();
            soyamilk.name = "soyamilk";
            soyamilk.category = Milk;
            soyamilk.price = 40;
            soyamilk.measurement = Common.MeasurementUnit.Litre;
            soyamilk.discount = new Discount(Common.DiscountType.PercentDiscount, 10, 0,0);


            Item cheddar = new Item();
            cheddar.name = "soyamilk";
            cheddar.category = cheesse;
            cheddar.price = 50;
            cheddar.measurement = Common.MeasurementUnit.Kilo;
            cheddar.discount = new Discount(Common.DiscountType.FreeItemDiscount, 0,2,1);


            Item gouda = new Item();
            gouda.name = "soyamilk";
            gouda.category = cheesse;
            gouda.price = 80;
            gouda.measurement = Common.MeasurementUnit.Kilo;
            gouda.discount = new Discount(Common.DiscountType.PercentDiscount, 10, 0, 0);
            dictitem.Add("Apple",apple);
            dictitem.Add("Orange", orange);
            dictitem.Add("Potato", potato);
            dictitem.Add("Tomato", tomato);
            dictitem.Add("Cowmilk", cowmilk);
            dictitem.Add("SoyaMilk", soyamilk);
            dictitem.Add("Cheddar", cheddar);
            dictitem.Add("Gouda", gouda);
        }
    }
}
