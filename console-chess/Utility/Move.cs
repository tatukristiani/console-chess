using console_chess.Board;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_chess.Utility
{
    /// <summary>
    /// Utility class for chess piece move. Holds information of the old position and new position of the chess piece.
    /// </summary>
    public class Move
    {
        public Position OldPosition;
        public Position NewPosition;

        /// <summary>
        /// Constructor which takes the old and new position of the chess piece.
        /// </summary>
        /// <param name="oldPosition">Old Position of the chess piece</param>
        /// <param name="newPosition">New position of the chess piece</param>
        public Move(Position oldPosition, Position newPosition)
        { 
            OldPosition = oldPosition;
            NewPosition = newPosition;
        }
    }
}
