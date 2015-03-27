using System;

namespace AllCodeRush.Code.DeadCode
{
	/* •———————————————————————————————————————————————————————•
		Feature: Remove Redundant Destructor.
        
		Use Case: Removes an empty Destructor.

	  Available: When the caret is on a Destructor declaration. 
	 •—————————————————————————————————————————————————————————• */
	public class RemoveRedundantDestructor
	{
		~RemoveRedundantDestructor()
		{
			// This destructor serves no purpose.
		}
	}
}
