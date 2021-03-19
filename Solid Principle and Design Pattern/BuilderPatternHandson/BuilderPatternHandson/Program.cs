using System;

namespace BuilderPatternHandson
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();

            Builder b1;
            b1= new AdultBuilder();

            director.Construct(b1);

            Product p1;
            p1= b1.GetResult();

            p1.Show();
            b1 = new ChildBuilder();
            director.Construct(b1);
            p1 = b1.GetResult();
            p1.Show();


            Console.ReadLine();
        }
    }
}
