using System;

namespace AllCodeRush.Code.Conditionals
{
  public class CombineConditionalsNested
  {
    public static bool AllTrue(bool a, bool b, bool c)
    {
      if (a)
        if (b)
          if (c)
            return true;
      return false;
    }
  }
}
