using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Classes.Cards
{
    class Card
    {
        public Value Value { get; private set; }
        public Suit Suit { get; private set; }
        public string Name { get { return $"{Value} of {Suit}"; } }
        public Card(int value, int suit) { Value = (Value)value; Suit = (Suit)suit; }
    }

    enum Suit
    {
        Diamonds,
        Clubs,
        Hearts,
        Spades,
    }

    enum Value
    {
        Ace = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13,
    }

}
