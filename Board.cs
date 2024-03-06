
using System;
using System.Collections.Generic;
using System.Text;

namespace ChasePoker
{
    public class Board
    {
        public  List<Card> currBoard { get; set; } = new List<Card>();
        public void ShowBoard()
        {
            foreach (Card card in currBoard)
            {
                Console.WriteLine(card.Face.ToString() + " OF2 " + card.Suit.ToString());
            }
        }
    }
}
