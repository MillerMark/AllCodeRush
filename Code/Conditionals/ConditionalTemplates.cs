using System;

namespace AllCodeRush.Code.Conditionals
{
  public class MyControl
  {
    public bool Visible { get; set; }
    public bool Checked { get; set; }
    public bool Enabled { get; set; }
    public bool Sorted { get; set; }
    public int Height { get; set; }
    public int Width { get; set; }
    public int Count { get; set; }
    public int Length { get; set; }
    public int Top { get; set; }
    public int Left { get; set; }
    public int Right { get; set; }
    public int Bottom { get; set; }
    public MyControl Parent { get; set; }
    public System.Drawing.Rectangle ClientRectangle { get; set; }
    public string Name { get; set; }
    public string Hint { get; set; }

    public void Clear()
    {
      
    }
    public void Dispose()
    {
      
    }
    public void Close()
    {
      
    }
  }
  class ConditionalTemplates
  {
    private bool TemplatesForWorkingWithConditions(bool testValue1, bool testValue2, bool testValue3)
    {
      // Basics...
      // r == return
      // b == {}

      // Primitives:
      //    t == true
      //    f == false
      //    n == null (or Nothing in VB)
      //    0 == 0
      //    " == ""
      //    ' == ''
      
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
