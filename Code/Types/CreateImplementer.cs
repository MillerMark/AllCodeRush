using System;
using System.Linq;
using System.Collections.Generic;

namespace AllCodeRush.Code.Types
{
	/* 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧�
	    Feature: Create Implementer
         
	    Use Case: Creates a new Class which implements the given Interface.
	 
			Available: When the edit cursor or caret is on a class 
	    name within its declaration.  
		 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧� */
	public interface ILogger
	{
		void Log(string Message);
		bool Enabled { get; set; }
	}
}
