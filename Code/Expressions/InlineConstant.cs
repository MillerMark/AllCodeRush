using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.Expressions
{
    public class InlineConstant
    {
        public double GetCircleArea(int radius)
        {
            const double PI = 3.14;
            return PI * radius * radius;
        }
    }
}
