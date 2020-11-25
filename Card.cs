
using System;
using System.Collections.Generic;
using System.Text;

namespace ChasePoker
{
    public class Card
    {
        public enum SUIT
        {
            DIAMONDS, HEARTS, SPADES, CLUBS
        }
        public enum FACE
        {
            TWO = 2, THREE = 3, FOUR = 4, FIVE = 5, SIX = 6, SEVEN = 7, EIGHT = 8, NINE = 9, TEN = 10, JACK = 11, QUEEN = 12, KING = 13, ACE = 14
        }
        public SUIT Suit { get; set; }
        public FACE Face { get; set; }
    }
}