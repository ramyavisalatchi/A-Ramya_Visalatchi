using Day2_Handson2_AbstractFactory.AbstractFactory;
using Day2_Handson2_AbstractFactory.ProductFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace Day2_Handson2_AbstractFactory.Client
{
    class FactoryGetter
    {
        public Factory CarType(string car)
        {
            if (car == "Mercedes")
                return new MercedesFactory();
            if (car == "Audi")
                return new AudiFactory();

            return null;
        }
    }
}
