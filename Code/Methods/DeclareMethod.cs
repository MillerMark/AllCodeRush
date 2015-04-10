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
  public class Account: BaseAccount
	{
		public Account(int value)
		{
      balance = value;
		}

    public void TransferMoney(BaseAccount destAccount, int value)
		{
			this.Withdraw(value);
			destAccount.Deposit(value);
      LogBalance(DateTime.Now, destAccount);
		}
	}
}
