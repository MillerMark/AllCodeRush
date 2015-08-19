using System;

namespace AllCodeRush.Code.NamespacesTypeQualifiers
{

	/* •—————————————————————————————————————————————————————————•
			Feature: Remove Type Qualifier (Remove All)
         
			Use Case: Removes all type qualifiers in a file that match 
	    the type qualifier at the caret.
	 
			Available: When the edit cursor or caret is on a type 
			reference that contains namespace information. 
		 •—————————————————————————————————————————————————————————• */

	public class RemoveTypeQualifierRemoveAll
	{
		public class RemoveTypeQualifier
		{
      public static Space.Galaxy PartialGalaxySimulation()
			{
				Space.Galaxy Galaxy = new Space.Galaxy();
				Galaxy.Stars.Add(new Space.Bodies.Star { Name = "Sol" });
				Galaxy.Stars.Add(new Space.Bodies.Star { Name = "Altair" });
				Galaxy.Stars.Add(new Space.Bodies.Star { Name = "Eranin" });
				Galaxy.Stars.Add(new Space.Bodies.Star { Name = "Wolf 359" });
        return Galaxy;
			}
		}
	}
}
