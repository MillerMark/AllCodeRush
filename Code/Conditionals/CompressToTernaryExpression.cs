using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.Conditionals
{
  /* •———————————————————————————————————————————————————————•
      Feature: Compress To Ternary Expression
        
      Use Case: Lets you convert an if/else conditional into a
      Ternary Expression.
         
      Available: When the caret is on a if statement that has the 
      corresponding else block. 
       - Both if and else blocks should contain one statement. 
       - These statements should be similar assignments or method 
         calls with different arguments.
        
      Related Refactorings: Expand Ternary Condition
     •———————————————————————————————————————————————————————• */

  public class CompressToTernaryExpression
  {
    public static string isPositive(int input)
    {
      if (input >= 0)
        return "positive";
      else
        return "negative";
    }
  }
}
