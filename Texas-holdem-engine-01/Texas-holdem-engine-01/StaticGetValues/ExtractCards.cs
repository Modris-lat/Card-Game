using System.Collections.Generic;
using Texas_holdem_engine_01.CardSets;

namespace Texas_holdem_engine_01.StaticGetValues
{
    public class ExtractCards
    {
        public static List<Card> ExtractListOfCards(string cards)
        {
            var cardList = new List<Card>() { };
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
