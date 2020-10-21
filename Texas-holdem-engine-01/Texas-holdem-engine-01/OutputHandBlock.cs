using System.Collections.Generic;
using System.Linq;
using Texas_holdem_engine_01.Interfaces;

namespace Texas_holdem_engine_01
{
    public class OutputHandBlock:IOutput
    {
        private ITable Table;
        private ICardsOnHandsList CardsOnHands;
        private List<string> OutputList;
        private ICalculateHandValues Calculate;

        public OutputHandBlock(ITable table, ICardsOnHandsList cardsOnHandsList, ICalculateHandValues calculate)
        {
            Table = table;
            CardsOnHands = cardsOnHandsList;
            OutputList = new List<string>();
            Calculate = calculate;
        }
        public string Output()
        {
            OutputList.Reverse();
            return string.Join(" ", OutputList);
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
                    OutputList.Add(string.Concat(strongestHand.GetCards()[0].Rank, strongestHand.GetCards()[0].Suit) +
                                   string.Concat(strongestHand.GetCards()[1].Rank, strongestHand.GetCards()[1].Suit));
                }
                else
                {
                    OutputList[OutputList.Count - 1] =
                        string.Concat(strongestHand.GetCards()[0].Rank, strongestHand.GetCards()[0].Suit) +
                        string.Concat(strongestHand.GetCards()[1].Rank, strongestHand.GetCards()[1].Suit) + '=' +
                        OutputList[OutputList.Count - 1];
                }
                cardsOnHands.Remove(strongestHand);
            }
        }
    }
}
