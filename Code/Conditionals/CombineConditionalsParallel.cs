using System;

namespace AllCodeRush.Code.Conditionals
{
  public class CombineConditionalsParallel
  {
    public static bool AnyTrue(bool a, bool b, bool c)
    {
      if (a)
        return true;
      if (b)
        return true;
      if (c)
        return true;

      return false;
    }
  }
}
