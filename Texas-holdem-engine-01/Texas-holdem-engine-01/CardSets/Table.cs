using System.Collections.Generic;
using Texas_holdem_engine_01.Interfaces;
using Texas_holdem_engine_01.StaticGetValues;

namespace Texas_holdem_engine_01.CardSets
{
    public class Table: ITable
    {
        private List<Card> _cardsListOnTable;

        public Table()
        {
            _cardsListOnTable = new List<Card>{};
        }
        public void GetCardsOnTable(string inputTableCards)
        {
            _cardsListOnTable = ExtractCards.ExtractListOfCards(inputTableCards);
        }

        public IList<Card> ShowCardsOnTable()
        {
            return _cardsListOnTable;
        }
    }
}
