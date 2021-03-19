using AbstractPatternHandson.AbstractFactory;
using AbstractPatternHandson.ProductFactory;
using System;

namespace AbstractPatternHandson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the factor  type:");
            Factorgetter f = new Factorgetter();
            Factory factory;
            factory=f.GetFactory(Console.ReadLine()) ;
            Headlight a;
            a= factory.makeHeadlight();
            Tire b;
            b= factory.makeTire();
            a.show();
            b.show();
            Console.ReadLine();
        }
    }
}
