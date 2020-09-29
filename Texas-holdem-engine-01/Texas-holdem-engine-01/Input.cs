using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texas_holdem_engine_01
{
    public class Input: IGetInput
    {
        public IList<string> GetInput(string input)
        {
            string[] arr = input.Split(' ');
            return new List<string>(arr);
        }
    }
}
