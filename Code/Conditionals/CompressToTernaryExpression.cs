using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.Conditionals
{
  /* 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧�
      Feature: Compress To Ternary Expression
        
      Use Case: Lets you convert an if/else conditional into a
      Ternary Expression.
         
      Available: When the caret is on a if statement that has the 
      corresponding else block. 
       - Both if and else blocks should contain one statement. 
       - These statements should be similar assignments or method 
         calls with different arguments.
        
      Related Refactorings: Expand Ternary Condition
           
      For more information on formatting code, see the "Code 
      Formatting" video. 
     風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧� */

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
