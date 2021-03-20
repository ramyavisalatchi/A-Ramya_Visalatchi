using System;

namespace FinalAbstractCaseStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            OredrFactory fact = new ConcreteOrderFactory();
            Client client = new Client(fact);
            client.BuildElectronicOrder(Channel.Ecommerce);
            Console.WriteLine("\n");
            client.BuildFurnitureOrder(Channel.Ecommerce);
            Console.WriteLine("\n");
            client.BuildToyOrder(Channel.Ecommerce);
            Console.WriteLine("\n");
            Console.ReadKey();
        }
    }
}
