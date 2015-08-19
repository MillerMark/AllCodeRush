using System;

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
			Space.SolarSystem solarSystem = new Space.SolarSystem();
			solarSystem.Stars.Add(new Space.Bodies.Star() {Name="Sol"});
			solarSystem.Planets.Add(new Space.Bodies.Planets.Planet() { Name = "Earth" });
			return solarSystem;
		}
	}
}
