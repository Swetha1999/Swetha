using AbstractPatternHandson.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractPatternHandson.ConcreteClass
{
    public class AudiHealight:Headlight
    {
        public override void show()
        {
            Console.WriteLine("This is Audi Headlight");
        }
    }
}
