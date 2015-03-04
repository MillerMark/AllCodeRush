using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.Methods
{
    /* •———————————————————————————————————————————————————————•
     * Feature: Make Member Non-Static
     * 
     * Use Case: Lets you make a static member an instance 
     * member and updates all references accordingly.
     *  
     * Available: When the cursor is on a static method 
     * declaration.
     * 
     * See also: Make Member Static
     * •———————————————————————————————————————————————————————• */

    public class MakeMemberNonStatic
    {
        public static double GetCircleArea(int radius)
        {
            return Math.PI * radius * radius;
        }
    }
}
