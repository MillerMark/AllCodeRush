using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.DeclarationInitialization
{
    /* •———————————————————————————————————————————————————————•
     * Feature: Convert To Constant
     * 
     * Use Case: Lets you convert a variable to a constant.
     *  
     * Available: When the cursor is on a string variable or 
     * field declaration with initialization, provided that its 
     * value is never changed.
     * •———————————————————————————————————————————————————————• */

    public class ConvertToConstant
    {
        private double _PI = 3.14;
        public double GetCircleArea(int radius)
        {
            return _PI * radius * radius;
        }
    }
}
