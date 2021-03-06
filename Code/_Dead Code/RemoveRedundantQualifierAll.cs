using System;

namespace AllCodeRush.Code.DeadCode
{
  /* 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧�
      Feature: Remove Redundant Qualifier (All).
        
      Use Case: Removes ALL unnecessary 'this' or 'base' 
      qualifiers from the active class.

      Available: When the caret is on a 'this' or 'base' 
      qualifier which is unnecessary in the current context 
      and at least one other matching qualifier is in scope. 
   
      See also: Remove Redundant Qualifier
     風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧� */

  public class RemoveRedundantQualifierAll : BaseAccount
  {
    private void VerifyFunds(decimal value)
    {
      if (this.Balance > value)
        return;
      throw new Exception("Insufficient funds!");
    }

    public void TransferToAccount(decimal value, BaseAccount account)
    {
      this.VerifyFunds(value);
      this.Withdraw(value);
      account.Deposit(value);
    }
    public decimal GetBalance()
    {
      return this.Balance;
    }
  }
}
