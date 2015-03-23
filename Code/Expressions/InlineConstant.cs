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

	public class InlineConstant
	{
		public double GetCircleArea(int radius)
		{
			const double PI = 3.14;
			return PI * radius * radius;
		}
	}
}
