using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.Expressions
{
	/* •———————————————————————————————————————————————————————•
			Feature: Inline Temp
        
			Use Case: Replaces all references to a local 
			variable with its initial value.
         
			Available: When the caret is on the declaration or 
			reference of a local variable. The variable should have 
			been assigned a value only once.
        
			See also: Introduce Local
		 •———————————————————————————————————————————————————————• */

	public class InlineTemp
	{
		public double GetCylinderVolume(int radius, int height)
		{
			int h = height;
			int r = radius;
			return r * r * h * Math.PI;
		}
	}
}
