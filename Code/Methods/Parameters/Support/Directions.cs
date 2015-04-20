using System;
using System.Collections.Generic;

namespace AllCodeRush.Code.Methods.Parameters
{
  public class Directions
  {
    private readonly List<Step> steps = new List<Step>();
    public Location FinalLocation
    {
      get
      {
        if (steps.Count > 0)
          return steps[steps.Count - 1].Location;
        else
          throw new Exception("Directions are empty");
      }
    }
    public List<Step> Steps
    {
      get
      {
        return steps;
      }
    }
  }
}
