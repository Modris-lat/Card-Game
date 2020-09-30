using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texas_holdem_engine_01
{
    public class CardsOnHandsList: ICardsOnHandsList
    {
        private List<string> CardsOnHands;

        public CardsOnHandsList()
        {
            CardsOnHands = new List<string>(){};
        }

        public void AddCardsToHandsList()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> ShowCardsOnHandsList()
        {
            throw new NotImplementedException();
        }
    }
}
