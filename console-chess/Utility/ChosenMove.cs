using console_chess.Board;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_chess.Utility
{
    /// <summary>
    /// Utility class that holds information on which chess piece is going to be moved & the possible moves for that chess piece.
    /// </summary>
    public class ChosenMove
    {
        public Position ChosenChessPiecePosition { get; set; }
        public List<Move> PossibleMoves { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="chosenChessPiecePosition">Position of the chosen chess piece to move</param>
        /// <param name="possibleMoves">List of possible Move objects for the chosen chess piece</param>
        public ChosenMove(Position chosenChessPiecePosition, List<Move> possibleMoves)
        {
            ChosenChessPiecePosition = chosenChessPiecePosition;
            PossibleMoves = possibleMoves;
        }   
    }
}
