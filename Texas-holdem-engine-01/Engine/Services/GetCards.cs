using System.Collections.Generic;
using Engine.Interfaces;
using Engine.Models;

namespace Engine.Services
{
    public class GetCards : IGetCards
    {
        public (List<Card>, List<Hand>) ConvertInput(GameInput input)
        {
            var hands = new List<Hand> { };
            var table = ExtractListOfCards(input.Table);
            for (int i = 0; i < input.Hands.Count; i++)
            {
                var hand = new Hand(i, ExtractListOfCards(input.Hands[i]));
                hands.Add(hand);
            }

            return (table, hands);
        }

        List<Card> ExtractListOfCards(string cards)
        {
            var cardList = new List<Card> { };
            for (int i = 0; i < cards.Length; i++)
            {
                if (i % 2 != 0)
                {
                    string cardString = cards.Substring(i - 1, 2);
                    var card = new Card(cardString[0], cardString[1]);
                    cardList.Add(card);
                }
            }

            return cardList;
        }
    }
}
