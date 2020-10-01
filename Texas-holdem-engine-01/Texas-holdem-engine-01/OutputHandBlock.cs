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

        public OutputHandBlock(ITable table, ICardsOnHandsList cardsOnHandsList)
        {
            Table = table;
            CardsOnHands = cardsOnHandsList;
            orderOfCards = new List<string>();
        }
        public string Output()
        {
            return string.Join(" ", CardsOnHands);
        }

        public void GetOutput()
        {
            while (CardsOnHands.ShowCardsOnHandsList().Count > 0)
            {
                var strongestHand = CalculateHandValues.CalculateCardsValues(Table.ShowCardsOnTable(), CardsOnHands.ShowCardsOnHandsList());
                var strongestCards = strongestHand.Item2;
                for (int i = 0; i < strongestCards.Count; i++)
                {
                    orderOfCards.Add(string.Concat(strongestCards[i].Rank.ToString(), strongestCards[i].Suit.ToString()));
                }

                CardsOnHands.RemoveHand(strongestHand.Item1);
            }
        }
    }
}
