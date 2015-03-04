using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.Methods
{
    /* •———————————————————————————————————————————————————————•
     * Feature: Make Member Static
     * 
     * Use Case: Lets you make a member static and updates all 
     * references accordingly.
     *  
     * Available: When the cursor is on a non-static method 
     * declaration. The method shouldn't reference instance 
     * members of its class.
     * 
     * See also: Make Member Non-Static
     * •———————————————————————————————————————————————————————• */

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
