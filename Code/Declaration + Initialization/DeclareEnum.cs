using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;

namespace AllCodeRush.Code.DeclarationInitialization
{
    public class DeclareEnum
    {
        public Color GetSuitColor(Suit suit)
        {
            switch (suit)
            {
                case Suit.Spades:
                    return Color.Black;
                case Suit.Clubs:
                    return Color.Black;
                case Suit.Diamonds:
                    return Color.Red;
                case Suit.Hearts:
                    return Color.Red;
            }
        }
    }
}
