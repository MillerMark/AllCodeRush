using System;

namespace AllCodeRush.Code.DeadCode
{
  /* •—————————————————————————————————————————————————————————•
      Feature: Remove Unused Parameters
          
      Use Case: Removes all the unused parameters from a method 
      declaration and updates all calls accordingly.
  	 
      Available: When the caret is within the declaration of a 
      method parameter and that parameter is unused within the 
      method.
      
      See also: Remove Unused Parameter
     •—————————————————————————————————————————————————————————• */
  public class RemoveUnusedParameters
  {
    public double TimeToDestination(DateTime startTime, string userID, bool stopIfTooSlow, 
                                    double distance, double velocity)
    {
      return distance / velocity;
    }

    public DateTime CalculateArrivalTime(string userID)
    {
      DateTime startTime = DateTime.Now;
      return startTime + TimeSpan.FromSeconds(TimeToDestination(startTime, userID, false, 1000, 200));
    }
  }
}
