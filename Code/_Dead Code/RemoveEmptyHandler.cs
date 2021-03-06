using System;

namespace AllCodeRush.Code.DeadCode
{

  /* 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧�
      Feature: Remove Empty Handler.
          
      Use Case: Removes an empty event handler and also removes 
      its corresponding hook-up code.
  	 
      Available: When the caret is on the declaration of an 
      event handler with an empty method body. 
     風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧� */
  public class RemoveEmptyHandler
  {
    public event EventHandler Click;
    public RemoveEmptyHandler()
    {
    }
  }
}
