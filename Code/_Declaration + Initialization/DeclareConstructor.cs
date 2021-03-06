using System;

namespace AllCodeRush.Code.DeclarationInitialization
{
  /* 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧藍
      Feature: Declare Constructor
        
      Use Case: Consume-first declaration of class constructors.
         
      Available: When the caret is on a reference to an 
      undeclared constructor.
   
      Related Features: Declare Field with Initializer,
      Declare Property with Initializer
     風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧藍 */

  public class DeclareConstructor
	{
		public SimplePersonClass GetSamplePerson()
		{
			var Name = "Bob";
			var Age = 37;
			SimplePersonClass person = new SimplePersonClass(Name, Age);
			return person;
		}
	}

  public class SimplePersonClass
  {
  }
}
