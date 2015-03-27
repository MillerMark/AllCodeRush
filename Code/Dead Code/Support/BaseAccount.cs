using System;

namespace AllCodeRush.Code.DeadCode
{
	#region Support
	public class BaseAccount
	{
		private decimal _Balance;
		public void Withdraw(decimal Value)
		{
			_Balance = _Balance - Value;
		}
		public void Deposit(decimal Value)
		{
			_Balance = _Balance + Value;
		}
	}
	#endregion
}
