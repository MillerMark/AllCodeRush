using System;

namespace AllCodeRush.Code.DeadCode
{
	/* •———————————————————————————————————————————————————————•
		Feature: Remove Unused Parameter
        
		Use Case: Removes an unused parameter from a method 
	  declaration and updates all calls accordingly.
	 
	  Available: When the caret is within the declaration of a 
	  method parameter and that parameter is unused within the 
	  method. 
	 •———————————————————————————————————————————————————————• */
	public class RemoveParameter
	{
		public decimal TimeToDestination(decimal DistanceInMiles, decimal SpeedInMPH, DateTime StartTime)
		{
			return DistanceInMiles / SpeedInMPH;
		}
	}
}
