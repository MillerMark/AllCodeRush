using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;

namespace AllCodeRush.Code.DeclarationInitialization
{
    /* •———————————————————————————————————————————————————————•
     * Feature: Declare Enum Element
     * 
     * Use Case: Lets you add an element to a preexisting enum 
     * declaration by example.
     *  
     * Available: When the caret is on a reference to an 
     * undeclared enumeration element.
     * •———————————————————————————————————————————————————————• */

    public class DeclareEnumElement
    {
        public enum DiscountLevelEnum
        {
            Platinum, 
            Gold,
            Silver,
        }
        public double CalculateDiscountPCent(DiscountLevelEnum discountLevel)
        {
            switch (discountLevel)
            {
                case DiscountLevelEnum.Platinum:
                    return 15.0;
                case DiscountLevelEnum.Gold:
                    return 10.0;
                case DiscountLevelEnum.Silver:
                    return 5.0;
                case DiscountLevelEnum.Bronze:
                    return 2.5;
                default:
                    throw new Exception("This cannot happen");
            }
        }
    }
    
}
