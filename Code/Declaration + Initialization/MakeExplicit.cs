using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.DeclarationInitialization
{
    /* •———————————————————————————————————————————————————————•
     * Feature: Make Explicit
     * 
     * Use Case: Lets you convert an implicitly-typed local 
     * variable to a variable with an explicit type.
     *  
     * Available: When the caret is on an implicit variable 
     * declaration.
     * 
     * See also: Make Implicit
     * •———————————————————————————————————————————————————————• */

    public class MakeExplicit
    {
        public string GetDescription()
        {
            var Description = "A string";

            return Description;
        }
    }
}
