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
        public int[] Value { get; set; } = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 }; //Initialises each value: 2, 3, 4, 5, 6, 7, 8 , 9, 10, Jack, Queen, King, Ace. 13 values in total.

        public string[] Suits { get; set; } = { "Clubs", "Hearts", "Spades", "Diamonds" }; //Initialises the Suits

    }
}
