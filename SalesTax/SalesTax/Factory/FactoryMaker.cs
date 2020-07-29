using System;
using System.Collections.Generic;
using System.Text;
using SalesTax.Common;

namespace SalesTax.Factory
{
   public class FactoryMaker
    {
        private static ProductFactory productFactory = null;
      static  Dictionary<string, ProductFactory> _dictProductFactory = new Dictionary<string, ProductFactory>();
        
        private static Dictionary<string,ProductFactory> FillDictionary()
        {
            
            _dictProductFactory.Add(Consts.book,BookFactory.GetInstance());
            _dictProductFactory.Add(Consts.chocolate, FoodFactory.GetInstance());
            _dictProductFactory.Add(Consts.pills, MedicalFactory.GetInstance());
            _dictProductFactory.Add(Consts.misc, MiscellaneousFactory.GetInstance());
            return _dictProductFactory;
        }





        public static ProductFactory GetFactory(string ProductType)
        { if(_dictProductFactory.Count==0)
            FillDictionary();
            productFactory = _dictProductFactory[ProductType];
            return productFactory;
                
        }
    }
}
