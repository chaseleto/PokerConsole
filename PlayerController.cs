using System;
using System.Collections.Generic;
using System.Text;

namespace ChasePoker
{
    public class PlayerController : Player
    {
        private Player currPlayer;
        public PlayerController(Player player)
        {
            currPlayer = player;
        }
        public void PlaceBet(double bet)
        {
            currPlayer.ChipCount -= bet;
        }
        public void Call(double call)
        {
            currPlayer.ChipCount -= call;
        }
        public void Check()
        {
            
        }
        public void Raise(double raise)
        {
            currPlayer.ChipCount -= raise;
        }
        public void SetHand(Card card1, Card card2)
        {
            currPlayer.InHand[0] = card1;
            currPlayer.InHand[1] = card2;

        }
    }
}
