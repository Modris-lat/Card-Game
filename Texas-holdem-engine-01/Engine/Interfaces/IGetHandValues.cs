using System.Collections.Generic;
using Engine.Models;

namespace Engine.Interfaces
{
    public interface IGetHandValues
    { 
        IEnumerable<Hand> Calculate(List<Card> table, List<Hand> hands);
    }
}
