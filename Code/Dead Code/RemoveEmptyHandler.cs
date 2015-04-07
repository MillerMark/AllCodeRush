using System;

namespace AllCodeRush.Code.DeadCode
{

  /* •—————————————————————————————————————————————————————————•
      Feature: Remove Empty Handler.
          
      Use Case: Removes an empty event handler and also removes 
      its corresponding hook-up code.
  	 
      Available: When the caret is on the declaration of an 
      event handler with an empty method body. 
     •—————————————————————————————————————————————————————————• */
  public class RemoveEmptyHandler
  {
    public event EventHandler Click;
    public RemoveEmptyHandler()
    {
      Click += DoNothing;
    }

    void DoNothing(object sender, EventArgs e)
    {
      throw new NotImplementedException();
    }
  }
}
