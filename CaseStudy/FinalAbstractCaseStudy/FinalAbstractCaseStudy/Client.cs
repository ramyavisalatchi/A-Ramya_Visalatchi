using System;
using System.Collections.Generic;
using System.Text;

namespace FinalAbstractCaseStudy
{
    class Client
    {
        OredrFactory Factory1;
        public Client(OredrFactory Factory)
        {
            Factory1 = Factory;
        }
        public void BuildElectronicOrder(Channel channel)
        {
            Factory1.MakeElectronicOrder(channel, ProductType.Electronic);
        }
        public void BuildFurnitureOrder(Channel channel)
        {
            Factory1.MakeFurnitureOrder(channel, ProductType.Furniture);
        }
        public void BuildToyOrder(Channel channel)
        {
            Factory1.MakeToyOrder(channel, ProductType.Toy);
        }
    }
}
