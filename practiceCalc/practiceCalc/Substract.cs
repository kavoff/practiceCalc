using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Операция вычитания двух чисел

namespace practiceCalc
{
    public partial class SubstractCalculator : ITwoArguments
    {
        public static double firstArgument, secondArgument;
        public double Calculate(double firstArgument, double secondArgument)
        {
            double result = (double)firstArgument - secondArgument;
            return (double)firstArgument - secondArgument;
        }
    }
}
