using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceCalc
{
    public class Calc : ITwoArguments
    {
        public double firstArgument, secondArgument;

        public double Addition(double firstArgument, double secondArgument)
        {
            return firstArgument + secondArgument;
        }
        public double Substract(double firstArgument, double secondArgument)
        {
            return firstArgument - secondArgument;
        }
        public double Division(double firstArgument, double secondArgument)
        {
            return firstArgument / secondArgument;
        }
        public double Multiply(double firstArgument, double secondArgument)
        {
            return firstArgument * secondArgument;
        }

        public double Remainder(double firstArgument, double secondArgument)
        {
            return firstArgument % secondArgument;
        }

        public double Sqrt(double firstArgument, double secondArgument)
        {
            return Math.Pow(firstArgument, secondArgument);
        }
    }
}
