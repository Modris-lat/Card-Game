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

        public Table(IGetInput input)
        {
            Input = input;
        }
        public IList<string> GetCardsOnTable()
        {
            string str = Input.ShowInput()[0];
            var cardList = new List<string>() {};
            for (int i = 0; i < str.Length; i++)
            {
                if (i % 2 != 0)
                {
                    string card = string.Empty;
                    card = str.Substring(i-1, 2);
                    cardList.Add(card);
                }
            }
            return cardList;
        }
    }
}
