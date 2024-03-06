using console_chess.Board;
using console_chess.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_chess.ChessPieces
{
    public class Knight : AChessPiece
    {
        private List<int> possibleDifferences = new List<int>()
        {
            6, -6, 10, -10, 15, -15, 17, -17
        };

        /*
         * AlphaIndex difference can be 2 MAX
         * A1 & A8 | H1 & H8: 2 possible moves
         * A2 & A7 | H2 & H7: 3 possible moves
         * A6 - A3 | H6 - H3: 4 possible moves
         * B1
         * 
         */
        public Knight(int code) : base(code)
        {
        }

        public Knight(Color color) : base(color)
        {
            int code = this.Color == Color.White ? 2 : -2;
            this.Code = code;
            this.Name = base.ChessPieceInformation[code].Item1;
            this.Icon = base.ChessPieceInformation[code].Item2;
        }

        /// <summary>
        /// Validates the move for knight.
        /// Position differences and directions:
        /// UP + RIGHT: -15
        /// UP + LEFT: -17
        /// DOWN + RIGHT: 17
        /// DOWN + LEFT: 15
        /// RIGHT + DOWN: 10
        /// RIGHT + UP: -6
        /// LEFT + DOWN: 6
        /// LEFT + UP: -10
        /// </summary>
        /// <param name="currentPosition">Current position of the knight</param>
        /// <param name="newPosition">New position to validate</param>
        /// <param name="chessPieceBoard">Current status of the chess board</param>
        /// <returns>bool true when valid, false otherwise</returns>
        public override bool IsValidMove(Position currentPosition, Position newPosition, Dictionary<Position, AChessPiece?> chessPieceBoard)
        {
            int positionDifference = newPosition - currentPosition;
            AChessPiece? pieceOnNewPos = chessPieceBoard[newPosition];
            bool pieceOnPosIsNotOwn = pieceOnNewPos == null || (pieceOnNewPos != null && pieceOnNewPos.Color != base.Color);

            return possibleDifferences.Contains(positionDifference) && pieceOnPosIsNotOwn && Math.Abs(AlphabetIndex.GetIndex(newPosition) - AlphabetIndex.GetIndex(currentPosition)) <= 2;
        }
    }
}
