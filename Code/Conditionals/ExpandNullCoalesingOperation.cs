using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.Conditionals
{
    /* 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧�
     * Feature: Expand Null Coalescing Operation
     * 
     * Use Case: Lets you convert a Null Coalescing Operation into an 
     * equivalent Ternary Expression.
     *  
     * Available: When the edit cursor, or caret is on a statement 
     * that uses the ?? operator.
     * 
     * See also: Compress To Null Coalescing Operation
     * 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧� */

    public class ExpandNullCoalesingOperation
    {
        private string _Value;
        public string GetValue()
        {
            return _Value ?? "Default";
        }
    }
}
