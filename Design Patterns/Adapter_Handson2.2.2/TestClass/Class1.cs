using NUnit.Framework;
using System;

namespace TestClass
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void whenConvertingMPHToKMPH_thenSuccessfullyConverted()
        {
            Movable bugattiVeyron = new BugattiVeyron();
            MovableAdapter bugattiVeyronAdapter = new MovableAdapterImpl(bugattiVeyron);
            assertEquals(bugattiVeyronAdapter.getSpeed(), 431.30312, 0.00001);
        }
    }
}
