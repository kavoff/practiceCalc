using System;
using NUnit.Framework;

namespace practiceCalc.Tests
{
    [TestFixture]
    public class AdditionTest
    {
        [TestCase(0, 0, 0)]
        [TestCase(5,6, 11)]
        [TestCase(3, 2, 5)]
        public void CalculatorTest(double firstArgument, double secondArgument, double expectedResult)
        {
            // actual result
            AdditionCalculator addition = new AdditionCalculator();
            double actualResult = addition.Calculate(firstArgument, secondArgument);
            ;
            Assert.AreEqual(expectedResult, actualResult);
        }
    }

    public class SubstractTest
    {
        [TestCase(0, 0, 0)]
        [TestCase(5, 6, -1)]
        [TestCase(3, 2, 1)]
        public void CalculatorTest(double firstArgument, double secondArgument, double expectedResult)
        {
            // actual result
            SubstractCalculator substract = new SubstractCalculator();
            double actualResult = substract.Calculate(firstArgument, secondArgument);
            ;
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
