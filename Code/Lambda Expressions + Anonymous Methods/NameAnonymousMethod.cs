using System;
using System.Linq;
using System.Collections.Generic;

namespace AllCodeRush.Code.LambdaExpressionsAnonymousMethods
{
  /* 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧�
      Feature: Name Anonymous Method.
        
      Use Case: Converts an anonymous method to an instance 
      method.
         
      Available: When the caret is on the delegate keyword 
      within an anonymous method declaration. 
      The method should not use local variables.
    
      See also: Inline Delegate
     風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧� */
  public class NameAnonymousMethod
	{
		private void TestMethod()
		{
			Func<int, int, int> adder1 = delegate(int x, int y)
			{
				return x + y;
			};
		}
	}
}
