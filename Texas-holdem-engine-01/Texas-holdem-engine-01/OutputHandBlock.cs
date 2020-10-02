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
            return string.Join(" ", CardsOnHands);
        }

        public void GetOutput()
        {
            while (CardsOnHands.ShowCardsOnHandsList().Count > 0)
            {
                var strongestHand = Calculate.CalculateCardsValues(Table.ShowCardsOnTable(), CardsOnHands.ShowCardsOnHandsList());
                var strongestCards = strongestHand.GetCards();
                for (int i = 0; i < strongestCards.Count; i++)
                {
                    orderOfCards.Add(string.Concat(strongestCards[i].Rank.ToString(), strongestCards[i].Suit.ToString()));
                }

                CardsOnHands.RemoveHand(strongestHand);
            }
        }
    }
}
