using System;
using System.Linq;
using System.Collections.Generic;

namespace AllCodeRush.Code.Types
{
	/* 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧�
			Feature: Seal Class
	         
			Use Case: Makes the current class sealed (uninheritable).
		 
			Available: When the caret is on a class declaration. 
	    Unavailable if class is an ancestor of another class.
		風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧� */

	// This class can be sealed.
	public class SimpleClass : Ancestor
  {

	}

	// This class cannot be sealed.
	public class Ancestor
	{
		
	}
}
