using System;

namespace AllCodeRush.Code.DeclarationInitialization
{
	/* 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧�
			Feature: Use Named Arguments
        
			Use Case: Converts a method call with positional 
			arguments into a named-argument call.
         
			Available: When the caret is on a method call with 
      parameters.
		 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧� */

	public class UseNamedArguments
	{
		public void Caller()
		{
      Calculator.GetTotalPrice(100, 1, 50);
		}
	}
}
