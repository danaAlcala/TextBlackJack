using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextBlackJack
{
    class Program
    {
        #region Instantiate Classes
        // Instantiate Classes      
        static Dealer dealer = new Dealer();
        static Player player1 = new Player();
        static Card newCard = new Card();
        #endregion
        #region ---- Card Classes (Hearts)
        // Instantiate Card Classes (Hearts)
        static Card aceOfHearts = new Card();
        static Card twoOfHearts = new Card();
        static Card threeOfHearts = new Card();
        static Card fourOfHearts = new Card();
        static Card fiveOfHearts = new Card();
        static Card sixOfHearts = new Card();
        static Card sevenOfHearts = new Card();
        static Card eightOfHearts = new Card();
        static Card nineOfHearts = new Card();
        static Card tenOfHearts = new Card();
        static Card jackOfHearts = new Card();
        static Card queenOfHearts = new Card();
        static Card kingOfHearts = new Card();
        #endregion
        #region ---- Card Classes (Diamonds)
        // Instantiate Card Classes (Diamonds)
        static Card aceOfDiamonds = new Card();
        static Card twoOfDiamonds = new Card();
        static Card threeOfDiamonds = new Card();
        static Card fourOfDiamonds = new Card();
        static Card fiveOfDiamonds = new Card();
        static Card sixOfDiamonds = new Card();
        static Card sevenOfDiamonds = new Card();
        static Card eightOfDiamonds = new Card();
        static Card nineOfDiamonds = new Card();
        static Card tenOfDiamonds = new Card();
        static Card jackOfDiamonds = new Card();
        static Card queenOfDiamonds = new Card();
        static Card kingOfDiamonds = new Card();
        #endregion
        #region ---- Card Classes (Clubs)
        // Instantiate Card Classes (Clubs)
        static Card aceOfClubs = new Card();
        static Card twoOfClubs = new Card();
        static Card threeOfClubs = new Card();
        static Card fourOfClubs = new Card();
        static Card fiveOfClubs = new Card();
        static Card sixOfClubs = new Card();
        static Card sevenOfClubs = new Card();
        static Card eightOfClubs = new Card();
        static Card nineOfClubs = new Card();
        static Card tenOfClubs = new Card();
        static Card jackOfClubs = new Card();
        static Card queenOfClubs = new Card();
        static Card kingOfClubs = new Card();
        #endregion
        #region --- Card Classes (Spades)
        // Instantiate Card Classes (Spades)
        static Card aceOfSpades = new Card();
        static Card twoOfSpades = new Card();
        static Card threeOfSpades = new Card();
        static Card fourOfSpades = new Card();
        static Card fiveOfSpades = new Card();
        static Card sixOfSpades = new Card();
        static Card sevenOfSpades = new Card();
        static Card eightOfSpades = new Card();
        static Card nineOfSpades = new Card();
        static Card tenOfSpades = new Card();
        static Card jackOfSpades = new Card();
        static Card queenOfSpades = new Card();
        static Card kingOfSpades = new Card();
        #endregion


        static void Main()
        {
            initializeCards();
            gameLoop();
        }

        public static void gameLoop()
        {
            clearAllCards();
            initializeDeckInPlay();
            dealer.dealToPlayer(player1);
            dealer.dealToSelf(dealer);
            dealer.dealToPlayer(player1);
            dealer.dealToSelf(dealer);
            showTable();
            updatePlayerScore();
            showPlayerScore();


            while (player1.staying == false)
            {
                promptForAction();
                player1.input = gatherAction();
                interpretAction(player1.input);
            }
        }

        public static void printCard(Card c)
        {
            if (c.visible == true)
            {
                Console.WriteLine("[" + c.rank + " of " + c.suit + "]");
            }
            else
            {
                Console.WriteLine("[CARD]");
            }
        }

        public static void initializeCards()
        {
            // Sets each card to their proper variables.
            // Hearts:
            aceOfHearts = dealer.deck[0];
            twoOfHearts = dealer.deck[1];
            threeOfHearts = dealer.deck[2];
            fourOfHearts = dealer.deck[3];
            fiveOfHearts = dealer.deck[4];
            sixOfHearts = dealer.deck[5];
            sevenOfHearts = dealer.deck[6];
            eightOfHearts = dealer.deck[7];
            nineOfHearts = dealer.deck[8];
            tenOfHearts = dealer.deck[9];
            jackOfHearts = dealer.deck[10];
            queenOfHearts = dealer.deck[11];
            kingOfHearts = dealer.deck[12];
            // Diamonds:
            aceOfDiamonds = dealer.deck[13];
            twoOfDiamonds = dealer.deck[14];
            threeOfDiamonds = dealer.deck[15];
            fourOfDiamonds = dealer.deck[16];
            fiveOfDiamonds = dealer.deck[17];
            sixOfDiamonds = dealer.deck[18];
            sevenOfDiamonds = dealer.deck[19];
            eightOfDiamonds = dealer.deck[20];
            nineOfDiamonds = dealer.deck[21];
            tenOfDiamonds = dealer.deck[22];
            jackOfDiamonds = dealer.deck[23];
            queenOfDiamonds = dealer.deck[24];
            kingOfDiamonds = dealer.deck[25];
            // Clubs:
            aceOfClubs = dealer.deck[26];
            twoOfClubs = dealer.deck[27];
            threeOfClubs = dealer.deck[28];
            fourOfClubs = dealer.deck[29];
            fiveOfClubs = dealer.deck[30];
            sixOfClubs = dealer.deck[31];
            sevenOfClubs = dealer.deck[32];
            eightOfClubs = dealer.deck[33];
            nineOfClubs = dealer.deck[34];
            tenOfClubs = dealer.deck[35];
            jackOfClubs = dealer.deck[36];
            queenOfClubs = dealer.deck[37];
            kingOfClubs = dealer.deck[38];
            // Spades:
            aceOfSpades = dealer.deck[39];
            twoOfSpades = dealer.deck[40];
            threeOfSpades = dealer.deck[41];
            fourOfSpades = dealer.deck[42];
            fiveOfSpades = dealer.deck[43];
            sixOfSpades = dealer.deck[44];
            sevenOfSpades = dealer.deck[45];
            eightOfSpades = dealer.deck[46];
            nineOfSpades = dealer.deck[47];
            tenOfSpades = dealer.deck[48];
            jackOfSpades = dealer.deck[49];
            queenOfSpades = dealer.deck[50];
            kingOfSpades = dealer.deck[51];
        }
        public static void initializeDeckInPlay()
        {
            // Hearts
            dealer.deckInPlay.Add(aceOfHearts);
            dealer.deckInPlay.Add(twoOfHearts);
            dealer.deckInPlay.Add(threeOfHearts);
            dealer.deckInPlay.Add(fourOfHearts);
            dealer.deckInPlay.Add(fiveOfHearts);
            dealer.deckInPlay.Add(sixOfHearts);
            dealer.deckInPlay.Add(sevenOfHearts);
            dealer.deckInPlay.Add(eightOfHearts);
            dealer.deckInPlay.Add(nineOfHearts);
            dealer.deckInPlay.Add(tenOfHearts);
            dealer.deckInPlay.Add(jackOfHearts);
            dealer.deckInPlay.Add(queenOfHearts);
            dealer.deckInPlay.Add(kingOfHearts);
            // Diamonds
            dealer.deckInPlay.Add(aceOfDiamonds);
            dealer.deckInPlay.Add(twoOfDiamonds);
            dealer.deckInPlay.Add(threeOfDiamonds);
            dealer.deckInPlay.Add(fourOfDiamonds);
            dealer.deckInPlay.Add(fiveOfDiamonds);
            dealer.deckInPlay.Add(sixOfDiamonds);
            dealer.deckInPlay.Add(sevenOfDiamonds);
            dealer.deckInPlay.Add(eightOfDiamonds);
            dealer.deckInPlay.Add(nineOfDiamonds);
            dealer.deckInPlay.Add(tenOfDiamonds);
            dealer.deckInPlay.Add(jackOfDiamonds);
            dealer.deckInPlay.Add(queenOfDiamonds);
            dealer.deckInPlay.Add(kingOfDiamonds);
            // Clubs
            dealer.deckInPlay.Add(aceOfClubs);
            dealer.deckInPlay.Add(twoOfClubs);
            dealer.deckInPlay.Add(threeOfClubs);
            dealer.deckInPlay.Add(fourOfClubs);
            dealer.deckInPlay.Add(fiveOfClubs);
            dealer.deckInPlay.Add(sixOfClubs);
            dealer.deckInPlay.Add(sevenOfClubs);
            dealer.deckInPlay.Add(eightOfClubs);
            dealer.deckInPlay.Add(nineOfClubs);
            dealer.deckInPlay.Add(tenOfClubs);
            dealer.deckInPlay.Add(jackOfClubs);
            dealer.deckInPlay.Add(queenOfClubs);
            dealer.deckInPlay.Add(kingOfClubs);
            // Spades
            dealer.deckInPlay.Add(aceOfSpades);
            dealer.deckInPlay.Add(twoOfSpades);
            dealer.deckInPlay.Add(threeOfSpades);
            dealer.deckInPlay.Add(fourOfSpades);
            dealer.deckInPlay.Add(fiveOfSpades);
            dealer.deckInPlay.Add(sixOfSpades);
            dealer.deckInPlay.Add(sevenOfSpades);
            dealer.deckInPlay.Add(eightOfSpades);
            dealer.deckInPlay.Add(nineOfSpades);
            dealer.deckInPlay.Add(tenOfSpades);
            dealer.deckInPlay.Add(jackOfSpades);
            dealer.deckInPlay.Add(queenOfSpades);
            dealer.deckInPlay.Add(kingOfSpades);

            for (int i = 0; i <= 51; i++)
            {
                dealer.deckInPlay[i].visible = false;
                switch (dealer.deckInPlay[i].rank)
                {
                    case "Ace":
                        dealer.deckInPlay[i].score = 11;
                        break;
                    case "2":
                        dealer.deckInPlay[i].score = 2;
                        break;
                    case "3":
                        dealer.deckInPlay[i].score = 3;
                        break;
                    case "4":
                        dealer.deckInPlay[i].score = 4;
                        break;
                    case "5":
                        dealer.deckInPlay[i].score = 5;
                        break;
                    case "6":
                        dealer.deckInPlay[i].score = 6;
                        break;
                    case "7":
                        dealer.deckInPlay[i].score = 7;
                        break;
                    case "8":
                        dealer.deckInPlay[i].score = 8;
                        break;
                    case "9":
                        dealer.deckInPlay[i].score = 9;
                        break;
                    case "10":
                    case "Jack":
                    case "Queen":
                    case "King":
                        dealer.deckInPlay[i].score = 10;
                        break;
                }
            }

            dealer.shuffleDeck(10);
        }

        public static void printDeck(List<Card> deck)
        {
            for (int i = 0; i <= 51; i++)
            {
                printCard(deck[i]);
            }
        }


        public static void printHand(List<Card> hand)
        {
            for (int i = 0; i <= hand.Count - 1; i++)
            {
                printCard(hand[i]);
            }
        }

        public static void makeDeckVisible()
        {
            for (int i = 0; i <= 51; i++)
            {
                dealer.deckInPlay[i].visible = true;
            }
        }

        public static void promptForAction()
        {
            Console.WriteLine();
            Console.WriteLine("What would you like to do?");
        }

        public static string gatherAction()
        {
            string input = Console.ReadLine();
            return input;
        }

        public static void interpretAction(string action)
        {
            switch (action.ToLower())
            {
                case "hit":
                case "h":
                    dealer.dealToPlayer(player1);
                    clearTable();
                    showTable();
                    updatePlayerScore();
                    showPlayerScore();
                    break;
                case "stay":
                case "s":
                    player1.staying = true;
                    dealer.revealHand();
                    clearTable();
                    showTable();
                    break;
                case "newdeal":
                case "n":
                    gameLoop();
                    break;
                default:
                    Console.WriteLine("I am error.");
                    Console.ReadLine();
                    break;
            }
        }

        public static void showTable()
        {
            Console.Clear();
            Console.WriteLine("Dealer's hand:");
            printHand(dealer.hand);
            Console.WriteLine();
            Console.WriteLine("Your hand:");
            printHand(player1.hand);
        }

        public static void clearAllCards()
        {
            dealer.deckInPlay.Clear();
            dealer.hand.Clear();
            player1.hand.Clear();
        }

        public static void clearTable()
        {
            Console.Clear();
        }

        public static void updatePlayerScore()
        {
            player1.score = 0;
            for (int i = 0; i <= player1.hand.Count - 1; i++)
            {
                if (player1.score + player1.hand[i].score > 21 && player1.hand[i].score == 11)
                {
                    player1.hand[i].score = 1;
                    player1.score = player1.score + player1.hand[i].score;
                }
                else if (player1.score + player1.hand[i].score > 21 && player1.hand[i].score != 11)
                {
                    for (int j = 0; j <= player1.hand.Count - 1; j++)
                    {
                        if (player1.hand[j].score == 11)
                        {
                            player1.hand[j].score = 1;
                            player1.score = player1.score + player1.hand[j].score;
                            break;
                        }
                    }
                }
                else
                {
                    player1.score = player1.score + player1.hand[i].score;
                }
                //player1.score = player1.score + player1.hand[i].score;                
            }            
        }

        public static void showPlayerScore()
        {
            Console.WriteLine();
            Console.WriteLine("Your score is: {0}", player1.score);
        }        
    }
}
