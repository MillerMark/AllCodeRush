using System;
using AllCodeRush.Code.Conditionals.Support;

namespace AllCodeRush.Code.Conditionals
{
  public class CaseToConditional
  {
    public decimal GetDiscount(CustomerType customerType)
    {
      switch (customerType)
      {
        case CustomerType.Prospect:
          return 0.25m;
        case CustomerType.FirstTimeCustomer:
          return 0.15m;
        case CustomerType.ProblemCustomer:
          return 0m;
        case CustomerType.GoodCustomer:
          return 0.1m;
        case CustomerType.VeryImportantCustomer:
          return 0.2m;
      }
      return 0;
    }
  }
}
