using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Операция сложения двух чисел

namespace practiceCalc
{
    public partial class AdditionCalculator : ITwoArguments
    {
        public static double firstArgument, secondArgument;
        public double Calculate(double firstArgument, double secondArgument)
        {
            return (double)(firstArgument + secondArgument);
        }
        /*
        double ITwoArguments.Calculate(double firstArgument, double secondArgument)
        {
            double result = 0;
            result = firstArgument + secondArgument;
            return result;
        }
        */
    }
}
