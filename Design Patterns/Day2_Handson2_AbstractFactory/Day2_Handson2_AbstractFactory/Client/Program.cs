using Day2_Handson2_AbstractFactory.AbstractFactory;
using Day2_Handson2_AbstractFactory.Client;
using System;

namespace Day2_Handson2_AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("Enter a car Type ( Mercedes or Audi ) ");
                string input = Console.ReadLine();

                FactoryGetter fc = new FactoryGetter();
                Factory obj = fc.CarType(input);
                if (obj != null)
                {
                    obj.makeHeadlight();
                    obj.makeTire();
                    
                }
                else
                {
                    Console.WriteLine("Invalid Car Type");
                    break;
                }

            }
            Console.ReadLine();
        }
    }
}
