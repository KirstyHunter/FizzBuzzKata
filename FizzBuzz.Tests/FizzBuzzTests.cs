using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Tests
{
    [TestClass]
    public class FizzBuzzTests
    {
        private FizzBuzz _fizzBuzz;

        public FizzBuzzTests()
        {
            _fizzBuzz = new FizzBuzz();
        }

        [TestMethod]
        public void WhenNumberIsOneReturnOne()
        {
            var result = _fizzBuzz.Calculate(1);
            Assert.AreEqual("1", result);
        }

        [TestMethod]
        public void WhenNumberIsTwoReturnTwo()
        {
            var result = _fizzBuzz.Calculate(2);
            Assert.AreEqual("2", result);
        } 

        [TestMethod]
        public void WhenNumberIsThreeReturnFizz()
        {
            var result = _fizzBuzz.Calculate(3);
            Assert.AreEqual("Fizz", result);
        }

        [TestMethod]
        public void WhenNumberIsFiveReturnBuzz()
        {
            var result = _fizzBuzz.Calculate(5);
            Assert.AreEqual("Buzz", result);
        }

        [TestMethod]
        public void WhenNumberIsSixReturnFizz()
        {
            var result = _fizzBuzz.Calculate(6);
            Assert.AreEqual("Fizz", result);
        }
    }
}
