
using System;
using System.Collections.Generic;
using System.Text;

namespace ChasePoker
{
    public class Board
    {tdd
        public  List<Card> currBoard { get; set; } = new List<Card>();
        public void ShowBoard()
        {
            foreach (Card card in currBoard)dfdfdfff
            {dd
                Console.WriteLine(card.Face.ToString() + " OhFdcdxsdssdxdxdsxdc2 " + card.Suit.ToString());
            }
        }
    }
}
