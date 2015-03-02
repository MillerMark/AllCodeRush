using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.Conditionals
{
    /* •———————————————————————————————————————————————————————•
     * Feature: Case To Conditional
     * 
     * Use Case: Lets you convert series of nested if..else to 
     * a switch\select statement.
     *  
     * Available: When the caret is on an if statement that has 
     * a corresponding else block.
     * 
     * See also: Case To Conditional
     * •———————————————————————————————————————————————————————• */

    public class ConditionalToCase
    {
        public double CalculateDiscountPCent(CustomerType customerType)
        {
            if (customerType == CustomerType.Platinum)
                return 15.0;
            else
            {
                if (customerType == CustomerType.Gold)
                    return 10.0;
                else
                {
                    if (customerType == CustomerType.Silver)
                        return 5.0;
                    else
                    {
                        if (customerType == CustomerType.Bronze)
                            return 2.5;
                        else
                        {
                            throw new Exception("This cannot happen");
                        }
                    }
                }
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
