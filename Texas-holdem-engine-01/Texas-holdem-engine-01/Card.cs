using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texas_holdem_engine_01
{
    public class Card
    {
        public char Rank { get; set; }
        public char Suit { get; set; }

        public Card() { }

        public Card(char rank, char suit)
        {
            Rank = rank;
            Suit = suit;
        }
    }
}
