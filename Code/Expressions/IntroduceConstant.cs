using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.Expressions
{
	/* •———————————————————————————————————————————————————————•
			Feature: Introduce Constant
        
			Use Case: Declares a new constant initialized to 
			the value of the string or number at the caret.
         
			Available: When the caret is on a number or string literal.
        
			See also: Inline Constant, Introduce Constant (Local)
		 •———————————————————————————————————————————————————————• */

	public class IntroduceConstant
	{
		public double GetCircleArea(int radius)
		{
			return 3.14 * radius * radius;
		}
	}
}
