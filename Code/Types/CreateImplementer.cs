using System;
using System.Linq;
using System.Collections.Generic;

namespace AllCodeRush.Code.Types
{
	/* •—————————————————————————————————————————————————————————•
	    Feature: Create Implementer
         
	    Use Case: Creates a new Class which implements the given Interface.
	 
			Available: When the edit cursor or caret is on a class 
	    name within its declaration.  
		 •—————————————————————————————————————————————————————————• */
	public interface ILogger
	{
		void Log(string Message);
		bool Enabled { get; set; }
	}
}
