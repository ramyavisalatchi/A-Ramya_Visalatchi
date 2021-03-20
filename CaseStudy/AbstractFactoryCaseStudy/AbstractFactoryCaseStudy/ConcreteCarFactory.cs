using System;
using System.Collections.Generic;
using System.Text;
using static AbstractFactoryCaseStudy.Program;

namespace AbstractFactoryCaseStudy
{
    public class ConcreteCarFactory : CarFactory
    {
        public void ManufactureLuxuryCar(Location location, CarType carType)
        {
            new LuxuryCar(location,carType);
        }

        public void ManufactureMicroCar(Location location, CarType carType)
        {
            new MicroCar(location, carType);
        }

        public void ManufactureMiniCar(Location location, CarType carType)
        {
            new MiniCar(location, carType);
        }
    }
}
