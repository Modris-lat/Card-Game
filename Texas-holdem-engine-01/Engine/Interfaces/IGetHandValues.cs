using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Interfaces
{
    public interface IGetHandValues
    { 
        IEnumerable<Hand> Calculate(List<Card> table, List<Hand> hands);
    }
}
