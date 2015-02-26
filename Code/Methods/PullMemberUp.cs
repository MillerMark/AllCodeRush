using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.Methods
{
    public class BaseClass
    {
        
    }
    public class PullMemberUp:BaseClass
    {
        public void UsefulMethod()
        {
            
        }

        private void CallingMethod()
        {
            UsefulMethod();
        }
    }
}
