using System;

namespace AllCodeRush.Code.Methods
{
  /* •———————————————————————————————————————————————————————•
      Feature: Declare Method (Abstract)
        
      Use Case: Lets you generate an abstract method where 
      none exists, based on an existing call to that method.
         
      Available: When the caret is on a statement calling an 
      undeclared method.
        
      See also: Declare Method
     •———————————————————————————————————————————————————————• */

  public abstract class RectangularPrism
	{
    protected double depth;
    public double CalculateVolume(double edge1, double edge2)
		{
			return CalculateBase(edge1, edge2) * depth;
		}
	}
}
