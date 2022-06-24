using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Статичныйй класс "Фабрика"

namespace practiceCalc
{
    public static class TwoArgumentsCalculator
    {
        public static double firstArgument, secondArgument;

        // Создание математических экземпляров по условию, на вход принимается знак операции.
        public static double CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "+":
                    return new AdditionCalculator().Calculate(firstArgument, secondArgument);
                case "-":
                    return new SubstractCalculator().Calculate(firstArgument, secondArgument);
                case "×":
                    return new MultiplyCalculator().Calculate(firstArgument, secondArgument);
                case "/":
                    if (secondArgument == 0)
                    {
                        throw new DivideByZeroException("Деление на 0");
                    }
                    return new DivisionCalculator().Calculate(firstArgument, secondArgument);
                case "x^y":
                    return new ExponentationCalculator().Calculate(firstArgument, secondArgument);
                case "x%y":
                   return new RemainderCalculator().Calculate(firstArgument, secondArgument);
                case "logx(y)":
                    return new LogarithmCalculator().Calculate(firstArgument, secondArgument);
                case "max(x,y)":
                    return new MaxCalculator().Calculate(firstArgument, secondArgument);
                default:
                    throw new Exception("Unknown operation");
            }
        }
    }
}
