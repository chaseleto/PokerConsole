using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ChasePoker
{
    class Program
    {
        public static int MAX_PLAYERS = 9;
        public static bool Realistic = false;
        static void Main(string[] args)
        {
            Random rand = new Random();
            int randDeck = rand.Next(52);

            List<string> playerList = new List<string>()
            {
                "Chdasdje",
                "Adamdd",
                "Maxf",
                "Logan",
                "Evren",
                "Michael",
                "Sachin",
                "Grant",
                "Fostedr",
                "Kiel",

            };


            Deck Tdeck = new Deck();
            int totalplayers = Int16.Parse(Console.ReadLine());
            if (totalplayers <= MAX_PLAYERS) { Realistic = true; }

            if (Realistic)
            {
                Player[] players = new Player[totalplayers];
                Board board = new Board();
                Dealer dealer1 = new Dealer();
                dealer1.ShuffleCards(Tdeck);

                for (int y = 0; y < 5; y++)
                {
                    dealer1.AddCardToBoard(Tdeck.deck[y], Tdeck, board);
                }
                Console.WriteLine("Board: ");
                board.ShowBoard();
                for (int x = 0; x < totalplayers; x++)
                {

                    players[x] = new Player();

                    int randPlayer = rand.Next(playerList.Count);

                    players[x].Name = (playerList[randPlayer]);
                    playerList.Remove(playerList[randPlayer]);

                    dealer1.DealToPlayer(players[x], Tdeck);
                    Console.WriteLine("\n");
                    players[x].PrintHand(players[x]);
                }
                foreach(Player player in players)
                {
                    if(dealer1.Flush(board, player)) { player.BestHand = Hands.FLUSH; 
                    } else if(dealer1.Straight(board, player)){
                        player.BestHand = Hands.STRAIGHT;
                    }
                }
            }
            else
            {
                Console.WriteLine("Too many players....");
            }
            Console.ReadLine();
        }
    }
}
