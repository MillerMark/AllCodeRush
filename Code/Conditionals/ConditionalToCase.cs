using System;
using AllCodeRush.Code.Conditionals.Support;

namespace AllCodeRush.Code.Conditionals
{
  public class ConditionalToCase
  {
    public decimal GetDiscount(CustomerType customerType)
    {
      if (customerType == CustomerType.Prospect)
      {
        return 0.25m;
      }
      else if (customerType == CustomerType.FirstTimeCustomer)
      {
        return 0.15m;
      }
      else if (customerType == CustomerType.ProblemCustomer)
      {
        return 0m;
      }
      else if (customerType == CustomerType.GoodCustomer)
      {
        return 0.1m;
      }
      else if (customerType == CustomerType.VeryImportantCustomer)
      {
        return 0.2m;
      }
      return 0;
    }
  }
}
