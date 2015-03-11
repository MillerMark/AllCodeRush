using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.DeclarationInitialization
{
	/* •———————————————————————————————————————————————————————•
		  Feature: Convert To Initializer
        
		  Use Case: Lets you convert lines which set properties of 
		  an object, into an initializer.
         
		  Available: When the caret is placed on the name of an 
		  initialized object, provided that the following line 
		  assigns a value to any property of this object. 
        
		  See also: Decompose Initializer
		 •———————————————————————————————————————————————————————• */

	public class ConvertToInitializer
	{
		public Building CreateBuilding()
		{
			Building building = new Building();
			building.Floors = 5;
			building.Sublevels = 2;
			return building;
		}
	}
}