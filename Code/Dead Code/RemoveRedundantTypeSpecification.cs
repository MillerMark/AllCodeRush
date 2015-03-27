using System;

namespace AllCodeRush.Code.DeadCode
{
	/* •———————————————————————————————————————————————————————•
		Feature: Remove Redundant Type Specification
        
		Use Case: Removes redundant type specifications from 
	  lambda expression parameters.

	  Available: When the caret is within a lambda expression 
	  parameters list. 
	 •———————————————————————————————————————————————————————• */
	public class RemoveRedundantTypeSpecification
	{
		static void Main(string[] args)
		{
			X((int a, int b, int c) =>
			{
				int x = a + b + c;
			});
		}

		#region Support
		private static void X(Action<int, int, int> action)
		{

		}
		#endregion
	}
}
