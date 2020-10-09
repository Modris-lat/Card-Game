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
            return string.Join(" ", orderOfCards);
        }

        public void GetOutput()
        {
            var handsList = new List<IHand>() { };
            var listOfEquals = new List<List<IHand>>() { };
            while (CardsOnHands.ShowCardsOnHandsList().Any())
            {
                var returnedValues =
                    Calculate.CalculateCardsValues(Table.ShowCardsOnTable(), CardsOnHands.ShowCardsOnHandsList());
                var strongestHand = returnedValues.Item1;
                if (returnedValues.Item2.Any())
                {
                    listOfEquals.Add(returnedValues.Item2);
                    foreach (var hand in returnedValues.Item2)
                    {
                        CardsOnHands.RemoveHand(hand.Id);
                    }
                }
                handsList.Add(strongestHand);
                CardsOnHands.RemoveHand(strongestHand.Id);
            }
            handsList.Reverse();
            foreach (var hand in handsList)
            {
                orderOfCards.Add(string.Concat(hand.GetCards()[0].Rank, hand.GetCards()[0].Suit) +
                                 string.Concat(hand.GetCards()[1].Rank, hand.GetCards()[1].Suit));
            }
        }
    }
}
