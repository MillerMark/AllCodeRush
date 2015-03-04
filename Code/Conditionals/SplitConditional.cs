using System;

namespace AllCodeRush.Code.Conditionals
{
  /* •———————————————————————————————————————————————————————•
      Feature: Split Conditional
                                                            
      Use Case: Lets you break apart a single conditional
      if-statement having multiple expressions into two
      or more conditionals.
                                                            
      Available: When the caret is on the "if" keyword of
      an if-statement having two or more child expressions.
    
      See Also: Combine Conditionals (nested and parallel)
     •———————————————————————————————————————————————————————• */

  public class SplitConditional
  {
    public static bool AllTrue(bool a, bool b, bool c)
    {
      if (a && b && c)
        return true;

      return false;
    }

    public static bool AnyTrue(bool a, bool b, bool c)
    {
      if (a || b || c)
        return true;

      return false;
    }

    public static bool SomeTrue(bool a, bool b, bool c)
    {
      if (a && b || c)
        return true;

      return false;
    }
  }
}
