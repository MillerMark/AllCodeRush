using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.Conditionals
{
  /* •—————————————————————————————————————————————————————————————•
      Feature: Expand Null Coalescing Operation
        
      Use Case: Lets you convert a Null Coalescing Operation into an 
      equivalent Ternary Expression.
         
      Available: When the edit cursor, or caret is on a statement 
      that uses the ?? operator.
        
      Related Refactorings: Compress To Null Coalescing Operation
           
      For more information on formatting code, see the "Code 
      Formatting" video.
     •—————————————————————————————————————————————————————————————• */
  public class ExpandNullCoalescingOperation
  {
    private string _value;
    public string GetValue()
    {
      return _value ?? "Default";
    }
  }
}
