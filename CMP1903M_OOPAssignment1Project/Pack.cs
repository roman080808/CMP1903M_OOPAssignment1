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

        int deckLimit = 52;

        public List<string> deck = new List<string>();
        public List<string> shuffledDeck = new List<string>();

        public Pack()
        {
            //Initialise the card pack here

            int suit = 0;
            int values = 0;

            while (deck.ToArray().Length < deckLimit)
            {
                if (values >= 13)
                {
                    values = 0;
                }

                deck.Add($"{card.Value[values]} of {card.Suits[suit]}");
                values++;
                if (deck.ToArray().Length % 13 == 0)
                {
                    suit++;
                    values++;
                }
            }
        }
        
        public bool shuffleCardPack(int typeOfShuffle)
        {
            //Fisher-Yates Shuffle
            if (typeOfShuffle == 1)
            {
                Random rand = new Random();

                while (deck.ToArray().Length > 0)
                {
                    int randNum = rand.Next(deck.ToArray().Length);

                    string deckString = deck[randNum];
                    deck.RemoveAt(randNum);
                    shuffledDeck.Add(deckString);
                }

                return true;
            }
            //Riffle Shuffle
            else if (typeOfShuffle == 2)
            {
                int timesShuffled = 4;
                
                for (int i = 0; i < timesShuffled; i++)
                {
                    int deckLength = deck.ToArray().Length;

                    List<string> firstHalf = new List<string>();
                    List<string> secondHalf = new List<string>();

                    for (int k = 0; k < deckLength / 2; k++)
                    {
                        firstHalf.Add(deck[k]);
                        deck.RemoveAt(k);

                    }

                    foreach (var item in deck)
                    {
                        secondHalf.Add(item);
                    }


                    Random rand = new Random();
                    int randNum = rand.Next(1);

                    for (int j = 0; j < deckLength; j++)
                    {
                        if (randNum == 1)
                        {
                            deck.Add(firstHalf[j]);
                            deck.Add(secondHalf[j]);
                        }
                        if (randNum == 2)
                        {
                            deck.Add(secondHalf[j]);
                            deck.Add(firstHalf[j]);
                        }
                    }
                    
                }
                foreach (var item in deck)
                {
                    shuffledDeck.Add(item);
                }

                return true;
            }

            //No shuffle
            else if (typeOfShuffle == 3)
            {
                foreach (var item in deck)
                {
                    shuffledDeck.Add(item);
                }
                return true;
            }

            return false;
            
        }
        public string deal()
        {
            //Deals one card

            string cardDealt = shuffledDeck[0];
            Console.WriteLine(cardDealt);
            shuffledDeck.RemoveAt(0);
            

            return cardDealt;
        }
        public List<string> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'

            List<string> cards = new List<string>();

            for (int i = 0; i < amount; i++)
            {
                string cardsDealt = shuffledDeck[0];
                Console.WriteLine(cardsDealt);
                shuffledDeck.RemoveAt(0);
                cards.Add(cardsDealt);
            }
            return cards;
        }
    }
}