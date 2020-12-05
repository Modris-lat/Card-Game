using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Response
    {
        public Response(Hand hand, bool tie)
        {
            Tie = tie;
            Hand = GetCards(hand.Cards);
        }
        public string Hand { get; }
        public bool Tie { get; }

        string GetCards(List<Card> cards)
        {
            return cards[0].Rank.ToString() + cards[0].Suit + cards[1].Rank + cards[1].Suit;
        }
    }
}
