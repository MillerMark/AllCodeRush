using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.Expressions
{
    /* •———————————————————————————————————————————————————————•
     * Feature: Inline Result
     * 
     * Use Case: Lets you replace final assignments to the 
     * temporary variable with a statement that immediately 
     * returns the value.
     *  
     * Available: When the caret is on a local variable whose 
     * value is returned by this method.
     * 
     * See also: Introduce Result Variable
     * •———————————————————————————————————————————————————————• */

    public class InlineResult
    {
        public bool isThisYourCard(bool CardIsAceOfSpades)
        {
            bool Result;
            if (CardIsAceOfSpades)
                Result = true;
            else
                Result = false;
            return Result;
        }
    }
}
