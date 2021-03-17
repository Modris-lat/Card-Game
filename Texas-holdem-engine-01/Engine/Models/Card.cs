using Engine.Rankings;

namespace Engine.Models
{
    public class Card
    {
        public char Rank { get; }
        public char Suit { get; }
        public int CardValue { get; private set; }

        public Card(char rank, char suit)
        {
            Rank = rank;
            Suit = suit;
            SetCardValue(rank);
        }

        void SetCardValue(char rank)
        {
            switch (rank)
            {
                case '2':
                    CardValue = CardRankings.Rank2;
                    break;
                case '3':
                    CardValue = CardRankings.Rank3;
                    break;
                case '4':
                    CardValue = CardRankings.Rank4;
                    break;
                case '5':
                    CardValue = CardRankings.Rank5;
                    break;
                case '6':
                    CardValue = CardRankings.Rank6;
                    break;
                case '7':
                    CardValue = CardRankings.Rank7;
                    break;
                case '8':
                    CardValue = CardRankings.Rank8;
                    break;
                case '9':
                    CardValue = CardRankings.Rank9;
                    break;
                case 'T':
                    CardValue = CardRankings.RankT;
                    break;
                case 'J':
                    CardValue = CardRankings.RankJ;
                    break;
                case 'Q':
                    CardValue = CardRankings.RankQ;
                    break;
                case 'K':
                    CardValue = CardRankings.RankK;
                    break;
                case 'A':
                    CardValue = CardRankings.RankA;
                    break;
            }
        }
    }
}
