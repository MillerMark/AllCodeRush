using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.Conditionals
{
    /* •———————————————————————————————————————————————————————•
     * Feature: Expand Ternary Expression
     * 
     * Use Case: Lets you convert a Ternary Expression into an 
     * if/else block.
     *  
     * Available: When the caret is on an expression containing 
     * a ternary operator.
     * 
     * See also: Compress To Ternary Operator
     * •———————————————————————————————————————————————————————• */

    public class ExpandTernaryExpression
    {
        public static string isPositive(int input)
        {
            return input >= 0 ? "positive" : "negative";
        }
    }
}
