using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Texas_holdem_engine_01.Interfaces;

namespace Texas_holdem_engine_01
{
    public class OutputHandBlock:IOutput
    {
        private ITable Table;
        private ICardsOnHandsList CardsOnHands;

        public OutputHandBlock(ITable table, ICardsOnHandsList cardsOnHandsList)
        {
            Table = table;
            CardsOnHands = cardsOnHandsList;
        }
        public string Output()
        {
            throw new NotImplementedException();
        }

        public void GetOutput()
        {
            throw new NotImplementedException();
        }
    }
}
