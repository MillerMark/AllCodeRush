using System;

namespace AllCodeRush.Code.Expressions
{
	/* •———————————————————————————————————————————————————————•
			Feature: Inline Constant
        
			Use Case: Replaces a constant reference with its 
			defined value, removing the constant declaration if there 
			are no other references to it.
         
			Available: When the caret is on a constant reference.
        
			See also: Introduce Constant, Introduce Constant (Local)
		 •———————————————————————————————————————————————————————• */

	/* Question: Why can this not be invoked from the declaration of the constant */

	public class InlineConstant
	{
		public double GetCircleArea(int radius)
		{
			const double PI = 3.14;
			return PI * radius * radius;
		}
	}
}
