using System;

namespace AllCodeRush.Code.NamespacesTypeQualifiers
{
  /* 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧�
      Feature: Remove Type Qualifier
         
      Use Case: Removes a type qualifier (namespaces) from a 
      type reference and ensures the proper namespace reference 
      is added to the file if needed.
	 
      Available: When the caret is on a type reference that 
      contains namespace information. 
     風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧� */

  public class RemoveTypeQualifier
	{
    public static Space.SolarSystem BuildSolarSystemSimulation()
		{
      Space.SolarSystem solarSystem = new Space.SolarSystem();
      solarSystem.Planets.Add(new Space.Bodies.Planets.Planet { Name = "Mercury", Angle = 0.1 });
      solarSystem.Planets.Add(new Space.Bodies.Planets.Planet { Name = "Venus", Angle = 177 });
      solarSystem.Planets.Add(new Space.Bodies.Planets.Planet { Name = "Earth", Angle = 23 });
			solarSystem.Planets.Add(new Space.Bodies.Planets.Planet {Name = "Mars", Angle = 25 });
      solarSystem.Planets.Add(new Space.Bodies.Planets.Planet { Name = "Jupiter", Angle = 3 });
      solarSystem.Planets.Add(new Space.Bodies.Planets.Planet { Name = "Saturn", Angle = 27 });
      solarSystem.Planets.Add(new Space.Bodies.Planets.Planet { Name = "Uranus", Angle = 98 });
      solarSystem.Planets.Add(new Space.Bodies.Planets.Planet { Name = "Neptune", Angle = 30 });
      solarSystem.Planets.Add(new Space.Bodies.Planets.Planet { Name = "Pluto", Angle = 120 });

      // Doh! Pluto has failed to clear debris from its orbit...
      solarSystem.Planets.RemoveAt(solarSystem.Planets.Count - 1);

      return solarSystem;
		}
	}
}
