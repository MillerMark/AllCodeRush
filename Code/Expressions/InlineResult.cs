using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.Expressions
{
    public class InlineResult
    {
        public bool isThisYourCard(bool CardIsAceOfSpades)
        {
            bool Result;
            if (CardIsAceOfSpades)
                Result = true;
            else
                Result = false;
            return Result;
        }
    }
}
