using console_chess.Board;
using console_chess.ChessPieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_chess.Players
{
    public abstract class APlayer
    {
        public string Name { get; set; }
        public ChessBoard board;

        public APlayer(string name, ChessBoard board)
        {
            Name = name;
            this.board = board;
        }

        public abstract bool Move(AChessPiece piece, Position originalPosition, Position newPosition);

        public abstract void ChoosePieceToMove(AChessPiece piece, Position originalPosition);
    }
}
