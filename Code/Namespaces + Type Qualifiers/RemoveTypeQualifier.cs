using System;
using System.Linq;
using System.Collections.Generic;

namespace AllCodeRush.Code.NamespacesTypeQualifiers
{
	/* •—————————————————————————————————————————————————————————•
	    Feature: Remove Type Qualifier
         
	    Use Case: Removes a type qualifier (namespaces) from a 
	    type reference and ensures the proper namespace reference 
	    is added to the file if needed.
	 
			Available: When the edit cursor or caret is on a type 
	    reference that contains namespace information. 
		 •—————————————————————————————————————————————————————————• */

	public class RemoveTypeQualifier
	{
		private void BuildSolarSystemSimulation()
		{
      Space.SolarSystem Sol = new Space.SolarSystem();
			Sol.Planets.Add(new Space.Bodies.Planets.Planet {Name = "Earth"});
			Sol.Planets.Add(new Space.Bodies.Planets.Planet {Name = "Jupiter"});
			Sol.Planets.Add(new Space.Bodies.Planets.Planet {Name = "Mercury"});
			Sol.Planets.Add(new Space.Bodies.Planets.Planet {Name = "Venus"});
		}
	}
}
