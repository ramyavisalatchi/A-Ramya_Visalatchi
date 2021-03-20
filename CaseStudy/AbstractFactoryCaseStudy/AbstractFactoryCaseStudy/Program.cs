using System;

namespace AbstractFactoryCaseStudy
{
    public class Program
    {
        static void Main(string[] args)
        {
            CarFactory carFactory = new ConcreteCarFactory();
            CarClient carClient = new CarClient(carFactory);

            Console.WriteLine("Enter the car type (MINI, MICRO, LUXURY)");
            string ip = Console.ReadLine();
            if(ip=="LUXURY")
                carClient.BuildLuxuryCar(Location.DEFAULT, CarType.LUXURY);
            if(ip=="MICRO")
                carClient.BuildMicroCar(Location.USA,CarType.MICRO);
            if(ip=="MINI")
                carClient.BuildMiniCar(Location.INDIA,CarType.MINI);
            

            Console.Read();
        }

        public enum CarType
        {
            MICRO, MINI, LUXURY
        }
        public enum Location
        {
            DEFAULT, USA, INDIA
        }
        
    }
}