using System.Collections.Generic;
using Texas_holdem_engine_01.CardSets;

namespace Texas_holdem_engine_01.Interfaces
{
    public interface ITable
    {
        void GetCardsOnTable(string inputCards);
        IList<Card> ShowCardsOnTable();
    }
}
