using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator.Tests
{
    [TestClass()]
    public class CalculateTests
    {
        [TestMethod()]
        public void AddTest()
        {
            var doub = Calculate.Add(4, 7);
            Assert.AreEqual(doub, (double)11);
        }

        [TestMethod()]
        public void SubtractTest()
        {
            var doub = Calculate.Subtract(4, 7);
            Assert.AreEqual(doub, (double)-3);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            var doub = Calculate.Multiply(4, 7);
            Assert.AreEqual(doub, (double)28);
        }

        [TestMethod()]
        public void DivideTest()
        {
            var doub = Calculate.Divide(10, 2);
            Assert.AreEqual(doub, (double)5);
        }
    }
}