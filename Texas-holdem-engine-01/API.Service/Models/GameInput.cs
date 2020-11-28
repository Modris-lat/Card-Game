using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Service.Models
{
    public class GameInput
    {
        public string Table { get; set; }
        public List<string> Hands { get; set; }
    }
}