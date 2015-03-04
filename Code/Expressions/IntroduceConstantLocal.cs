using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.Expressions
{
    /* 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧�
     * Feature: Introduce Constant (Local)
     * 
     * Use Case: Lets you declare a new *local* constant 
     * initialized to the value of the string or number at the 
     * caret.
     *  
     * Available: When the caret is on a number or string literal.
     * 
     * See also: Inline Constant, Introduce Constant
     * 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧� */

    public class IntroduceConstantLocal
    {
        public double GetCircleArea(int radius)
        {
            return 3.14 * radius * radius;
        }
    }
}
