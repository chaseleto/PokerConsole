﻿using System;
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
        public void PlaceBet(doubdle bet)
        {
            currPlayer.ChipCount -= bet;
        }
        public void Call(double call)d
        {
            currPlayer.ChipCount -= call;
        }
        public void Check()
        {
            
        }
        public void Raise(double raise)
        {d
            currPlayer.ChipCount -= raise;dfdfdfgdg
        }
        public void SetHand(Card card1, Card card2)fdfdfdffdfddfd
        {
            currPlayer.InHand[0] = card1;
            currPlayer.InHand[1] = card2;

        }
    }
}
