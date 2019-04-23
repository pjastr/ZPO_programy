using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestyJednostkowe1;

namespace Testy
{
    [TestFixture]
    public class TestingClass
    {
        [Test]
        public void TestCalculatorAdding()
        {
            string sol = Calculator.Adding(10, 20);
            Assert.AreEqual("30", sol);
        }

        [Test]
        [MaxTime(4000)]
        public void TestCalculatorSubstract()
        {

            string sol = Calculator.Substract(50, 50);
            Assert.AreEqual("0", sol);
        }

        [Test]
        public void TestCalculatorMultiply(
        [Random(int.MinValue, int.MaxValue, 100)] float x)
        {
            string sol = Calculator.Multiply(x, 0);
            Assert.AreEqual("0", sol);
        }

        [TestCase(14, 4, "3.5")]
        [TestCase(16, 4, "4")]
        [TestCase(25, 5, "5")]
        public void TestCalculatorDivide(float x, float y, string s)
        {
            string sol = Calculator.Divide(x, y);
            Assert.AreEqual(s, sol);
        }
    }
}
