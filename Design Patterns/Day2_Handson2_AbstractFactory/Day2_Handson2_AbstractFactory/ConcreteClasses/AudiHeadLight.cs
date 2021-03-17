using Day2_Hands_on_1_2_AbstractFactory;
using Day2_Handson2_AbstractFactory.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace Day2_Handson2_AbstractFactory.ConcreteClasses
{
    
        public class AudiHeadLight : HeadLights
        {
            public override void getHeadLights()
            {
            Console.WriteLine("making Audi car HeadLights");
            }

            public AudiHeadLight()
            {
            getHeadLights();
            }
        }
    }

