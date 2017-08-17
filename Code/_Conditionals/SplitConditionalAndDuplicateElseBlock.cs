using System;

namespace AllCodeRush.Code.Conditionals
{
  /* 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧�
      Feature: 
                                                            
      Use Case: 
                                                            
      Available: 
    
      Related Refactorings: Combine Conditionals
   
      For more information on formatting code, see the "Code 
      Formatting" video.
     風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧� */
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
