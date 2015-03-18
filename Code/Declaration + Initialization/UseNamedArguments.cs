using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.DeclarationInitialization
{
	/* •———————————————————————————————————————————————————————•
			Feature: Use Named Arguments
        
			Use Case: Converts a method call with positional 
			arguments into a named-argument call.
         
			Available: When the caret is on a method call with 
      parameters.
		 •———————————————————————————————————————————————————————• */

	public class UseNamedArguments
	{
		public void Caller()
		{
			Person P = new Person("Tim", "Smith", 37);
		}
	}
}
