using System;

namespace FinalCaseStudyAbstractPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductFactory productFactory=new EcommerceFactory();
            Client client = new Client(productFactory);
            Console.WriteLine("List of channel:\n 1.Ecommerce\n2.Tele Caller ");
            Console.WriteLine("List of product:\n 1.Electronic \n2.Furniture\n 3.Toys");
            Console.WriteLine("Enter channel");
            string c = Console.ReadLine();
            Console.WriteLine("Enter product");
            string p = Console.ReadLine();
            Console.WriteLine("------Processing Order-------");
            client.getChannelName(p, c);
            Console.ReadLine();
        }
    }
}
