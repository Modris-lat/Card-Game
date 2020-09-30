using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texas_holdem_engine_01
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
                    string card = string.Empty;
                    card = cards.Substring(i - 1, 2);
                    cardList.Add(new Card(card[0], card[1]));
                }
            }

            return cardList;
        }
    }
}
