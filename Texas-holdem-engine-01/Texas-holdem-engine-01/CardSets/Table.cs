using System.Collections.Generic;
using Texas_holdem_engine_01.Interfaces;
using Texas_holdem_engine_01.StaticGetValues;

namespace Texas_holdem_engine_01.CardSets
{
    public class Table: ITable
    {
        private IGetInput Input;
        private List<Card> CardsListOnTable;

        public Table(IGetInput input)
        {
            Input = input;
            CardsListOnTable = new List<Card>(){};
        }
        public void GetCardsOnTable()
        {
            string str = Input.ShowInput()[0];
            CardsListOnTable = ExtractCards.ExtractListOfCards(str);
        }

        public IList<Card> ShowCardsOnTable()
        {
            return CardsListOnTable;
        }
    }
}
