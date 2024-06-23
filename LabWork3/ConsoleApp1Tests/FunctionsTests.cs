using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class FunctionsTests
    {
        [TestMethod()]
        [DataTestMethod()]
        [DataRow(0, 1)]
        [DataRow(1, 1)]
        [DataRow(5, 120)]
        public void FactorialTest_CorrectValues(int n, long expected)
        {
            Assert.AreEqual(expected, Functions.GetFactorial(n));
        }

        [TestMethod()]
        public void FactorialTest_IncorrectValues()
        {
            Assert.AreEqual(0, Functions.GetFactorial(-1));
        }

        [TestMethod()]
        [DataTestMethod()]
        [DataRow(1.5, 2, 2.25)]
        public void PowerTest_PositivePower(double x, int n, double expected)
        {
            Assert.AreEqual(expected, Functions.GetPower(x, n), 0.001);
        }

        [TestMethod()]
        [DataTestMethod()]
        [DataRow(2, -4, 0.063)]
        public void PowerTest_NegativePower(double x, int n, double expected)
        {
            Assert.AreEqual(expected, Functions.GetPower(x, n), 0.001);
        }

      
        [TestMethod()]
        [DataTestMethod()]
        [DataRow(1.5, 2, 2.25)]
        public void FastGetPower_PositivePower(double x, int n, double expected)
        {
            Assert.AreEqual(expected, Functions.FastGetPower(x, n));
        }

        [TestMethod()]
        [DataTestMethod()]
        [DataRow(2, -4, -1)]
        public void FastPowerTest_NegativePower(double x, int n, double expected)
        {
            Assert.AreEqual(expected, Functions.FastGetPower(x, n), 0.001);
        }

        

    }
}