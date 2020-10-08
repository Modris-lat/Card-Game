using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Texas_holdem_engine_01.Interfaces;
using Texas_holdem_engine_01.Static;

namespace Texas_holdem_engine_01
{
    public class CalculateHandValues: ICalculateHandValues
    {
        public IHand CalculateCardsValues(IList<Card> table, List<IHand> hands)
        {
            foreach (var item in hands)
            {
                var hand = new List<Card>(table);
                hand.Add(item.GetCards()[0]);
                hand.Add(item.GetCards()[1]);
                item.HighCard = CheckHighCard.HighestCard(hand);
                item.Flush = CheckFlush.CheckIfFlush(hand);
                int pairs = CheckPairs.CheckForPair(hand);
                if (pairs == 1)
                {
                    item.Pair = true;
                }
                else if (pairs == 2)
                {
                    item.TwoPair = true;
                }
                int threeOfKind = CheckThreeAndFourKind.ThreeAndFourOfKind(hand).Item1;
                int fourOfKind = CheckThreeAndFourKind.ThreeAndFourOfKind(hand).Item2;
                if (threeOfKind == 1)
                {
                    item.ThreeOfKind = true;
                }

                if (fourOfKind == 1)
                {
                    item.FourOfKind = true;
                }
                item.Straight = CheckStraight.CheckIfStraight(hand);
                if (item.ThreeOfKind && item.Pair)
                {
                    item.FullHouse = true;
                }

                if (item.Flush != ' ' && item.Straight)
                {
                    item.RoyalFlush = CheckRoyalFlush.RoyalFlush(hand, item.Flush);
                    item.StraightFl = CheckStraightFlush.StraightFlush(hand, item.Flush);
                }
            }
            throw new NotImplementedException();
        }

    }
}
