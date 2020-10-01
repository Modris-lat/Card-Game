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
        string OutputString;

        public OutputHandBlock(ITable table, ICardsOnHandsList cardsOnHandsList)
        {
            Table = table;
            CardsOnHands = cardsOnHandsList;
        }
        public string Output()
        {
            return OutputString;
        }

        public void GetOutput()
        {
            var strongestHand = CalculateHandValues.CalculateCardsValues(Table.ShowCardsOnTable(), CardsOnHands.ShowCardsOnHandsList());
        }
    }
}
