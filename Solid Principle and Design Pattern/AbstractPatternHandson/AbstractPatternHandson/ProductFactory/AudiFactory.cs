using AbstractPatternHandson.AbstractFactory;
using AbstractPatternHandson.ConcreteClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractPatternHandson.ProductFactory
{
   public  class AudiFactory:Factory
    {
        public override Headlight makeHeadlight()
        {
            return new AudiHealight();
        }
        public override Tire makeTire()
        {
            return new AudiTire();
        }
    }
}
