using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CalcLibrary;
namespace Calc_Tester
{
    public class ClaculatorTester
    {
        int Result;
        [SetUp]
        public void SetUpMethod()
        {
            Result = 0;
        }

        [Test]
        [TestCase(20, 5, 15)]
        [TestCase(20, 4, 16)]
        public void CalcSubMethod(int x, int y, int expected)
        {
            SimpleCalculator add = new SimpleCalculator();
            Result = add.Subtraction(x, y);
            Assert.AreEqual(expected, Result);
        }

        [Test]
        [TestCase(3, 5, 15)]
        [TestCase(2, 4, 8)]
        public void CalcMulMethod(int x, int y, int expected)
        {
            SimpleCalculator add = new SimpleCalculator();
            Result = add.Multiplication(x, y);
            Assert.AreEqual(expected, Result);
        }

        [Test]
        [TestCase(20, 2, 10)]
        [TestCase(20, 0, 0)]
        public void CalcDivMethod(int x, int y, int expected)
        {
            SimpleCalculator add = new SimpleCalculator();
            try
            {
                    Result = add.Division(x, y);
                    Assert.AreEqual(expected, Result);
            }
            catch (ArgumentException e)
            {
                Assert.Fail("Division by zero");
            }
        }

        [Test]
        [TestCase(2, 5, 7)]
        public void TestAddAndClear(int x,int y,int expected)
        {
            SimpleCalculator add = new SimpleCalculator();
            add.Addition(x, y);
            Assert.AreEqual(add.GetResult, expected);
            add.AllClear();
            Assert.AreEqual(add.GetResult, 0);
        }



    }
}
