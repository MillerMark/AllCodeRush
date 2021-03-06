using System;

namespace AllCodeRush.Code.DeclarationInitialization
{
  /* 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧藍
      Feature: Make Explicit (and Name Anonymous Type)
        
      Use Case: Replaces an anonymous type with a newly-declared 
      type, and changes the var keyword to the newly named type. 
      Useful when you want to pass an anonymous type as a 
      parameter to a method.
         
      Available: When the caret is on an anonymous type.
    
      See also: Name Anonymous Type, Make Explicit
     風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧藍 */

  public class MakeExplicitAndNameAnonymousType
	{
		private void Test()
		{
			var passengerVehicle = new { wheelCount = 4, model = "SuperBolt 2000", price = 45000m, weight = 2000d };
		}
	}
}
