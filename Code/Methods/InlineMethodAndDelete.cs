using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.Methods
{
	/* •———————————————————————————————————————————————————————•
			Feature: Inline Method (and Delete)
        
			Use Case: Lets you replace calls to a method with the 
			method's body. The method is then deleted.
         
			Available: When the caret is on the method name, within 
			its call or declaration.
        
			See also: Extract Method, Inline Method
		 •———————————————————————————————————————————————————————• */
	public class InlineMethodAndDelete
	{
		public double GetVolumeOfCylinder(int radius, int height)
		{
			return GetAreaOfCircle(radius) * height;
		}
		private static double GetAreaOfCircle(int radius)
		{
			return radius * radius * Math.PI;
		}
	}
}
