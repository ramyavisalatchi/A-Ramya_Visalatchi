
using System;
using System.Collections.Generic;
using System.Text;

namespace Day2_Handson2_AbstractFactory.AbstractFactory
{
    public abstract class Factory
    {
        public abstract HeadLights makeHeadlight();
        public abstract Tire makeTire();
    }
}
