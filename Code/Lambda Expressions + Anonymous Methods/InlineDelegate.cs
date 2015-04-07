using System;
using System.Linq;
using System.Collections.Generic;

namespace AllCodeRush.Code.LambdaExpressionsAnonymousMethods
{
	/* 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧�
			Feature: Inline Delegate.
        
			Use Case: Inlines a delegate creating an anonymous 
	    method. If there are no other references to the delegate 
	    method it is removed.
         
			Available: When the caret is on a delegate method.
    
      See also: Name Anonymous Method
		 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧� */
	public class InlineDelegate
	{
		private int Add(int x, int y)
		{
			return x + y;
		}
		private void AssignCalculations()
		{
			Func<int, int, int> adder1 = Add;
		}
	}
}
