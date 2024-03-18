using console_chess.Board;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_chess.Utility
{
    public class ChosenMove
    {
        public Position ChosenChessPiecePosition { get; set; }
        public List<Move> PossibleMoves { get; set; }

        public ChosenMove(Position chosenChessPiecePosition, List<Move> possibleMoves)
        {
            ChosenChessPiecePosition = chosenChessPiecePosition;
            PossibleMoves = possibleMoves;
        }   
    }
}
