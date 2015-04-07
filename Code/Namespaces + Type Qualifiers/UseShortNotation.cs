using System;
using System.Linq;
using System.Collections.Generic;

namespace AllCodeRush.Code.NamespacesTypeQualifiers
{
	/* •—————————————————————————————————————————————————————————•
	    Feature: Use Short Notation
         
	    Use Case: Converts the explicit form of a nullable type 
	    reference to its short form.
	 
			Available: When the cursor is on an explicit form 
	    reference to the nullable type.  
		 •—————————————————————————————————————————————————————————• */

	public class UseShortNotation
	{
		Nullable <bool> IsCatAlive;

		private void CheckOnShrodingersCat()
		{
			if (!IsCatAlive.HasValue)
				Console.WriteLine("Anything is still possible.");
			else
			{
				if (IsCatAlive.Value)
				{
					Console.WriteLine("Hurrah, the cat is alive and well.");
				}
				else
				{
					Console.WriteLine("The cat isn't moving.");
				}
			}

		}

	}
}
