using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.DeclarationInitialization
{
  /* 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧藍
      Feature: Name Anonymous Type 
        
      Use Case: Replaces an anonymous type with a newly-declared 
      type. Useful when you want to pass an anonymous type as a 
      parameter to a method.
         
      Available: When the caret is on an anonymous type.
    
      See also: Make Explicit (and Name Anonymous Type)
     風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧藍 */

  public class NameAnonymousType
	{
		private void Test()
		{
			var person = new { id = 1, name = "Nick Johnson" };
		}
	}
}
