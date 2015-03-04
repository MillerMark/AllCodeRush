using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.Methods
{
    /* •———————————————————————————————————————————————————————•
     * Feature: Declare Method
     * 
     * Use Case: Lets you generate a method where none exists 
     * based on an existing call to that method.
     *  
     * Available: When the caret is on a statement calling an undeclared method.
     * 
     * See also: Declare Method (Abstract)
     * •———————————————————————————————————————————————————————• */

    public class DeclareMethod
    {
        public void ExistingMethod()
        {
            OtherMethod(1);
        }
    }
}
