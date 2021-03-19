using AbstractPatternHandson.AbstractFactory;
using AbstractPatternHandson.ConcreteClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractPatternHandson.ProductFactory
{
    public class MercedesFactory:Factory
    {
        public override Headlight makeHeadlight()
        {
            return new MercedesHeadlight();
        }
        public override Tire makeTire()
        {
            return new MercedesTire();
        }
    }
}
