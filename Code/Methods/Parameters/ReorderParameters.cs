using System;

namespace AllCodeRush.Code.Methods.Parameters
{
  public enum Direction
  {
    North,
    NorthEast,
    East,
    SouthEast,
    South,
    SouthWest,
    West,
    NorthWest
  }
  /* •———————————————————————————————————————————————————————•
      Feature: Reorder Parameters
          
      Use Case: Reorders method parameters, updating all 
      calls throughout the solutoin as needed.
           
      Available:  
        - When the caret is on a parameter in a method that 
          has two or more parameters (or at least one out 
          parameter).
     •———————————————————————————————————————————————————————• */

  public class ReorderParameters
  {
    private static void SetDirection(double degrees, Direction setting, ref Direction direction, int startAngle)
    {
      double half45 = 45 / 2.0;
      if (degrees >= startAngle - half45 && degrees < startAngle + half45)
        direction = setting;
    }

    public static void GetPolarCoordinates(out double radius, out double degrees, double y, double x, out Direction direction)
    {
      radius = Math.Sqrt((x * x) + (y * y));
      degrees = Math.Atan2(y, x) * 180 / Math.PI;
      direction = Direction.North;

      SetDirection(degrees, Direction.NorthEast, ref direction, 45);
      SetDirection(degrees, Direction.East, ref direction, 90);
      SetDirection(degrees, Direction.SouthEast, ref direction, 135);
      SetDirection(degrees, Direction.South, ref direction, 180);
      SetDirection(degrees, Direction.SouthWest, ref direction, 225);
      SetDirection(degrees, Direction.West, ref direction, 270);
      SetDirection(degrees, Direction.NorthWest, ref direction, 315);
    }
  }

}
