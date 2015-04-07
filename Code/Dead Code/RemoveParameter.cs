using System;

namespace AllCodeRush.Code.DeadCode
{
	/* 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧�
		Feature: Remove Unused Parameter.
        
		Use Case: Removes an unused parameter from a method 
	  declaration and updates all calls accordingly.
	 
	  Available: When the caret is within the declaration of a 
	  method parameter and that parameter is unused within the 
	  method. 
	 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧� */
	public class RemoveParameter
	{
		public decimal TimeToDestination(decimal distance, decimal velocity, DateTime startTime)
		{
			return distance / velocity;
		}
	}
}
