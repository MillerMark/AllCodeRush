using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.Expressions
{
	/* •———————————————————————————————————————————————————————•
			Feature: Inline Recent Assignment
        
			Use Case: Lets you replace the identifier at the caret 
			with its most recent assignment.
         
			Available: When the caret is on an variable or a property. 
			Note: There should be an assignment to this variable or 
			property prior to the current statement.
		 •———————————————————————————————————————————————————————• */

	public class InlineRecentAssignment
	{
		// TODO: Change this into a proper use case.
		public void MethodName()
		{
			// Broken if executed on this line.
			int s = 1;
			// Broken if executed on this line.
			string String1 = "Value - " + s;
			s = 42;
			// Works here though.
			string String2 = "Value - " + s;
		}
	}
}
