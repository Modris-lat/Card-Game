using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texas_holdem_engine_01
{
    public interface ITable
    {
        void GetCardsOnTable();
        IList<string> ShowCardsOnTable();
    }
}
