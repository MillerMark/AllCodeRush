using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.Methods
{
    public class MakeMemberStatic
    {
        // Place caret in signature of function and invoke 'Make Member Static'
        public double GetCircleArea(int radius)
        {
            return Math.PI * radius * radius;
        }

        #region Additional
        // Note: The following function cannot be made static because it refernces an instance member
        private int _InstanceMember;
        public int MethodUsingInstanceMember()
        {
            return _InstanceMember;
        }
        #endregion
    }
}
