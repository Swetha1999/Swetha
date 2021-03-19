using AbstractPatternHandson.ProductFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractPatternHandson.AbstractFactory
{
   public  class Factorgetter
    {
        public Factory GetFactory(string name)
        {
            if (name == "Audi")
            {
                return new AudiFactory();
            }
            if(name=="Mercedes") {
                return new MercedesFactory();
            }

            return null;     
            
        }
    }
}
