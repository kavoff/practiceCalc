using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceCalc
{
    public partial class MultiplyCalculator : ITwoArguments
    {
        double ITwoArguments.Calculate(double x, double y)
        {
            return x * y;
        }

    }
}
