using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.Expressions
{
    public class CreateCaseBlocksFromEnum
    {
        private enum Suit
        {
            Spades,
            Hearts,
            Clubs,
            Diamonds
        }
        private void Test()
        {
            Suit suit = GetRandomSuit();
        }

        #region Utility
        private Suit GetRandomSuit()
        {
            return (Suit)(new System.Random().Next(3));
        }
        #endregion
    }
    public class UseEqualityOperator
    {
        private void TestEquality()
        {
            //TODO: Does Not appear to work.
            bool result = 1.Equals(2);
        }
    }
}
