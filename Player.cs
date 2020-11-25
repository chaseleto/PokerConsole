using System;
using System.Collections.Generic;
using System.Text;

namespace ChasePoker
{
    public class Player : Dealer
    {
        public string Name { get; set; }
        public bool IsFolded { get; set; }
        public Card[] InHand;
        public Hands BestHand { get; set; }
        public double ChipCount { get; set; }
        public double BetAmount { get; set; }

        public Player()
        {
            this.Name = "default";
            this.IsFolded = false;
            this.ChipCount = 0;
            this.BetAmount = 0;
            this.InHand = new Card[2];
            this.BestHand = new Hands();
        }

       

        //TESTING PURPOSES ONLY
        public void PrintHand(Player player)
        {

            Console.WriteLine(player.Name);
            Console.WriteLine(player.InHand[0].Face.ToString() + " OF " + player.InHand[0].Suit.ToString()
                + " AND " + player.InHand[1].Face.ToString() + " OF " + player.InHand[1].Suit.ToString());
        }

    }
}