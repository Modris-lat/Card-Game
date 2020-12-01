using System.Collections.Generic;
using System.Linq;
using Texas_holdem_engine_01.CardSets;

namespace Texas_holdem_engine_01.StaticGetValues.CheckEqualRanks
{
    public class CheckEqualRanks
    {
        public static CheckEqualRanksResult CheckForEqualRanks(List<Card> cards)
        {
            var result = new CheckEqualRanksResult();
            var listOf2 = cards.Where(card => card.Rank == '2');
            int count2 = listOf2.Count();
            if (count2 == 2)
            {
                result.PairCount++;
                result.PairValue += CardRankings.Rank2;
            }
            else if (count2 == 3)
            {
                result.ThreeOfKind = true;
                result.ThreeOfKindValue = CardRankings.Rank2;
            }
            else if (count2 == 4)
            {
                result.FourOfKind = true;
                result.FourOfKindValue = CardRankings.Rank2;
            }
            var listOf3 = cards.Where(card => card.Rank == '3');
            int count3 = listOf3.Count();
            if (count3 == 2)
            {
                result.PairCount++;
                result.PairValue += CardRankings.Rank3;
            }
            else if (count3 == 3)
            {
                result.ThreeOfKind = true;
                result.ThreeOfKindValue = CardRankings.Rank3;
            }
            else if (count3 == 4)
            {
                result.FourOfKind = true;
                result.FourOfKindValue = CardRankings.Rank3;
            }
            var listOf4 = cards.Where(card => card.Rank == '4');
            int count4 = listOf4.Count();
            if (count4 == 2)
            {
                result.PairCount++;
                result.PairValue += CardRankings.Rank4;
            }
            else if (count4 == 3)
            {
                result.ThreeOfKind = true;
                result.ThreeOfKindValue = CardRankings.Rank4;
            }
            else if (count4 == 4)
            {
                result.FourOfKind = true;
                result.FourOfKindValue = CardRankings.Rank4;
            }
            var listOf5 = cards.Where(card => card.Rank == '5');
            int count5 = listOf5.Count();
            if (count5 == 2)
            {
                result.PairCount++;
                result.PairValue += CardRankings.Rank5;
            }
            else if (count5 == 3)
            {
                result.ThreeOfKind = true;
                result.ThreeOfKindValue = CardRankings.Rank5;
            }
            else if (count5 == 4)
            {
                result.FourOfKind = true;
                result.FourOfKindValue = CardRankings.Rank5;
            }
            var listOf6 = cards.Where(card => card.Rank == '6');
            int count6 = listOf6.Count();
            if (count6 == 2)
            {
                result.PairCount++;
                result.PairValue += CardRankings.Rank6;
            }
            else if (count6 == 3)
            {
                result.ThreeOfKind = true;
                result.ThreeOfKindValue = CardRankings.Rank6;
            }
            else if (count6 == 4)
            {
                result.FourOfKind = true;
                result.FourOfKindValue = CardRankings.Rank6;
            }
            var listOf7 = cards.Where(card => card.Rank == '7');
            int count7 = listOf7.Count();
            if (count7 == 2)
            {
                result.PairCount++;
                result.PairValue += CardRankings.Rank7;
            }
            else if (count7 == 3)
            {
                result.ThreeOfKind = true;
                result.ThreeOfKindValue = CardRankings.Rank7;
            }
            else if (count7 == 4)
            {
                result.FourOfKind = true;
                result.FourOfKindValue = CardRankings.Rank7;
            }
            var listOf8 = cards.Where(card => card.Rank == '8');
            int count8 = listOf8.Count();
            if (count8 == 2)
            {
                result.PairCount++;
                result.PairValue += CardRankings.Rank8;
            }
            else if (count8 == 3)
            {
                result.ThreeOfKind = true;
                result.ThreeOfKindValue = CardRankings.Rank8;
            }
            else if (count8 == 4)
            {
                result.FourOfKind = true;
                result.FourOfKindValue = CardRankings.Rank8;
            }
            var listOf9 = cards.Where(card => card.Rank == '9');
            int count9 = listOf9.Count();
            if (count9 == 2)
            {
                result.PairCount++;
                result.PairValue += CardRankings.Rank9;
            }
            else if (count9 == 3)
            {
                result.ThreeOfKind = true;
                result.ThreeOfKindValue = CardRankings.Rank9;
            }
            else if (count9 == 4)
            {
                result.FourOfKind = true;
                result.FourOfKindValue = CardRankings.Rank9;
            }
            var listOfT = cards.Where(card => card.Rank == 'T');
            int countT = listOfT.Count();
            if (countT == 2)
            {
                result.PairCount++;
                result.PairValue += CardRankings.RankT;
            }
            else if (countT == 3)
            {
                result.ThreeOfKind = true;
                result.ThreeOfKindValue = CardRankings.RankT;
            }
            else if (countT == 4)
            {
                result.FourOfKind = true;
                result.FourOfKindValue = CardRankings.RankT;
            }
            var listOfJ = cards.Where(card => card.Rank == 'J');
            int countJ = listOfJ.Count();
            if (countJ == 2)
            {
                result.PairCount++;
                result.PairValue += CardRankings.RankJ;
            }
            else if (countJ == 3)
            {
                result.ThreeOfKind = true;
                result.ThreeOfKindValue = CardRankings.RankJ;
            }
            else if (countJ == 4)
            {
                result.FourOfKind = true;
                result.FourOfKindValue = CardRankings.RankJ;
            }
            var listOfQ = cards.Where(card => card.Rank == 'Q');
            int countQ = listOfQ.Count();
            if (countQ == 2)
            {
                result.PairCount++;
                result.PairValue += CardRankings.RankQ;
            }
            else if (countQ == 3)
            {
                result.ThreeOfKind = true;
                result.ThreeOfKindValue = CardRankings.RankQ;
            }
            else if (countQ == 4)
            {
                result.FourOfKind = true;
                result.FourOfKindValue = CardRankings.RankQ;
            }
            var listOfK = cards.Where(card => card.Rank == 'K');
            int countK = listOfK.Count();
            if (countK == 2)
            {
                result.PairCount++;
                result.PairValue += CardRankings.RankK;
            }
            else if (countK == 3)
            {
                result.ThreeOfKind = true;
                result.ThreeOfKindValue = CardRankings.RankK;
            }
            else if (countK == 4)
            {
                result.FourOfKind = true;
                result.FourOfKindValue = CardRankings.RankK;
            }
            var listOfA = cards.Where(card => card.Rank == 'A');
            int countA = listOfA.Count();
            if (countA == 2)
            {
                result.PairCount++;
                result.PairValue += CardRankings.RankA;
            }
            else if (countA == 3)
            {
                result.ThreeOfKind = true;
                result.ThreeOfKindValue = CardRankings.RankA;
            }
            else if (countA == 4)
            {
                result.FourOfKind = true;
                result.FourOfKindValue = CardRankings.RankA;
            }
            return result;
        }
    }
}
