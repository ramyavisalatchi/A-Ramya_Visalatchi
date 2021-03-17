using Day2_Handson2_AbstractFactory.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace Day2_Handson2_AbstractFactory.ConcreteClasses
{
    public class MercedesTire : Tire
    {
        public override void GetTyres()
        {
            Console.WriteLine("making Mercedes car Tire");
        }
        public MercedesTire()
        {
            GetTyres();
        }
    }
}
