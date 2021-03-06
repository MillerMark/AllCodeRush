using System;

namespace AllCodeRush.Code.Methods
{
  /* 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧藍
      Feature: Inline Method (and delete)
        
      Use Case: Replace a method call with that method's body,
      and deletes the original method.
         
      Available: When the caret is on a method call that is 
      called from no other locations in the solution.
        
      See also: Extract Method, Inline Method
     風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧藍 */

  public class InlineMethodAndDelete
	{
    public double GetVolumeOfPrism(double @base, double height, double depth)
    {
      return GetAreaOfTriangle(@base, height) * depth;
    }

    private static double GetAreaOfTriangle(double @base, double height)
		{
      return (@base * height) / 2;
		}
	}
}
