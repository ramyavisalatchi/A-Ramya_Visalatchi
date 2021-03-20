using System;
using System.Collections.Generic;
using System.Text;

namespace FinalAbstractCaseStudy
{
    interface OredrFactory
    {
        void MakeElectronicOrder(Channel channel, ProductType productType);
        void MakeFurnitureOrder(Channel channel, ProductType productType);
        void MakeToyOrder(Channel channel, ProductType productType);
    }
}
