using System;
using System.Collections.Generic;
using System.Net.Security;
using System.Text;

namespace ChasePoker
{
    public class Dealer : Deck
    {
        public void ShuffleCards(Deck Curdeck)
        {
            Random rand = new Random();

            Card temp;
            for (int j = 0; j < 1000; j++)
            {
                for (int p = 0; p < 52; p++)
                {
                    int second = rand.Next(13);
                    temp = Curdeck.deck[p];

                    Curdeck.deck[p] = Curdeck.deck[second];
                    Curdeck.deck[second] = temp;
                }
            }
        }
        public void DealToPlayer(Player player, Deck currDeck)
        {
            Random rand = new Random();
            PlayerController controller = new PlayerController(player);

            int RandomFirstCard = rand.Next(currDeck.deck.Count -1);
            if (RandomFirstCard >= currDeck.deck.Count) { RandomFirstCard--; }
            Card temp1 = currDeck.deck[RandomFirstCard];
            currDeck.deck.Remove(currDeck.deck[RandomFirstCard]);

            int RandomSecondCard = rand.Next(currDeck.deck.Count -1);
            if(RandomSecondCard >= currDeck.deck.Count) { RandomSecondCard--; }
            Card temp2 = currDeck.deck[RandomSecondCard];
            currDeck.deck.Remove(currDeck.deck[RandomSecondCard]);
            
            controller.SetHand(temp1, temp2);
        }
        public void AddCardToBoard(Card NewCard, Deck currDeck, Board board)
        {
            board.currBoard.Add(NewCard);
            currDeck.deck.Remove(NewCard);

        }
        public void Flop(Deck currDeck, Board board)
        {
            Random rand = new Random();
            for (int x = 0; x < 3; x++)
            {
                AddCardToBoard(currDeck.deck[rand.Next(currDeck.deck.Count)], currDeck, board);
            }
        }
        public void Turn(Deck currDeck, Board board)
        {
            Random rand = new Random();
            AddCardToBoard(currDeck.deck[rand.Next(currDeck.deck.Count)], currDeck, board);
        }
        public void River(Deck currDeck, Board board)
        {
            Random rand = new Random();
            AddCardToBoard(currDeck.deck[rand.Next(currDeck.deck.Count)], currDeck, board);
        }
        public bool Straight(Board board, Player player)
        {
            int isStraight = 0;
            List<int> numbers = new List<int>();
            foreach(Card card in board.currBoard)
            {
                numbers.Add((int) card.Face);
                numbers.Add((int)player.InHand[0].Face);
                numbers.Add((int)player.InHand[1].Face);
            }
            for(int i = 0; i < numbers.Count; i++)
            {
                int currentNum = numbers[i];
                if (numbers.Contains(currentNum))
                {
                    int j = currentNum;
                    while (numbers.Contains(j))
                    {
                        j++;
                    }
                    if(isStraight < j - currentNum)
                    {
                        isStraight = j - currentNum;
                    }
                }
            }
            return (isStraight >= 5);
        }
        public bool Flush(Board board, Player player)
        {
            List<Card> suits = new List<Card>();
            int DIAMONDS = 0;
            int CLUBS = 0;
            int HEARTS = 0;
            int SPADES = 0;
            foreach(Card card in board.currBoard)
            {
                suits.Add(card);
            }
            suits.Add(player.InHand[0]);
            suits.Add(player.InHand[1]);
            foreach(Card suit in suits)
            {
                switch (suit.Suit)
                {
                    case Card.SUIT.CLUBS:
                        CLUBS++;
                        break;
                    case Card.SUIT.DIAMONDS:
                        DIAMONDS++;
                        break;
                    case Card.SUIT.HEARTS:
                        HEARTS++;
                        break;
                    case Card.SUIT.SPADES:
                        SPADES++;
                        break;
                    default:
                        break;
                }
            }
            if (DIAMONDS >= 5 || CLUBS >= 5 || HEARTS >= 5 || SPADES >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool StraightFlush(Board board, Player player)
        {
            List<Card> cards = new List<Card>();
            foreach(Card card in board.currBoard)
            {
                cards.Add(card);
            }
            cards.Add(player.InHand[0]);
            cards.Add(player.InHand[1]);

            for(int i = 0; i < cards.Count; i++)
            {
                Card currentcard = cards[i];
                foreach(Card card in cards)
                {
                    if((int) card.Face == (int)currentcard.Face)
                    {
                        int j = (int)currentcard.Face;

                    }
                }
            }

        }


    }
}