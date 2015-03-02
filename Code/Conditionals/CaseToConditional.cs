using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.Conditionals
{
    /* •———————————————————————————————————————————————————————•
     * Feature: Case To Conditional
     * 
     * Use Case: Lets you convert a switch\select statement into 
     * a series of nested if..else
     *  
     * Available: When the caret is on the 'switch'\'Select' 
     * keyword.
     * 
     * See also: Conditional To Case 
     * •———————————————————————————————————————————————————————• */
    public class CaseToConditional
    {
        public double CalculateDiscountPCent(CustomerType customerType)
        {
            switch (customerType)
            {
                case CustomerType.Platinum:
                    return 15.0;
                case CustomerType.Gold:
                    return 10.0;
                case CustomerType.Silver:
                    return 5.0;
                case CustomerType.Bronze:
                    return 2.5;
                default:
                    throw new Exception("This cannot happen");
            }
        }
        #region Support Code
        public enum CustomerType
        {
            Platinum,
            Gold,
            Silver,
            Bronze
        }
        #endregion
    }
}
