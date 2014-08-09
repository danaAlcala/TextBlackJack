using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextBlackJack
{
    public class Card
    {
        public string suit;
        public string rank;
        public string[] suitArray = new string[4];
        public string[] rankArray = new string[13];
        public int[] scoreArray = new int[11];
        public bool visible = false;
        public int score = 0;
        public Card()
        {
            populateSuitArray();
            populateRankArray();
        }

        public Card(string Suit, string Rank)
        {
            suit = Suit;
            rank = Rank;
        }

        public void populateSuitArray()
        {
            suitArray[0] = "Hearts";
            suitArray[1] = "Diamonds";
            suitArray[2] = "Clubs";
            suitArray[3] = "Spades";
        }

        public void populateRankArray()
        {
            rankArray[0] = "Ace";
            rankArray[1] = "2";
            rankArray[2] = "3";
            rankArray[3] = "4";
            rankArray[4] = "5";
            rankArray[5] = "6";
            rankArray[6] = "7";
            rankArray[7] = "8";
            rankArray[8] = "9";
            rankArray[9] = "10";
            rankArray[10] = "Jack";
            rankArray[11] = "Queen";
            rankArray[12] = "King";
        }

        public void copyCard(Card card1, Card card2)
        {
            copySuit(card1, card2);
            copyRank(card1, card2);
            card2.score = card1.score;
        }

        public void copySuit(Card card1, Card card2)
        {
            switch (card1.suit)
            {
                case "Hearts":
                    card2.suit = "Hearts";
                    break;
                case "Diamonds":
                    card2.suit = "Diamonds";
                    break;
                case "Clubs":
                    card2.suit = "Clubs";
                    break;
                case "Spades":
                    card2.suit = "Spades";
                    break;
                default:
                    Console.WriteLine("I am error.");
                    break;
            }
        }

        public void copyRank(Card card1, Card card2)
        {
            switch (card1.rank)
            {
                case "Ace":
                    card2.rank = "Ace";
                    break;
                case "2":
                    card2.rank = "2";
                    break;
                case "3":
                    card2.rank = "3";
                    break;
                case "4":
                    card2.rank = "4";
                    break;
                case "5":
                    card2.rank = "5";
                    break;
                case "6":
                    card2.rank = "6";
                    break;
                case "7":
                    card2.rank = "7";
                    break;
                case "8":
                    card2.rank = "8";
                    break;
                case "9":
                    card2.rank = "9";
                    break;
                case "10":
                    card2.rank = "10";
                    break;
                case "Jack":
                    card2.rank = "Jack";
                    break;
                case "Queen":
                    card2.rank = "Queen";
                    break;
                case "King":
                    card2.rank = "King";
                    break;
                default:
                    Console.WriteLine("I am error.");
                    break;
            }
        }


    }
}
