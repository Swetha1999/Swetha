using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CalcLibrary;
namespace CalcLibrary
{

    [TestFixture]
    public class CalcTest
    {
        double Result;
        [SetUp]
        public void SetUpMethod()
        {
            Result = 0;
        }

        [Test]
        [TestCase(20, 5, 15)]
        [TestCase(20, 4, 16)]
        public void CalcSubMethod(double x, double y, double expected)
        {
            SimpleCalculator add = new SimpleCalculator();
            Result = add.Subtraction(x, y);
            Assert.AreEqual(expected, Result);
        }

        [Test]
        [TestCase(2, 5, 10)]
        [TestCase(2, 4, 8)]
        public void CalcMulMethod(double x, double y, double expected)
        {
            SimpleCalculator add = new SimpleCalculator();
            Result = add.Multiplication(x, y);
            Assert.AreEqual(expected, Result);
        }

        [Test]
        [TestCase(20, 5, 4)]
       [TestCase(20, 0, 0)]
        public void CalcDivMethod(double x, double y, double expected)
        {
            SimpleCalculator add = new SimpleCalculator();
            try
            {
                Result = add.Division(x, y);
                Assert.AreEqual(expected, Result);
            }
            catch (ArgumentException)
            {
                Assert.Fail("Division by zero");
            }
        }

        [Test]
        [TestCase(2, 5, 7)]
        [TestCase(2, 4, 6)]
        public void TestAddAndClear(double x, double y, double expected)
        {
            SimpleCalculator add = new SimpleCalculator();
            add.Addition(x, y);
            Assert.AreEqual(add.GetResult, expected);
            add.AllClear();
            Assert.AreEqual(add.GetResult, 0);
        }

    }
}
