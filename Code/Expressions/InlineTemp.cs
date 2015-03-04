using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.Expressions
{
    /* 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧�
     * Feature: Inline Temp
     * 
     * Use Case: Lets you replace all references to a local 
     * variable with its initial value.
     *  
     * Available: When the caret is on the declaration or 
     * reference of a local variable. The variable should have 
     * been assigned a value only once.
     * 
     * See also: Introduce Local
     * 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧� */

    public class InlineTemp
    {
        public double GetCylinderVolume(int radius, int height)
        {
            int h = height;
            int r = radius;
            return r * r * h * Math.PI;
        }
    }
}
