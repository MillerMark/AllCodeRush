using System;
using System.Linq;
using System.Collections.Generic;

namespace AllCodeRush.Code.NamespacesTypeQualifiers
{
	/* •—————————————————————————————————————————————————————————•
	    Feature: Introduce Alias
         
	    Use Case: Introduces a new file-scoped alias for the 
	    current type or namespace name, and replaces it with the 
	    newly-created alias.
	 
			Available: When the caret is on a reference to a type. 
	    This reference should contain namespace information. 
		 •—————————————————————————————————————————————————————————• */
	public class IntroduceAlias
	{
		public Space.SolarSystem BuildSimpleSolarSystem()
		{
			Space.SolarSystem Sol = new Space.SolarSystem();
			Sol.Stars.Add(new Space.Bodies.Star() {Name="Sol"});
			Sol.Planets.Add(new Space.Bodies.Planets.Planet() { Name = "Earth" });
			return Sol;
		}
	}
}
