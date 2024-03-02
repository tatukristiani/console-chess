using console_chess.Board;
using console_chess.ChessPieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_chess.Players
{
    public class RealPlayer : APlayer
    {
        public RealPlayer(string name, ChessBoard board, Color color) : base(name, board, color) { }

        public override void ChoosePieceToMove(AChessPiece piece, Position originalPosition)
        {
            base.board.ChoosePieceToMove(originalPosition);
        }

        public override bool Move(AChessPiece piece, Position originalPosition, Position newPosition)
        {
            return board.MoveChessPieceOnBoard(piece, originalPosition, newPosition);
        }
    }
}
