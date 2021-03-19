using System;

namespace SingletonHandson
{
    class Program
    {
        static void Main(string[] args)
        {
            DBConn d = DBConn.getInstance();
            DBConn dd = DBConn.getInstance();
            Console.WriteLine(d.GetHashCode());
            Console.WriteLine(dd.GetHashCode());
            // DBConn dd = new DBConn();
            d.PrintDetail("Swe");
            dd.PrintDetail("Swetha");
            Console.ReadLine();
        }
    }
}
