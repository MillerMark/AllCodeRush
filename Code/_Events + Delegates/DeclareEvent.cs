using System;

namespace AllCodeRush.Code.EventsDelegates
{
  /* 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧�
      Feature: Declare Event
        
      Use Case: Declares the event at the caret.
         
      Available: When the caret is on an undeclared event 
      reference.
        
      See also: Declare Event Handler
     風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧� */

  public delegate void MessageReceivedHandler(string message);

  public class DeclareEvent
  {
    public void TestMethod(OtherClass otherClass)
    {
      otherClass.MessageReceived += new MessageReceivedHandler(HandleMessageReceived);
    }

    private void HandleMessageReceived(string message)
    {
      Console.WriteLine(message);
    }
  }

  public class OtherClass
  {
    public event EventHandler Click;
  }
}
