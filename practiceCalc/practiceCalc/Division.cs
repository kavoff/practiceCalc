using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceCalc
{
    public partial class DivisionCalculator : ITwoArguments
    {
        double ITwoArguments.Calculate(double x, double y)
        {
            return x / y;
        }

    }
}
