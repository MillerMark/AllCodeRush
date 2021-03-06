using System;

namespace AllCodeRush.Code.Methods
{
  public class CreateOverload
	{
    /* 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧�
  			Feature: Create Overload
          
  			Use Case: Creates an overload of a method allowing 
  			you to exclude specific parameters.
           
  			Available: When the caret is on a method declaration.
  		 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧� */

    /// <summary>
    /// Logs the specified message to the active logging engine.
    /// </summary>
    /// <param name="id">The ID of the event</param>
    /// <param name="dateTime">The time of the event</param>
    /// <param name="message">The message to log</param>
    public void Log(int id, DateTime dateTime, string message)
		{
      ActiveLogger.Log(id, dateTime, message);
		}
	}
}
