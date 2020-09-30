using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texas_holdem_engine_01
{
    public class CardsOnHandsList: ICardsOnHandsList
    {
        private Dictionary<int, List<Card>> CardsOnHands;
        private IGetInput Input;

        public CardsOnHandsList(IGetInput input)
        {
            CardsOnHands = new Dictionary<int, List<Card>>(){};
            Input = input;
        }

        public void AddCardsToHandsList()
        {
            var list = Input.ShowInput();
            list.RemoveAt(0);
            for (int i = 0; i < list.Count; i++)
            {
                var hand = list[i];
                CardsOnHands.Add(i, ExtractCards.ExtractListOfCards(hand));
            }
        }

        public Dictionary<int, List<Card>> ShowCardsOnHandsList()
        {
            return CardsOnHands;
        }
    }
}
