using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace AllCodeRush.Code.DeclarationInitialization
{
    //TODO:  Does not appear to work in 14.2.3
    public class DeclareConstructor
    {
        public SimplePersonClass CreateRory()
        {
            var Name = "Rory";
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
