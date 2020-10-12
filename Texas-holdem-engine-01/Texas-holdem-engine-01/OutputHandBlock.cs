using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Texas_holdem_engine_01.Interfaces;

namespace Texas_holdem_engine_01
{
    public class OutputHandBlock:IOutput
    {
        private ITable Table;
        private ICardsOnHandsList CardsOnHands;
        private List<string> orderOfCards;
        private ICalculateHandValues Calculate;

        public OutputHandBlock(ITable table, ICardsOnHandsList cardsOnHandsList, ICalculateHandValues calculate)
        {
            Table = table;
            CardsOnHands = cardsOnHandsList;
            orderOfCards = new List<string>();
            Calculate = calculate;
        }
        public string Output()
        {
            orderOfCards.Reverse();
            return string.Join(" ", orderOfCards);
        }

        public void GetOutput()
        {
            var handsList = new List<IHand>() { };
            var table = Table.ShowCardsOnTable();
            var cardsOnHands = CardsOnHands.ShowCardsOnHandsList();
            while (cardsOnHands.Any())
            {
                var strongestHand = Calculate.CalculateCardsValues(table, cardsOnHands);
                var hand = handsList.SingleOrDefault(h =>
                    strongestHand.GetStrengthOfHand() == h.GetStrengthOfHand());
                if (hand == null)
                {
                    handsList.Add(strongestHand);
                    orderOfCards.Add(string.Concat(strongestHand.GetCards()[0].Rank, strongestHand.GetCards()[0].Suit) +
                                     string.Concat(strongestHand.GetCards()[1].Rank, strongestHand.GetCards()[1].Suit));
                }
                else
                {
                    orderOfCards[orderOfCards.Count - 1] =
                        string.Concat(strongestHand.GetCards()[0].Rank, strongestHand.GetCards()[0].Suit) +
                        string.Concat(strongestHand.GetCards()[1].Rank, strongestHand.GetCards()[1].Suit) + '=' +
                        orderOfCards[orderOfCards.Count - 1];
                }
                cardsOnHands.Remove(strongestHand);
            }

            //orderOfCards.Add(string.Concat(hand.GetCards()[0].Rank, hand.GetCards()[0].Suit) +
            //                 string.Concat(hand.GetCards()[1].Rank, hand.GetCards()[1].Suit));
        }
    }
}
