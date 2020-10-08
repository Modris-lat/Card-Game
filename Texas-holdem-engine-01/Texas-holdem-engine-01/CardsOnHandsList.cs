using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Texas_holdem_engine_01.Interfaces;

namespace Texas_holdem_engine_01
{
    public class CardsOnHandsList: ICardsOnHandsList
    {
        private List<IHand> CardsOnHands;
        private IGetInput Input;

        public CardsOnHandsList(IGetInput input)
        {
            CardsOnHands = new List<IHand>(){};
            Input = input;
        }

        public void AddCardsToHandsList()
        {
            var list = Input.ShowInput();
            list.RemoveAt(0);
            for (int i = 0; i < list.Count; i++)
            {
                var hand = list[i];
                var listOfCardsInHand = ExtractCards.ExtractListOfCards(hand);
                CardsOnHands.Add(new Hand(i, listOfCardsInHand));
            }
        }

        public List<IHand> ShowCardsOnHandsList()
        {
            return CardsOnHands;
        }

        public void RemoveHand(int id)
        {
            var hand = CardsOnHands.SingleOrDefault(h => id == h.Id);
            if(hand != null)
            {
                CardsOnHands.Remove(hand);
            }
        }
    }
}
