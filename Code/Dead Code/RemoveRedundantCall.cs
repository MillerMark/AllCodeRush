using System;

namespace AllCodeRush.Code.DeadCode.RemoveRedundantCall
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

	public class CurrentAccount : Account
	{
		private decimal _Limit = 0m;
		public CurrentAccount()
			: base()
		{
		}

		private void Withdraw(decimal Value)
		{
			if (_balance - Value < _Limit)
			{
				throw new Exception(string.Format("You do not have sufficient credit."));
			}
			else
				_balance = _balance - Value;
		}
	}
	#region Support
	public class Account
	{
		protected decimal _balance;
		public Account()
		{
		}
	}
	#endregion
}
