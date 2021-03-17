using Day2_Handson2_AbstractFactory.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace Day2_Handson2_AbstractFactory.ConcreteClasses
{
    class AudiTire : Tire
    {
        public override void GetTyres()
        {
            Console.WriteLine("making Audi car Tyres");
        }

        public AudiTire()
        {
            GetTyres();
        }
    }
}
