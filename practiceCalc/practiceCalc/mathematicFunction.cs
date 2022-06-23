using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceCalc
{
    public partial class mathematicFunction
    {
        public void Calculate(double x, double y)
        {
            // return AdditionCalculator.Addition(x, y);
        }
        
        public double result = 0;
        /*public double Addition(double x, double y)
        {
            return result = x + y;
        }*/
        
        public void substract(double x, double y)
        {
            result = x - y;
        }
        public void multiplication(double x, double y)
        {
            result = x * y;
        }
        public void division(double x, double y)
        {
            result = x / y;
        }
    }
}
