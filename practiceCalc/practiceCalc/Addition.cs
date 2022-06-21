using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using static practiceCalc.ITwoArguments;

namespace practiceCalc
{
    public partial class AdditionCalculator : ITwoArguments
    {
        double ITwoArguments.Calculate(double x, double y)
        {
            return x + y;
        }
        
    }
}
