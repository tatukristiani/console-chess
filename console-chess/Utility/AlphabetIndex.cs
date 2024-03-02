using console_chess.Board;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_chess.Utility
{
    public static class AlphabetIndex
    {
        public static int GetIndex(Position position)
        {
            return (int)position.ToString().ToCharArray()[0] % 32;
        }
    }
}
