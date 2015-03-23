using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.Methods
{
	/* •———————————————————————————————————————————————————————•
			Feature: Extract Method
        
			Use Case: Let's you extract selected code to a new method. 
			Inserts the appropriate calling code into the source 
			method or property.
         
			Available: 
			 - When one or more statements are selected.
			 - When an expression is selected.
         
			See also: Inline Method
		 •———————————————————————————————————————————————————————• */

	public class ExtractMethod
	{
		public double GetWaterTankCapacity(int Length, int Width, int Height)
		{
			return Length * Width * Height;
		}
	}
}
