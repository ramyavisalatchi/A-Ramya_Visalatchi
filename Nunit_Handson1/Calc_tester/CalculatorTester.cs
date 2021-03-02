using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nunit_Handson1;
using NUnit.Framework;

namespace Calc_tester
{
    [TestFixture]
    public class CalculatorTester
    {
        int result;
        [SetUp]
        public void SetUpMethod()
        {
            result = 0;
        }
        [Test]
        public void CalcAddMethod()
        {
            calculator add = new calculator();
            result = add.Add(10, 20);
            Assert.AreEqual(30, result);
        }
        [TearDown]
        public void CleanUpMethod()
        {
            result = 0;
        }
    }
}
