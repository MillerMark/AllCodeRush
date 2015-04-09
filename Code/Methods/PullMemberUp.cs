using System;

namespace AllCodeRush.Code.Methods
{
  /* •————————————————————————————————————————————————————————•
      Feature: Pull Member Up
        
      Use Case: Lets you move a member up to any base type.
         
      Available: When the caret is on a class member, provided 
      that the base class is declared in the solution.
     •————————————————————————————————————————————————————————• */

  public class Shape2d
	{
    protected double Height;
    protected double Width;
	}

	public class Projection3d : Shape2d
	{
    private double Depth;
    public double CalculateArea()
		{
			return Width * Height;
		}
    public double CalculateVolume()
		{
			return CalculateArea() * Depth;
		}
	}
}
