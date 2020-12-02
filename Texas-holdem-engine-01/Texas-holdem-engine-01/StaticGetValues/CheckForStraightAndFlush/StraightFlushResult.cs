using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texas_holdem_engine_01.StaticGetValues.CheckForStraightAndFlush
{
    public class StraightFlushResult
    {
        public bool Straight { get; set; }
        public int StraightValue { get; set; }
        public bool Flush { get; set; }
        public int FlushValue { get; set; }
        public bool StraightFlush { get; set; }
        public bool StraightFlushValue { get; set; }
        public bool RoyalFlush { get; set; }
    }
}
