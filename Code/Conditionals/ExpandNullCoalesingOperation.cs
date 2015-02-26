using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.Conditionals
{
    public class ExpandNullCoalesingOperation
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name ?? "Default";
            }
        }
    }
}
