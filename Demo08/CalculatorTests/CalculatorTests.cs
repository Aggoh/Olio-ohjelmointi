using Microsoft.VisualStudio.TestTools.UnitTesting;
using Demo08;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo08.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            // arrage
            Calculator calc = new Calculator();
            int number1 = 7;
            int number2 = 5;
            int expected = 12;

            // act

            int actual = calc.Add(number1, number2);

            // assert
            Assert.AreEqual(expected, actual);

            Assert.Fail();
        }

        [TestMethod()]
        public void MultipleTest()
        {
            // arrage
            Calculator calc = new Calculator();
            int number1 = 5;
            int number2 = 7;
            int expected = 35;

            // ace

            int actual = calc.Multiple(number1, number2);

            // assert
            Assert.AreEqual(expected, actual);
            Assert.Fail();
        }
    }
}