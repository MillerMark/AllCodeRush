using System;

namespace AllCodeRush.Code.DeadCode.RemoveRedundantQualifier
{
	/* 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧�
		Feature: Remove Redundant Qualifier
        
		Use Case: Removes an unnecessary 'this' or 'base' 
	  qualifier.

	  Available: When the caret is on a 'this' or 'base' 
	  qualifier which is unnecessary in the current context. 
	 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧� */

	public class Account : BaseAccount
	{
		public void TransferToAccount(decimal Value, Account OtherAccount)
		{
			this.Withdraw(Value);
			OtherAccount.Deposit(Value);
		}
	}
}
