using System;

namespace AllCodeRush.Code.Conditionals
{
  class ConditionalTemplates
  {
    public bool TemplatesForWorkingWithConditionals(bool testValue1, bool testValue2, bool testValue3)
    {
      // Basics...
      // b == {}
      // r == return

      // Primitives:
      //    t == true
      //    f == false
      //    n == null (or Nothing in VB)
      //    " == ""
      //    ' == ''
      //    th == this (or Me in VB)
      //    me == this (or Me in VB)
      //    se == String.Empty
      //    1 == 1
      //    0 == 0
      //    -1 == -1

      // if, ifb, ifn, ifa

      // else blocks: l, lf, lb, blb, 

      // else return: lr?Primitive?

      // Create on demand: cod

      // s?Primitive?  (both on an empty line and inside an expression)

      
      // With identifiers copied to the clipboard:
      // ifa, ifab, ifna
      // ls?Primitive?

      // inr, inx, inr?Primitive?, 

      // n?Primitive?

      // and, or
      // Paren embedding.
      
      if (testValue1 || testValue2 && testValue3)
        testValue1 = false;

      // inr?Primitive?
      
      return true;
    }

    private void WorkWithControl(MyControl myControl)
    {
      myControl = null;
      myControl.Close();
    }
  }
}
