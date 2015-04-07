using System;
using System.Linq;
using System.Collections.Generic;

namespace AllCodeRush.Code.NamespacesTypeQualifiers
{

	/* •—————————————————————————————————————————————————————————•
			Feature: Remove Type Qualifier (Replace All)
         
			Use Case: Removes all type qualifiers in a file that match 
	    the type qualifier at the caret.
	 
			Available: When the edit cursor or caret is on a type 
			reference that contains namespace information. 
		 •—————————————————————————————————————————————————————————• */
	public class RemoveTypeQualifierReplaceAll
	{
		public class RemoveTypeQualifier
		{
			private void BuildGalaxySimulation()
			{
				Space.Galaxy Galaxy = new Space.Galaxy();
				Galaxy.Stars.Add(new Space.Bodies.Star { Name = "Sol" });
				Galaxy.Stars.Add(new Space.Bodies.Star { Name = "Altair" });
				Galaxy.Stars.Add(new Space.Bodies.Star { Name = "Eranin" });
				Galaxy.Stars.Add(new Space.Bodies.Star { Name = "Wolf 359" });
			}
		}
	}
}
