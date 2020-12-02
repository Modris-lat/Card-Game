using System.Collections.Generic;

namespace Engine.Models
{
    public class Hand
    {
        public Hand(int id, List<Card> cards)
        {
            Id = id;
            Cards = cards;
        }
        public int Id { get; }
        public List<Card> Cards { get; }
        public int HandStrength { get; set; }
    }
}
