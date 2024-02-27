using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace console_chess.ChessPieces
{
    // Abstract class for chess pieces
    public abstract class AChessPiece
    {
        private Dictionary<int, string> ChessPieceCodes = new Dictionary<int, string>()
        {
            { 1, "Pawn" },
            { 2, "Knight" },
            { 3, "Bishop" },
            { 4, "Tower" },
            { 5, "Queen" },
            { 6, "King" },
            { -1, "Pawn" },
            { -2, "Knight" },
            { -3, "Bishop" },
            { -4, "Tower" },
            { -5, "Queen" },
            { -6, "King" }
        };
        // Name of the chess piece (King, Pawn etc...)
        public string Name { get; set; }

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


        // Constructor. Populate Name and Color with code
        public AChessPiece(int code)
        {
            Code = code;
            Name = ChessPieceCodes[code];
            Color = Code < 0 ? Color.Black : Color.White;
        }

        public abstract void Move();
        public abstract void Print();

    }
}
