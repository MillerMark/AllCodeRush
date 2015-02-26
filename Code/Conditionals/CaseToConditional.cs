using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.Conditionals
{
    public class CaseToConditional
    {
        public enum Suit
        {
            Spades,
            Hearts,
            Clubs,
            Diamonds
        }
        public string SuitToString(Suit suit)
        {
            switch (suit)
            {
                case Suit.Spades:
                    return "Spades";
                case Suit.Hearts:
                    return "Hearts";
                case Suit.Clubs:
                    return "Clubs";
                case Suit.Diamonds:
                    return "Diamonds";
                default:
                    throw new Exception("This cannot happen");
            }

        }
    }
}
