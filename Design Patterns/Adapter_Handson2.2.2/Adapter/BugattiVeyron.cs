using System;

namespace Adapter
{
    public class BugattiVeyron : Movable,Price
    {
        public double GetPrice()
        {
            return 100;
        }

        public double GetSpeed()
        {
            return 268;
        }
    }
}
