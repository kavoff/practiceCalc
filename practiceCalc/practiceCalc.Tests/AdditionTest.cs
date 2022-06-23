using System;
using NUnit.Framework;

namespace practiceCalc.Tests
{
    [TestFixture]
    public class AdditionTest
    {
        [Test]
        public void CalculatorTest()
        {
            double firstArgument = 5;
            double secondArgument = 5;
            // expected result
            double expectedResult = firstArgument + secondArgument;

            // actual result
            AdditionCalculator addition = new AdditionCalculator();
            double actualResult = addition.Calculate(firstArgument, secondArgument);
            ;
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
