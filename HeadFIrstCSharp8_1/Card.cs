﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstCSharp8_1
{
    public class Card
    {
        public Values Value { get; private set; }
        public Suits Suit { get; private set; }
        public string Name { get { return $"{Value} of {Suit}"; } }

        public Card(Values value, Suits suit)
        {
            Value = value;
            Suit = suit;
        }

        public override string ToString()
        {
            return $"{Value} of {Suit}";
        }
    }
}
