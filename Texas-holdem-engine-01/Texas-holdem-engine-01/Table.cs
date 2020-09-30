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
            for (int i = 0; i < str.Length; i++)
            {
                if (i % 2 != 0)
                {
                    string card = string.Empty;
                    card = str.Substring(i-1, 2);
                    CardsListOnTable.Add(new Card(card[0], card[1]));
                }
            }
        }

        public IList<Card> ShowCardsOnTable()
        {
            return CardsListOnTable;
        }
    }
}
