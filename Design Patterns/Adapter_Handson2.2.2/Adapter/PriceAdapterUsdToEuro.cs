using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class PriceAdapterUsdToEuro:PriceAdapter
    {
        private Price luxuryCars;
        public PriceAdapterUsdToEuro(Price price)
        {
            luxuryCars = price;
        }

        public double GetPrice()
        {
            return convertUSDtoEURO(luxuryCars.GetPrice());
        }
        private double convertUSDtoEURO(double usd) { return usd * 0.84; }
    }
}
