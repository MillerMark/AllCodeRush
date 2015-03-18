using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.Expressions
{
	/* 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧�
			Feature: Replace With Local
        
			Use Case: Replaces the selected expression with a 
			reference to a local variable which was previously 
			assigned this value.
         
			Available: When the caret is on a string or a number and 
			there's a local variable initialized to the same string 
			or number.
        
			See also: Introduce Local, Replace with Constant
		 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧� */

	public class ReplaceWithLocal
	{
		public double GetCircleArea(int radius)
		{
			double PI = 3.14;
			return radius * radius * 3.14;
		}
	}
}
