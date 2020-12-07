using System.Collections.Generic;

namespace Engine.Models
{
    public class Response
    {
        public Response(Hand hand)
        {
            Hand = GetCards(hand.Cards);
            HandValue = hand.HandStrength;
            HandValueType = hand.HandValueType;
        }
        public List<string> Hand { get; }
        public int HandValue { get; }
        public string HandValueType { get; }

        List<string> GetCards(List<Card> cards)
        {
            var cardList = new List<string>
            {
                cards[0].Rank.ToString() + cards[0].Suit,
                cards[1].Rank.ToString() + cards[1].Suit
            };
            return  cardList;
        }
    }
}
