using System;
using System.Collections.Generic;

namespace AllCodeRush.Code.EventsDelegates
{
  /* ���������������������������������������������������������
      Feature: Declare Delegate
        
      Use Case: Declares the delegate at the caret.
         
      Available: When the caret is on an undeclared delegate.
        
      See also: Declare EventArgs Descendant, Create Event 
      Trigger
     ��������������������������������������������������������� */

  public class DeclareDelegate
  {
    public event HoloLensEventHandler HeadMoved;
  }
}