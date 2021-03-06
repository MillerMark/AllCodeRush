using System;

namespace AllCodeRush.Code.EventsDelegates
{
  /* 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧�
        Feature: Declare EventArgs Descendant
          
        Use Case: Declares a descendant of the EventArgs 
        class, useful for creating custom events.
           
        Available: When the caret is on an undeclared event 
        args reference inside a delegate declaration.
          
        See also: Declare Event Handler, Declare Event Trigger, 
        Declare Initialized Property
       風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧� */
  public class DeclareEventArgsDescendant
  {
    // TODO: HoloLensEventArgs should have a Position property (of type Point3D)
    public delegate void HoloLensEventHandler(object sender, HoloLensEventArgs ea);
  }
  
}
