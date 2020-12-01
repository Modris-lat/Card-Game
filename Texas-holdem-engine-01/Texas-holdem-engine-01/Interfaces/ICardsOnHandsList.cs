using System.Collections.Generic;

namespace Texas_holdem_engine_01.Interfaces
{
    public interface ICardsOnHandsList
    {
        void AddHands(List<string> hands);
        List<IHand> ShowCardsOnHandsList();
        void RemoveHand(int id);
    }
}
