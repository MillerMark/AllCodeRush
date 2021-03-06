using System;

namespace AllCodeRush.Code.DeadCode
{
  /* 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧�
        Feature: Remove Redundant Delegate Creation.
            
        Use Case: Removes the unnecessary event delegate creation 
        call around an event handler hook-up.
    	 
        Available: When the caret is on the delegate creation 
        code. 
       風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧� */
  public class RemoveRedundantDelegateCreation
  {
    public event EventHandler Click;
    public RemoveRedundantDelegateCreation()
    {
      Click += new EventHandler(DoSomething);
    }

    void DoSomething(object sender, EventArgs e)
    {
      throw new NotImplementedException();
    }
  }
}
