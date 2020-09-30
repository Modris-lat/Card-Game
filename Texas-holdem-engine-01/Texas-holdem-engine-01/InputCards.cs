using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texas_holdem_engine_01
{
    public class InputCards: IGetInput
    {
        List<string> InputList;
        public void GetInput(string input)
        {
            string[] arr = input.Split(' ');
            InputList = new List<string>(arr);
        }

        public IList<string> ShowInput()
        {
            return InputList;
        }
    }
}
