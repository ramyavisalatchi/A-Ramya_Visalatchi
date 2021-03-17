using Day2_Handson2_AbstractFactory.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace Day2_Handson2_AbstractFactory.ConcreteClasses
{
    class MercedesHeadLight : HeadLights
    {
        public override void getHeadLights()
        {
            Console.WriteLine("making Mercedes car HeadLights");
        }
        public MercedesHeadLight()
        {
            getHeadLights();
        }
    }
}
