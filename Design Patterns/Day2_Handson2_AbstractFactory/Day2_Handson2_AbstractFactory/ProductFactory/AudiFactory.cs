using Day2_Handson2_AbstractFactory.AbstractFactory;
using Day2_Handson2_AbstractFactory.ConcreteClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Day2_Handson2_AbstractFactory.ProductFactory
{
    public class AudiFactory : Factory
    {
        public override HeadLights makeHeadlight()
        {
            return new AudiHeadLight();
        }

        public override Tire makeTire()
        {
            return new AudiTire();
        }
    }
}
