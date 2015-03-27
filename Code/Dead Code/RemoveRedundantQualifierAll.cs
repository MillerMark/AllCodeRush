using System;

namespace AllCodeRush.Code.DeadCode.RemoveRedundantQualifierAll
{
	/* •———————————————————————————————————————————————————————•
		Feature: Remove Redundant Qualifier (All)
        
		Use Case: Removes an ALL unnecessary 'this' or 'base' 
	  qualifiers.

	  Available: When the caret is on a 'this' or 'base' 
	  qualifier which is unnecessary in the current context 
	  and more than one such qulifier is in scope. 
	 •—————————————————————————————————————————————————————————• */

	public class Account : BaseAccount
	{
		public void TransferToAccounts(decimal Value, Account Account1, Account Account2)
		{
			this.Withdraw(Value);
			Account1.Deposit(Value);
			this.Withdraw(Value);
			Account2.Deposit(Value);

		}
	}

}
