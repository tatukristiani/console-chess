using console_chess.Board;
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

        public Knight(int code) : base(code)
        {
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

            return possibleDifferences.Contains(positionDifference) && pieceOnPosIsNotOwn;
        }

        public override void Move()
        {
            throw new NotImplementedException();
        }

        public override void Print()
        {
            throw new NotImplementedException();
        }
    }
}
