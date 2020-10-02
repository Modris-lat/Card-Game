using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Texas_holdem_engine_01.Interfaces;

namespace Texas_holdem_engine_01
{
    public interface ICardsOnHandsList
    {
        void AddCardsToHandsList();
        List<IHand> ShowCardsOnHandsList();
        void RemoveHand(IHand hand);
    }
}
