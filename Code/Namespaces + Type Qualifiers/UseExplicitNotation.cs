using System;
using System.Linq;
using System.Collections.Generic;

namespace AllCodeRush.Code.NamespacesTypeQualifiers
{
	/* •—————————————————————————————————————————————————————————•
	    Feature: Use Explicit Notation
         
	    Use Case: Converts a short form of a nullable type 
	    reference to its explicit form.
	 
			Available: When the cursor is on a short form reference to 
	    the nullable type.  
		 •—————————————————————————————————————————————————————————• */

	public class UseExplicitNotation
	{
		public int? PlanetCount;
		private string SystemDescription()
		{
			if (PlanetCount.HasValue)
				return String.Format("System with {0} planets", PlanetCount);
			else
				return "We do not know how many planets are in this unexplored system";
		}
	}

}
