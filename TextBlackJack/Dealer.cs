using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextBlackJack
{
    public class Dealer
    {
        public int score = 0;
        public bool staying = false;
        public Random rnd = new Random();
        public Card[] deck = new Card[52]; // An array of 52 cards to make up the deck
        public Card card = new Card(); // This card will be used as a model for the cards in the deck.
        public List<Card> hand = new List<Card>();
        public List<Card> deckInPlay = new List<Card>();
        public List<Card> shuffler = new List<Card>();
        public Dealer()
        {
            initializeDeck();
        }

        public void initializeDeck()
        {
            // Populate Hearts
            for (int i = 0; i <= 12; i++)
            {
                deck[i] = new Card(card.suitArray[0], card.rankArray[i]);
            }
            // Populate Diamonds
            for (int i = 13; i <= 25; i++)
            {
                deck[i] = new Card(card.suitArray[1], card.rankArray[i - 13]);
            }
            // Populate Clubs
            for (int i = 26; i <= 38; i++)
            {
                deck[i] = new Card(card.suitArray[2], card.rankArray[i - 26]);
            }
            // Populate Spades
            for (int i = 39; i <= 51; i++)
            {
                deck[i] = new Card(card.suitArray[3], card.rankArray[i - 39]);
            }
        }

        public void dealToPlayer(Player player)
        {
            int cardPlace = player.hand.Count; // count is stored BEFORE card is added
            player.hand.Add(new Card());
            card.copyCard(deckInPlay[0], player.hand[cardPlace]);
            player.hand[cardPlace].visible = true;
            deckInPlay.RemoveAt(0); // removes the top card of the deck
        }

        public void dealToSelf(Dealer dealer)
        {
            int cardPlace = dealer.hand.Count; // count is stored BEFORE card is added
            dealer.hand.Add(new Card());
            card.copyCard(deckInPlay[0], dealer.hand[cardPlace]);
            deckInPlay.RemoveAt(0); // removes the top card of the deck
            if (cardPlace > 0)
            {
                dealer.hand[cardPlace].visible = true;
            }
        }

        public void shuffleDeck(int timesToShuffle)
        {
            for (int i = 0; i <= timesToShuffle; i++)
            {
                for (int j = 0; j < 52; j++)
                {
                    int randomNumber = rnd.Next(0, deckInPlay.Count);
                    Card randomCard = deckInPlay[randomNumber];
                    shuffler.Add(randomCard);
                    deckInPlay.RemoveAt(randomNumber);
                }

                for (int j = 0; j < 52; j++)
                {
                    int randomNumber = rnd.Next(0, shuffler.Count);
                    Card randomCard = shuffler[randomNumber];
                    deckInPlay.Add(randomCard);
                    shuffler.RemoveAt(randomNumber);
                }
            }
        }

        public void revealHand()
        {
            hand[0].visible = true;
        }

    }
}
