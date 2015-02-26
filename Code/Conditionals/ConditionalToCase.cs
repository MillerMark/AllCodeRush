using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.Conditionals
{
    public class ConditionalToCase
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
            if (suit == Suit.Spades)
            {
                return "Spades";
            }
            else if (suit == Suit.Hearts)
            {
                return "Hearts";
            }
            else if (suit == Suit.Clubs)
            {
                return "Clubs";
            }
            else if (suit == Suit.Diamonds)
            {
                return "Diamonds";
            }
            else
            {
                throw new Exception("This cannot happen");
            }

        }
    }
}
