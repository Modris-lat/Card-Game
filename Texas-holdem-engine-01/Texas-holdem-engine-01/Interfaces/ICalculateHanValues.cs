using System.Collections.Generic;
using Texas_holdem_engine_01.CardSets;

namespace Texas_holdem_engine_01.Interfaces
{
    public interface ICalculateHandValues
    {
        IHand CalculateCardsValues(IList<Card> table, List<IHand> hands);
    }
}
