using System;
using System.Collections.Generic;
using System.Text;
using static AbstractFactoryCaseStudy.Program;

namespace AbstractFactoryCaseStudy
{
    public class CarClient
    {
        CarFactory carFactory;
        public CarClient(CarFactory carFactory)
        {
            this.carFactory = carFactory;
        }

        public void BuildMicroCar(Location location, CarType carType)
        {
            carFactory.ManufactureMicroCar(location, carType);
        }
        public void BuildMiniCar(Location location, CarType carType)
        {
            carFactory.ManufactureMiniCar(location, carType);
        }
        public void BuildLuxuryCar(Location location,CarType carType)
        {
            carFactory.ManufactureLuxuryCar(location, carType);

        }
    }
}
