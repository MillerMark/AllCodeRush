using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.DeclarationInitialization
{
    /* •———————————————————————————————————————————————————————•
     * Feature: Name Anonymous Type 
     * 
     * Use Case: Lets you replace an anonymous type with a 
     * newly-declared type.
     *  
     * Available: When the caret is on an anonymous type.
     * •———————————————————————————————————————————————————————• */

    public class NameAnonymousType
    {
        private void Test()
        {
            var person = new { id = 1, name = "Nick Johnson" };
        }
    }
}
