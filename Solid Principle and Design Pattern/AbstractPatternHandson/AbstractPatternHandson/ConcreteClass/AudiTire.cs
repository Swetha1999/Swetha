using AbstractPatternHandson.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractPatternHandson.ConcreteClass
{
    public class AudiTire:Tire
    {
        public override void show()
        {
            Console.WriteLine("This is Audi Tire");
        }

    }
}
