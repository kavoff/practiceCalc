using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static practiceCalc.ITwoArguments;

namespace practiceCalc
{
    public static class TwoArgumentsCalculator
    {
        public static double CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "+":
                    return new AdditionCalculator();
                case "-":
                    return new SubstractCalculator();
                case "×":
                    return new MultiplyCalculator();
                case "/":
                    return new DivisionCalculator();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
