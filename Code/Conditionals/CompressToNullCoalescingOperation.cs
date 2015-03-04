using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.Conditionals
{
    /* •———————————————————————————————————————————————————————•
     * Feature: Compress to Null Coalescing Operation.
     * 
     * Use Case: Lets you convert a ternary operation which uses
     * a null comparison into a null coalescing operation.
     *  
     * Available: When the caret is on a ? statement. 
     *  - The statement's left hand side should compare a variable
     *    to null. 
     *  - The same variable should be one of two alternatives in 
     *  the right-hand side.
     * 
     * See also: Expand Null Coalescing Ternary Condition.
     * •———————————————————————————————————————————————————————• */

    public class CompressToNullCoalescingOperation
    {
        private string _Value;
        public string GetValue()
        {
            return _Value == null ? "Default" : _Value;
        }
    }
}
