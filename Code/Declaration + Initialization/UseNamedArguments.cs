using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.DeclarationInitialization
{
    /* •———————————————————————————————————————————————————————•
     * Feature: Use Named Arguments
     * 
     * Use Case: Lets you convert a method call with positional 
     * arguments into a named-argument call.
     *  
     * Available: When the caret is on a method name within its 
     * call, provided that the method has parameters.
     * •———————————————————————————————————————————————————————• */

    public class UseNamedArguments
    {
        public void Caller()
        {
            Person P = new Person("Tim", "Smith", 37);
        }
    }
}
