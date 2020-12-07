using System.Collections.Generic;
using Engine.Models;

namespace Engine.Interfaces
{
    public interface IGetCards
    {
        (List<Card>, List<Hand>) ConvertInput(GameInput input);
    }
}
