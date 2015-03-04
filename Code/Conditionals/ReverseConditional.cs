using System;
using AllCodeRush.Code.Conditionals.Support;

namespace AllCodeRush.Code.Conditionals
{
  public class ReverseConditional
  {
    public bool IsNorthWestOrSouthEast(double angle)
    {
      NormalizeAngle(ref angle);

      if (angle >= 90 && (angle >= 270 || angle <= 180))
        return false;
      else
        return true;
    }

    private void NormalizeAngle(ref double angle)
    {
      while (angle < 0)
        angle += 360.0;
      while (angle > 360.0)
        angle -= 360.0;
    }
  }
}
