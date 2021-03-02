using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace CalculationApp
{
    public class CalculatorTestor
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
            public void CalculatorAddMethod()
            {
                calculator add = new calculator();
                result = add.Add(40, 20);
                Assert.AreEqual(60, result);
            }
            [Test]
            public void CalculatorAddConstraintMethod()
            {
                calculator add = new calculator();
                result = add.Add(25, 35);
                Assert.That(result, Is.EqualTo(60));
                Assert.That(result, Is.GreaterThan(0));
                Assert.That(result, Is.GreaterThanOrEqualTo(50));
                Assert.That(result, Is.LessThan(100));
                Assert.That(result, Is.LessThanOrEqualTo(100));
                Assert.That(result, Is.InRange(0, 100));
            }
            [Test]
            [TestCase(20, 25, 45)]
            //[Repeat(3)]
            [MaxTime(200)]
            public void CalculatorAddMethod(int x, int y, int expected)
            {
                calculator add = new calculator();
                result = add.Add(x, y);
                Assert.AreEqual(expected, result);
            }
        }
    }
}
