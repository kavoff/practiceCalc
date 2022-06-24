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
            Assert.AreEqual(expectedResult, actualResult);
        }
    }

    public class MultiplyTest
    {
        [TestCase(0, 0, 0)]
        [TestCase(5, 2, 10)]
        [TestCase(-2, 3, -6)]
        public void CalculatorTest(double firstArgument, double secondArgument, double expectedResult)
        {
            // actual result
            MultiplyCalculator multiply = new MultiplyCalculator();
            double actualResult = multiply.Calculate(firstArgument, secondArgument);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }

    public class DivisionTest
    {
        [TestCase(2, 1, 2)]
        [TestCase(15, -1, -15)]
        [TestCase(-6, -3, 2)]
        public void CalculatorTest(double firstArgument, double secondArgument, double expectedResult)
        {
            // actual result
            DivisionCalculator division = new DivisionCalculator();
            double actualResult = division.Calculate(firstArgument, secondArgument);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }

    public class ExponentationTest
    {
        [TestCase(2, 3, 8)]
        [TestCase(5, 2, 25)]
        [TestCase(5, -1, 0.2)]
        public void CalculatorTest(double firstArgument, double secondArgument, double expectedResult)
        {
            // actual result
            ExponentationCalculator exponentation = new ExponentationCalculator();
            double actualResult = exponentation.Calculate(firstArgument, secondArgument);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }

    public class RemainderTest
    {
        [TestCase(1, 2, 1)]
        [TestCase(51, 4, 3)]
        [TestCase(-6, 4, -2)]
        public void CalculatorTest(double firstArgument, double secondArgument, double expectedResult)
        {
            // actual result
            RemainderCalculator remainder = new RemainderCalculator();
            double actualResult = remainder.Calculate(firstArgument, secondArgument);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }

    public class LogarithmTest
    {
        [TestCase(4, 2, 0.5)]
        [TestCase(2, 1, 0)]
        public void CalculatorTest(double firstArgument, double secondArgument, double expectedResult)
        {
            // actual result
            LogarithmCalculator logarithm = new LogarithmCalculator();
            double actualResult = logarithm.Calculate(firstArgument, secondArgument);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }

    public class MaxTest
    {
        [TestCase(816, 815, 816)]
        [TestCase(27, 3, 27)]
        [TestCase(123, 124, 124)]
        public void CalculatorTest(double firstArgument, double secondArgument, double expectedResult)
        {
            // actual result
            MaxCalculator max = new MaxCalculator();
            double actualResult = max.Calculate(firstArgument, secondArgument);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}