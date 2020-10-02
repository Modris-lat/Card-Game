using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texas_holdem_engine_01.Interfaces
{
    public interface IHand
    {
        int Id { get; set; }
        List<Card> GetCards();
        bool RoyalFlush { get; set; }
        bool StraightFl { get; set; }
        bool FullHouse { get; set; }
        bool Flush { get; set; }
        bool Straight { get; set; }
        bool ThreeOfKind { get; set; }
        bool TwoPair { get; set; }
        bool Pair { get; set; }
        int HighCard { get; set; }
    }
}
