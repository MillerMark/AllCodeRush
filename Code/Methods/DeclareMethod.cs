using System;

namespace AllCodeRush.Code.Methods
{
	/* •———————————————————————————————————————————————————————•
			Feature: Declare Method
        
			Use Case: Lets you generate a method where none exists 
			based on an existing call to that method.
         
			Available: When the caret is on a statement calling an undeclared method.
        
			See also: Declare Method (Abstract)
		 •———————————————————————————————————————————————————————• */

	public class Account
	{
		private int _value;
		public Account(int Value)
		{
			_value = Value;
		}
		private void TransferMoney(Account DestAccount, int Value)
		{
			this.Withdraw(Value);
			DestAccount.Deposit(Value);
		}
		public void Withdraw(int value)
		{
			_value -= value;
		}
	}
}
