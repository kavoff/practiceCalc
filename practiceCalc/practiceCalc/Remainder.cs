﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceCalc
{
    public class RemainderCalculator : ITwoArguments
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument % secondArgument;
        }
    }
}
