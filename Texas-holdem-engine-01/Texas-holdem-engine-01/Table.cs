using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Texas_holdem_engine_01.CardSets;

namespace Engine.Models
{
    public class Table
    {
        public Table(List<Card> cards)
        {
            Cards = cards;
        }
        public List<Card> Cards { get; }
    }
}
