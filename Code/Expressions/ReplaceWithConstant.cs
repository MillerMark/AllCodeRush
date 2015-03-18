using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.Expressions
{
	/* •———————————————————————————————————————————————————————•
			Feature: Replace With Constant
        
			Use Case: Replaces an expression with a reference 
			to a constant with the same value.
         
			Available: When the caret is on a string or a number and 
			the current class/type has a constant initialized to the 
			same string or number.
        
			See also: Replace With Local, Introduce Constant
		 •———————————————————————————————————————————————————————• */

	public class ReplaceWithConstant
	{
		const double PI = 3.14;
		public double GetCircleArea(int radius)
		{
			return radius * radius * 3.14;
		}
	}
}
