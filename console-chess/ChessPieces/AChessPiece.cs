using console_chess.Board;
using console_chess.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace console_chess.ChessPieces
{
    /// <summary>
    /// Abstract class for chess pieces
    /// </summary>
    public abstract class AChessPiece
    {
        public string? Name { get; set; }

        public Color Color { get; set; }

        public string? Icon { get; set; }

        public bool HasMoved { get; set; } = false;

        public AChessPiece(Color color)
        {
            Color = color;
        }

        public abstract List<Move> ListPossibleMoves(Position originalPos);

        public abstract List<Move> ListValidMoves(List<Move> possibleMoves);
    }
}
