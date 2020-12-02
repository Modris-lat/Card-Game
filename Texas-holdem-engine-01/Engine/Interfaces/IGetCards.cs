using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Interfaces
{
    public interface IGetCards
    {
        (List<Card>, List<Hand>) ConvertInput(GameInput input);
    }
}
