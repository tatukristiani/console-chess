using console_chess.Board;
using console_chess.ChessPieces;
using console_chess.Utility;
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
        public Color Color { get; set; }

        public APlayer(string name, Color color)
        {
            Name = name;
            Color = color;
        }

        public abstract void MoveChessPiece(Position oldPosition);
        public abstract ChosenMove ChoosePieceToMove();
    }
}
