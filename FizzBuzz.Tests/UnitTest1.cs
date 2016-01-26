using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WhenNumberIsOneReturnOne()
        {
            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.Calculate(1);
            Assert.AreEqual("1", result);
        } 
    }
}
