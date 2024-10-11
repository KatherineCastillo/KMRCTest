using Microsoft.VisualStudio.TestTools.UnitTesting;
using KMRC.Temperatura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMRC.Temperatura.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod]
        public void CelsiusFahrenheitTest()
        {

            Calculator calculator = new Calculator();
            double result = calculator.CelsiusFahrenheit(0);
            Assert.AreEqual(32, result);

            result = calculator.CelsiusFahrenheit(100);
            Assert.AreEqual(212, result);

            result = calculator.CelsiusFahrenheit(-40);
            Assert.AreEqual(-40, result);
        }

        [TestMethod]
        public void FahrenheititToCelsiusTest()
        {
            Calculator calculator = new Calculator();
            double result = calculator.FahrenheititToCelsius(32);
            Assert.AreEqual(0, result);

            result = calculator.FahrenheititToCelsius(212);
            Assert.AreEqual(100, result);

            result = calculator.FahrenheititToCelsius(-40);
            Assert.AreEqual(-40, result);
        }
    }
}