using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texas_holdem_engine_01
{
    public interface ICardsOnHandsList
    {
        void AddCardsToHandsList();
        Dictionary<int, List<Card>> ShowCardsOnHandsList();
        void RemoveHand(int number);
    }
}
