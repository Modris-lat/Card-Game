using System.Collections.Generic;
using Engine.Models;

namespace Engine.Interfaces
{
    public interface IGetOutputResponse
    {
        IEnumerable<Response> GetResponse(IEnumerable<Hand> hands);
    }
}
