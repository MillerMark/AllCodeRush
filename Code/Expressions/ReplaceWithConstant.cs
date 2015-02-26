using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.Expressions
{
    public class ReplaceWithConstant
    {
        const double PI = 3.14;
        public double GetCircleArea(int radius)
        {
            return radius * radius * 3.14;
        }
    }
}
