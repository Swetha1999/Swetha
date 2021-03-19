using System;

namespace FacadePatternHandson
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new ShapeMaker();
            s.drawCircle();
            s.drawRectangle();
            s.drawSquare();
            Console.ReadLine();

        }
    }
}
