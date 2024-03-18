using console_chess.Board;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_chess.Utility
{
    public class Move
    {
        public Position OldPosition;
        public Position NewPosition;

        public Move(Position oldPosition, Position newPosition)
        { 
            OldPosition = oldPosition;
            NewPosition = newPosition;
        }
    }
}
