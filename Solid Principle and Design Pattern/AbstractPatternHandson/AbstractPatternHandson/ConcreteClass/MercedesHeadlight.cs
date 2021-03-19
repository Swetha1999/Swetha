using AbstractPatternHandson.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractPatternHandson.ConcreteClass
{
    public class MercedesHeadlight:Headlight
    {
        public override void show()
        {
            Console.WriteLine("This is Mercedes Headlight");
        }
    }
}
