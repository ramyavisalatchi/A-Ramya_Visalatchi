using Adapter;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClass1
{
    [TestFixture]
    public class TesterClass
    {
        [Test]
        public void whenConvertingMPHToKMPH_thenSuccessfullyConverted()
        {
            Movable bugattiVeyron = new BugattiVeyron();
            MovableAdapter bugattiVeyronAdapter = new MovableAdapterImpl(bugattiVeyron);
            Assert.AreEqual(bugattiVeyronAdapter.GetSpeed(), 431.30312);
        }

        [Test]
        public void whenConvertingUSDToEuro_thenSuccessfullyConverted()
        {
            Price P= new BugattiVeyron();
            PriceAdapter Price_Adapter = new PriceAdapterUsdToEuro(P);
            Assert.AreEqual(Price_Adapter.GetPrice(), 84);
        }
    }
}
