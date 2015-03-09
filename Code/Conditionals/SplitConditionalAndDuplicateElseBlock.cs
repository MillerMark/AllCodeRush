using System;

namespace AllCodeRush.Code.Conditionals
{
  /* •———————————————————————————————————————————————————————•
      Feature: 
                                                            
      Use Case: 
                                                            
      Available: 
    
      Related Refactorings: Combine Conditionals
     •———————————————————————————————————————————————————————• */
  public class SplitConditionalAndDuplicateElseBlock
  {
    public static bool AnyTrue(bool a, bool b, bool c)
    {
      if (a || b || c)
        return true;
      else 
        return false;
    }
  }
}
