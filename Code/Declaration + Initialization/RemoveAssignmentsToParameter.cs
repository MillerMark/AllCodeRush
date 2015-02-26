using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.DeclarationInitialization
{
    public class RemoveAssignmentsToParameter
    {
        public int Add(int left, int right)
        {
            left = left + right;
            return left;
        }
    }
}
