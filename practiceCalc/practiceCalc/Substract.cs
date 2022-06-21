using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceCalc
{
    public partial class SubstractCalculator : ITwoArguments
    {
        double ITwoArguments.Calculate(double x, double y)
        {
            double result = 0;
            return result = x - y;
        }

    }
}
