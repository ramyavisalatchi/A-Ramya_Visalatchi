using System;
using System.Collections.Generic;
using System.Text;
using static AbstractFactoryCaseStudy.Program;

namespace AbstractFactoryCaseStudy
{
    abstract class Car
    {
        public Car(Location location, CarType model)
        {
            this.CarType = model;
            this.Location = location;
        }

        public abstract void Construct();

        public CarType CarType { get; set; }
        public Location Location { get; set; }

        public override string ToString()
        {
            return "CarModel - " + CarType.ToString() + " located in " + Location.ToString();
        }
    }

    class LuxuryCar : Car
    {
        public LuxuryCar(Location location, CarType carType) : base(location, CarType.LUXURY)
        {
            Construct();
        }
        public override void Construct()
        {
            Console.WriteLine("Connecting to luxury car");
            Console.WriteLine(base.ToString());
        }
    }

    class MicroCar : Car
    {
        public MicroCar(Location location, CarType carType) : base(location,CarType.MICRO)
        {
            Construct();
        }
        public override void Construct()
        {
            Console.WriteLine("Connecting to Micro car");
            Console.WriteLine(base.ToString());
        }
    }


    class MiniCar : Car
    {
        public MiniCar(Location location, CarType carType) : base(location,CarType.MINI)
        {
            Construct();
        }
        public override void Construct()
        {
            Console.WriteLine("Connecting to Mini car");
            Console.WriteLine(base.ToString());
        }
    }

}
