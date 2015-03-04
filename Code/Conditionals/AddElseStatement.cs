﻿using System;
using System.Linq;
using System.Data;
namespace AllCodeRush.Code.Conditionals
{
  public class AddElseStatement
  {
    public static bool Mod10Check(string creditCardNumber)
    {
      if (string.IsNullOrEmpty(creditCardNumber))
        return false;

      int sumOfDigits = creditCardNumber.Where((e) => e >= '0' && e <= '9')
                                        .Reverse()
                                        .Select((e, i) => ((int)e - 48) * (i % 2 == 0 ? 1 : 2))
                                        .Sum((e) => e / 10 + e % 10);
      return sumOfDigits % 10 == 0;
    }
  }
}
