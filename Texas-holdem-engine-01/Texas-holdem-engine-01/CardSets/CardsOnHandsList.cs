using System.Collections.Generic;
using System.Linq;
using Texas_holdem_engine_01.Interfaces;
using Texas_holdem_engine_01.StaticGetValues;

namespace Texas_holdem_engine_01.CardSets
{
    public class CardsOnHandsList: ICardsOnHandsList
    {
        private List<IHand> _hands;

        public CardsOnHandsList()
        {
            _hands = new List<IHand>{};
        }

        public void AddHands(List<string> hands)
        {
            for (int i = 0; i < hands.Count; i++)
            {
                var hand = hands[i];
                var listOfCardsInHand = ExtractCards.ExtractListOfCards(hand);
                _hands.Add(new Hand(i, listOfCardsInHand));
            }
        }

        public List<IHand> ShowCardsOnHandsList()
        {
            return _hands;
        }

        public void RemoveHand(int id)
        {
            var hand = _hands.SingleOrDefault(h => id == h.Id);
            if(hand != null)
            {
                _hands.Remove(hand);
            }
        }
    }
}
