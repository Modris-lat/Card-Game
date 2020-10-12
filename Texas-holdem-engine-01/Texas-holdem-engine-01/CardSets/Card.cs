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
        public int CardValue { get; set; }

        public Card() { }

        public Card(char rank, char suit)
        {
            Rank = rank;
            Suit = suit;
        }

        public void SetCardValue()
        {
            if (Rank == '2')
            {
                CardValue = CardRankings.Rank2;
            }
            if (Rank == '3')
            {
                CardValue = CardRankings.Rank3;
            }
            if (Rank == '4')
            {
                CardValue = CardRankings.Rank4;
            }
            if (Rank == '5')
            {
                CardValue = CardRankings.Rank5;
            }
            if (Rank == '6')
            {
                CardValue = CardRankings.Rank6;
            }
            if (Rank == '7')
            {
                CardValue = CardRankings.Rank7;
            }
            if (Rank == '8')
            {
                CardValue = CardRankings.Rank8;
            }
            if (Rank == '9')
            {
                CardValue = CardRankings.Rank9;
            }
            if (Rank == 'T')
            {
                CardValue = CardRankings.RankT;
            }
            if (Rank == 'J')
            {
                CardValue = CardRankings.RankJ;
            }
            if (Rank == 'Q')
            {
                CardValue = CardRankings.RankQ;
            }
            if (Rank == 'K')
            {
                CardValue = CardRankings.RankK;
            }
            if (Rank == 'A')
            {
                CardValue = CardRankings.RankA;
            }
        }
    }
}
