using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.Expressions
{
	/* •———————————————————————————————————————————————————————•
			Feature: Inline Recent Assignment
        
			Use Case: Replaces the identifier at the caret 
			with its most recent assignment.
         
			Available: When the caret is on an variable or a property. 
			Note: There should be an assignment to this variable or 
			property prior to the current statement.
		 •———————————————————————————————————————————————————————• */

	public class InlineRecentAssignment
	{
		private void TestMethod()
		{
			string Command = ReadCommand();
			
			Execute(Command);
			
			Command = ReadCommand();
			
			Execute(Command);
		}

		#region Support
		private string ReadCommand()
		{
			return string.Empty;
		}
		private void Execute(string Command)
		{
			// Execute command here
		}
		#endregion
	}
}
