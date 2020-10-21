using System.Collections.Generic;

namespace Texas_holdem_engine_01.Interfaces
{
    public interface IGetInput
    {
        void GetInput(string input);
        IList<string> ShowInput();
    }
}
