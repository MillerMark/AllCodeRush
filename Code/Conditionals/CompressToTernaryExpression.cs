using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.Conditionals
{
    public class CompressToTernaryExpression
    {
        public static string isPositive(int input)
        {
            if (input >= 0)
                return "positive";
            else
                return "negative";
        }
    }
}
