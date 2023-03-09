using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        Card card = new Card();
        public Dictionary<string, int[]> pack = new Dictionary<string, int[]>();
        public Pack()
        {
            //Initialise the card pack here
            //Excludes max num



            for (int i = 0; i < card.Suits.Length; i++)
            {
                string curSuit = card.Suits[i];
                pack.Add(curSuit, card.Value);
            }
        }

        public bool shuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle
            return false;
        }
        public Card deal()
        {
            //Deals one card
            return null;
        }
        public List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
            return null;
        }
    }
}
