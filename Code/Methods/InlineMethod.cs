using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.Methods
{
	/* 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧�
			Feature: Inline Method
        
			Use Case: Lets you replace call to a method with the 
			method's body.
         
			Available: When the caret is on the method name, within 
			its call or declaration.
        
			See also: Extract Method, Inline Method (and Delete)
		 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧� */

	public class InlineMethod
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
