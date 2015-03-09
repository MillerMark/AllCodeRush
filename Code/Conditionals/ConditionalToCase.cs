using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.Conditionals
{
  /* •———————————————————————————————————————————————————————•
      Feature: Case To Conditional
        
      Use Case: Lets you convert series of nested if..else to 
      a switch\select statement.
         
      Available: When the caret is on an if statement that has 
      a corresponding else block.
        
      Related Refactorings: Case To Conditional
     •———————————————————————————————————————————————————————• */

  public class ConditionalToCase
  {
    #region Example1
    public double CalculateDiscountPCent(DiscountLevelEnum discountLevel)
    {
      if (discountLevel == DiscountLevelEnum.Platinum)
        return 15.0;
      else
      {
        if (discountLevel == DiscountLevelEnum.Gold)
          return 10.0;
        else
        {
          if (discountLevel == DiscountLevelEnum.Silver)
            return 5.0;
          else
          {
            if (discountLevel == DiscountLevelEnum.Bronze)
              return 2.5;
            else
            {
              throw new Exception("This cannot happen");
            }
          }
        }
      }
    }
    #endregion

    #region Example2
    public double CalculateDiscountPCent(DiscountLevelEnum discountLevel)
    {
      if (discountLevel == DiscountLevelEnum.Platinum)
        return 15.0;
      else if (discountLevel == DiscountLevelEnum.Gold)
        return 10.0;
      else if (discountLevel == DiscountLevelEnum.Silver)
        return 5.0;
      else if (discountLevel == DiscountLevelEnum.Bronze)
        return 2.5;
      else
        throw new Exception("This cannot happen");
    }
    #endregion

    #region Support Code
    public enum DiscountLevelEnum
    {
      Platinum,
      Gold,
      Silver,
      Bronze
    }
    #endregion
  }
}
