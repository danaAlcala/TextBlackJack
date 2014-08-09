using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextBlackJack
{
    public class Player
    {
        public int score = 0;
        public bool staying = false;
        public string input = null;
        public bool hasAce = false;

        public List<Card> hand = new List<Card>();

        public Player()
        {
           
        }
    }
}
