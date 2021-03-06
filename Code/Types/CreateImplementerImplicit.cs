using System;
using System.Linq;
using System.Collections.Generic;

namespace AllCodeRush.Code.Types.CreateImplementerExplicit
{
	/* 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧�
	    Feature: Create Implementer (Explicit)
         
	    Use Case: Creates a class explicitly implementing a 
	    current interface.
	 
			Available: When the caret is on an interface name within 
	    an interface declaration.  
		 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧� */
	public interface ILogger
	{
		void Log(string Message);
		bool Enabled { get; set; }
	}
}
