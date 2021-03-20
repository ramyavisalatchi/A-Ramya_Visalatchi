using System;
using System.Collections.Generic;
using System.Text;
using static AbstractFactoryCaseStudy.Program;

namespace AbstractFactoryCaseStudy
{
    public interface CarFactory
    {
        void ManufactureMicroCar(Location location, CarType carType);
        void ManufactureMiniCar(Location location, CarType carType);
        void ManufactureLuxuryCar(Location location, CarType carType);
    }
}
