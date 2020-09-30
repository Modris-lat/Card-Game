using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texas_holdem_engine_01
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
