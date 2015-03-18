using System;

namespace AllCodeRush.Code.DeclarationInitialization
{
  /* •———————————————————————————————————————————————————————————•
      Feature: Decompose Initializer
        
      Use Case: Lets you convert an object initializer to the 
      object constructor call, followed by lines that initialize 
      object properties individually. Can turn a very long line 
      of code into several shorter lines of code.
         
      Available: When the cursor is placed on the name of the 
      initialized object. 
        
      See also: Convert To Initializer
     •———————————————————————————————————————————————————————————• */

  public class DecomposeInitializer
	{
		public Building CreateBuilding()
		{
      return new Building() { Floors = 5, Sublevels = 2, Name = "Omni Tower", MaxOccupancy = 700 };
		}
	}
}
