using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Program
    {
        static void Main(string[] args)
        {
            Pack pack = new Pack();
            bool quit = false;

            while (!quit)
            {
                Console.WriteLine("Welcome to the Deck of Cards Simulator! \n \n Please choose how you would like your cards to be shuffled.");
                Console.WriteLine("1 - Fisher-Yates Shuffle");
                Console.WriteLine("2 - Riffle Shuffle");
                Console.WriteLine("3 - No Shuffle (Deck will be sorted into individual suits and ascending values.)");
                Console.WriteLine("4 - Quit the Program");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        pack.shuffleCardPack(1);
                        Console.WriteLine("Shuffling using Fisher-Yates Shuffle");
                        break;
                    case 2:
                        pack.shuffleCardPack(2);
                        Console.WriteLine("Shuffling using Riffle Shuffle");
                        break;
                    case 3:
                        pack.shuffleCardPack(3);
                        Console.WriteLine("Deck has not been shuffled.");
                        break;
                    case 4:
                        quit = true;
                        break;
                }

                if (!quit)
                {
                    Console.WriteLine("Choose to deal a card or several cards");
                    Console.WriteLine("1 - Deal a card");
                    Console.WriteLine("2 - Deal several");

                    int dealChoice = int.Parse(Console.ReadLine());

                    switch (dealChoice)
                    {
                        case 1:
                            Console.WriteLine("You've been dealt: " + pack.deal());
                            break;
                        case 2:
                            Console.WriteLine("Enter amount of cards to deal");
                            int amount = int.Parse(Console.ReadLine());
                            if (amount > pack.shuffledDeck.Count)
                            {
                                Console.WriteLine("There are not enough cards to deal this amount. Amount left:", amount);
                            }
                            else
                            {
                                Console.WriteLine("You've been dealt: ");
                                foreach (string card in pack.dealCard(amount))
                                {
                                    Console.WriteLine(card);
                                }
                            }
                            break;
                    }

                    if (pack.shuffledDeck.Count == 0)
                    {
                        Console.WriteLine("There are no more cards to draw.");
                        quit = true;
                    }
                }


            }
            

        }
    }
}