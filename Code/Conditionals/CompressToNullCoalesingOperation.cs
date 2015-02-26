using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.Conditionals
{
    public class CompressToNullCoalesingOperation
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name == null ? "Default" : _name;
            }
        }
    }
}
