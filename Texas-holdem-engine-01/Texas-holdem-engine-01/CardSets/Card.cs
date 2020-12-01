using Texas_holdem_engine_01.StaticGetValues;

namespace Texas_holdem_engine_01.CardSets
{
    public class Card
    {
        public char Rank { get; }
        public char Suit { get; }
        public int CardValue { get; set; }

        public Card(char rank, char suit)
        {
            Rank = rank;
            Suit = suit;
            SetCardValue();
        }

        void SetCardValue()
        {
            if (Rank == '2')
            {
                CardValue = CardRankings.Rank2;
            }
            else if (Rank == '3')
            {
                CardValue = CardRankings.Rank3;
            }
            else if (Rank == '4')
            {
                CardValue = CardRankings.Rank4;
            }
            else if (Rank == '5')
            {
                CardValue = CardRankings.Rank5;
            }
            else if (Rank == '6')
            {
                CardValue = CardRankings.Rank6;
            }
            else if (Rank == '7')
            {
                CardValue = CardRankings.Rank7;
            }
            else if (Rank == '8')
            {
                CardValue = CardRankings.Rank8;
            }
            else if (Rank == '9')
            {
                CardValue = CardRankings.Rank9;
            }
            else if (Rank == 'T')
            {
                CardValue = CardRankings.RankT;
            }
            else if (Rank == 'J')
            {
                CardValue = CardRankings.RankJ;
            }
            else if (Rank == 'Q')
            {
                CardValue = CardRankings.RankQ;
            }
            else if (Rank == 'K')
            {
                CardValue = CardRankings.RankK;
            }
            else if (Rank == 'A')
            {
                CardValue = CardRankings.RankA;
            }
        }
    }
}
