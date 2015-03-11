using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.Expressions
{
	/* •———————————————————————————————————————————————————————•
			Feature: Introduce Local
        
			Use Case: Lets you create a new local variable 
			initialized with the selected expression.
         
			Available: When an expression is selected.
        
			See also: Inline Local, Introduce Local (Replace All)
		 •———————————————————————————————————————————————————————• */

	public class IntroduceLocal
	{
		public double GetCylinderVolume(int radius, int height)
		{
			return radius * radius * Math.PI * height;
		}
	}
}
