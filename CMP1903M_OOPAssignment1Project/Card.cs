using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Card
    {
        //Base for the Card class.
        //Value: numbers 1 - 13
        //Suit: numbers 1 - 4

        //The 'set' methods for these properties could have some validation
        public string[] Value { get; set; } = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace"}; //Initialises each value: 2, 3, 4, 5, 6, 7, 8 , 9, 10, Jack, Queen, King, Ace. 13 values in total.

        public string[] Suits { get; set; } = { "Clubs", "Hearts", "Diamonds", "Spades" }; //Initialises the Suits

    }
}