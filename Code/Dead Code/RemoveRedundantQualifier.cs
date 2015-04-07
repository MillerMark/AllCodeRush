using System;

namespace AllCodeRush.Code.DeadCode
{
	/* •———————————————————————————————————————————————————————•
		  Feature: Remove Redundant Qualifier.
        
		  Use Case: Removes an unnecessary 'this' or 'base' 
	    qualifier.

	    Available: When the caret is on a 'this' or 'base' 
	    qualifier which is unnecessary in the current context. 
	   •—————————————————————————————————————————————————————————• */

  public class RemoveRedundantQualifier: BaseAccount
	{
		public void TransferToAccount(decimal Value, BaseAccount targetAccount)
		{
			this.Withdraw(Value);
			targetAccount.Deposit(Value);
		}
	}
}
