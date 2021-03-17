using Day2_Handson2_AbstractFactory.AbstractFactory;
using Day2_Handson2_AbstractFactory.ConcreteClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Day2_Handson2_AbstractFactory.ProductFactory
{
    class  MercedesFactory:Factory
    {
        public override HeadLights makeHeadlight()
        {
            return new MercedesHeadLight();
        }

        public override Tire makeTire()
        {
            return new MercedesTire();
        }
    }
}
