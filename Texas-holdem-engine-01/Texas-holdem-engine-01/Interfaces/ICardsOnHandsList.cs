using System.Collections.Generic;

namespace Texas_holdem_engine_01.Interfaces
{
    public interface ICardsOnHandsList
    {
        void AddCardsToHandsList();
        List<IHand> ShowCardsOnHandsList();
        void RemoveHand(int id);
    }
}
