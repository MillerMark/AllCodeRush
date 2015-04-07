using System;

namespace AllCodeRush.Code.DeadCode
{
	/* •———————————————————————————————————————————————————————•
			Feature: Remove Redundant Call.
        
			Use Case 1: - Removes a redundant call to a base 
										constructor.
			Use Case 2: - Removes a redundant call to String.Format.
         
			Available: When the caret is on a call to an empty base 
			constructor or on a call to String.Format with a single 
			argument.
		 •———————————————————————————————————————————————————————• */

	public class RemoveRedundantCall : BaseAccount
	{
		private decimal limit = 0m;
		public RemoveRedundantCall()
			: base()
		{
		}

		private void Withdraw(decimal value)
		{
      if (balance - value < limit)
        throw new Exception(string.Format("You have insufficient credit."));
      else
        balance = balance - value;
		}
	}
}
