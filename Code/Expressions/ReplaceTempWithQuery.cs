using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.Expressions
{
    /* 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧�
     * Feature: Replace Temp With Query
     * 
     * Use Case: Lets you replace all references to a local 
     * variable with a call to a property or method that returns 
     * the variable's initial value.
     *  
     * Available: When the caret is on a local variable 
     * declaration. The variable should be initialized right in the declaration statement.
     * 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧� */

    public class ReplaceTempWithQuery
    {
        private int Foo()
        {
            var a = 1 + 2 + 3 + 4;
            return a;
        }
    }
}
