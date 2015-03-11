using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace AllCodeRush.Code.DeclarationInitialization
{
	/* •———————————————————————————————————————————————————————•
		  Feature: Add Missing Constructors
        
		  Use Case: Adds base class constructors to a descendant class
         
		  Available: When the caret is on a class declaration within 
		  its name, provided that the base class contains at least 
		  one constructor that is not implemented in the current class. 
		 •———————————————————————————————————————————————————————• */

	public class AddMissingConstructors : baseclass
	{

	}

	#region Misc
	public class baseclass
	{
		public baseclass(int height)
		{

		}
		public baseclass(int height, int width)
		{

		}
	}
	#endregion
}
