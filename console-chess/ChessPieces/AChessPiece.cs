using console_chess.Board;
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
        public Dictionary<int, Tuple<string, string>> ChessPieceInformation = new Dictionary<int, Tuple<string, string>>()
        {
            { 1, new Tuple<string, string>("Pawn", "♙") },
            { 2, new Tuple<string, string>("Knight", "\u2658") },
            { 3, new Tuple<string, string>("Bishop","\u2657") },
            { 4, new Tuple<string, string>("Tower", "\u2656") },
            { 5, new Tuple<string, string>("Queen", "\u2655") },
            { 6, new Tuple<string, string>("King", "\u2654") },
            { -1, new Tuple<string, string>("Pawn", "♟") },
            { -2, new Tuple<string, string>("Knight", "\u265E") },
            { -3, new Tuple<string, string>("Bishop", "\u265D") },
            { -4, new Tuple<string, string>("Tower", "\u265C") },
            { -5, new Tuple<string, string>("Queen", "\u265B") },
            { -6, new Tuple<string, string>("King", "\u265A")}
        };



        // Name of the chess piece (King, Pawn etc...)
        public string? Name { get; set; }

        /* Code number used to identify the chess piece addition to Name
         * 0 = Empty space (not used here)
         * 1 / -1 = White Pawn / Black Pawn
         * 2 / -2 = White Knight / Black Knight
         * 3 / -3 = White Bishop Black Bishop
         * 4 / -4 = White Tower Black Tower
         * 5 / -5 = White Queen Black Queen
         * 6 / -6 = White King Black King
         * 
        */
        public int Code { get; set; }

        // White or Black
        public Color Color { get; set; }

        public string? Icon { get; set; }


        /// <summary>
        /// Constructor. Populate Name and Color with code
        /// </summary>
        /// <param name="code">Number code of the chess piece. Positive for white, negative for black</param>
        public AChessPiece(int code)
        {
            Code = code;
            Name = ChessPieceInformation[code].Item1;
            Color = code < 0 ? Color.Black : Color.White;
            Icon = ChessPieceInformation[code].Item2;
        }

        /// <summary>
        /// Alternative constructor. Populates Name and code according to color and type of object.
        /// </summary>
        /// <param name="color"></param>
       public AChessPiece(Color color)
        {
            Color = color;
        }


        public abstract bool IsValidMove(Position currentPosition, Position newPosition, Dictionary<Position, AChessPiece?> chessPieceBoard);

    }
}
