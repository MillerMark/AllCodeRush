using System;

namespace AllCodeRush.Code.DeadCode
{
	/* 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧�
		Feature: Remove Redundant Destructor.
        
		Use Case: Removes an empty Destructor.

	  Available: When the caret is on a Destructor declaration. 
	 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧� */
	public class RemoveRedundantDestructor
	{
		~RemoveRedundantDestructor()
		{
			// This destructor serves no purpose.
		}
	}
}
