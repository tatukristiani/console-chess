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
    /// <summary>
    /// Abstract class for players
    /// </summary>
    public abstract class APlayer
    {
        public string Name { get; set; }
        public Color Color { get; set; }

        /// <summary>
        /// Constructor where the name and color of the player is set.
        /// </summary>
        /// <param name="name">Name for the player</param>
        /// <param name="color">Color for the player</param>
        public APlayer(string name, Color color)
        {
            Name = name;
            Color = color;
        }

        /// <summary>
        /// Abstract method that will move the chess piece
        /// </summary>
        /// <param name="move">ChoseMove that the player chose to execute</param>
        public abstract void MoveChessPiece(ChosenMove move);

        /// <summary>
        /// Abstarct method for the player to choose a piece to move. The piece will not be moved here yet.
        /// </summary>
        /// <returns></returns>
        public abstract ChosenMove ChoosePieceToMove();
    }
}
