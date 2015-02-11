using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
       public class CalcImpl:ICalc
    {
        public double Add(double a, double b)
        {
            return a + b;
        }
    }
}
