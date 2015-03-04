using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace AllCodeRush.Code.DeclarationInitialization
{
    /* •———————————————————————————————————————————————————————•
     * Feature: Declare Constructor
     * 
     * Use Case: Lets you generate a class Constructor by example.
     *  
     * Available: When the caret is on a reference to an 
     * undeclared constructor.
     * •———————————————————————————————————————————————————————• */

    public class DeclareConstructor
    {
        public SimplePersonClass CreateRory()
        {
            var Name = "Bob";
            var Age = 37;
            SimplePersonClass person = new SimplePersonClass(Name, Age);
            return person;
        }

    }
    #region Misc
    public class SimplePersonClass
    {

    }
    #endregion
}
