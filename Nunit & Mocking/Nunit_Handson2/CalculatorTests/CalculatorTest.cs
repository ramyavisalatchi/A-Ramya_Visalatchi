using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalcLibrary;
using NUnit.Framework;

namespace CalculatorTests
{
    [TestFixture]
    public class CalculatorTest
    {
        SimpleCalculator p;
        double result;
        [SetUp]
        public void SetUp()
        {
            p = new SimpleCalculator();
            result = 0;

        }


        [Test]
        [TestCase(4,2,2)]
        [TestCase(4,-2,6)]
        public void CheckSubtraction(double a, double b, double Eresult)
        {
             result = p.Subtraction(a, b);
            Assert.AreEqual(Eresult, result);
        }

        [Test]
        [TestCase(4, 2, 8)]
        [TestCase(4, -2, -8)]
        [TestCase(0, -2, 0)]
        public void CheckMultiplication(double a, double b, double Eresult)
        {
            result = p.Multiplication(a, b);
            Assert.AreEqual(Eresult, result);
        }

        [Test]
        [TestCase(4, 2, 2)]
        [TestCase(0, 2, 0)]
      //  [TestCase(2, 0, 0)]
        public void CheckDivision(double a, double b, double Eresult)
        {
            try
            {

             result = p.Division(a, b);
            }
            catch(ArgumentException e)
            {
                Assert.Fail(e.Message);
                
            }
            Assert.AreEqual(Eresult, result);
        }

        [Test]
        public void TestAddAndClear()
        {
          result=  p.Addition(10, 20);
            Assert.AreEqual(30, result);

            p.AllClear();
            Assert.AreEqual(0, p.GetResult);
        }

    }
}
