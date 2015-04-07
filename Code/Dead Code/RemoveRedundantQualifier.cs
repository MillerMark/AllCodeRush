using System;

namespace AllCodeRush.Code.DeadCode
{
	/* 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧�
		  Feature: Remove Redundant Qualifier.
        
		  Use Case: Removes an unnecessary 'this' or 'base' 
	    qualifier.

	    Available: When the caret is on a 'this' or 'base' 
	    qualifier which is unnecessary in the current context. 
	   風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧� */

  public class RemoveRedundantQualifier: BaseAccount
	{
		public void TransferToAccount(decimal Value, BaseAccount targetAccount)
		{
			this.Withdraw(Value);
			targetAccount.Deposit(Value);
		}
	}
}
