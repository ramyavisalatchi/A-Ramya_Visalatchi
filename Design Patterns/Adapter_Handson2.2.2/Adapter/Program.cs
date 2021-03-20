using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var MPH = new BugattiVeyron();
            var KM = new MovableAdapterImpl(MPH);
            var price = new PriceAdapterUsdToEuro(MPH);

            Console.WriteLine($"Speed in MPH: {MPH.GetSpeed()}");
            Console.WriteLine($"Price in USD: {price.GetPrice()}");

            Console.WriteLine();

            Console.WriteLine($"Speed in KPH: {KM.GetSpeed()}");
            Console.WriteLine($"Price in euro: {price.GetPrice()}");

            Console.ReadKey();
        }
    }
}
