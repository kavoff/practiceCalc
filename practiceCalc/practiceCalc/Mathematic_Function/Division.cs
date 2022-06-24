using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Операция деления двух чисел

namespace practiceCalc
{
    public class DivisionCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (secondArgument == 0)
            {
                throw new DivideByZeroException("Деление на 0");
            }

            return firstArgument / secondArgument;
        }

    }
}
