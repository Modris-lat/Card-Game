using System.Collections.Generic;

namespace API.Service.Models
{
    public class GameInput
    {
        public string Table { get; set; }
        public List<string> Hands { get; set; }
    }
}