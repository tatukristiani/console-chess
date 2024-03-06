using console_chess.Board;
using console_chess.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_chess.ChessPieces
{
    //TODO: Add castling functionality
    public class King : AChessPiece
    {
        private List<int> possibleDifferences = new List<int>()
        {
            1, -1, 7, -7, 8, -8, 9, -9
        };

        public King(int code) : base(code)
        {
        }

        public King(Color color) : base(color) 
        {
            int code = this.Color == Color.White ? 6 : -6;
            this.Code = code;
            this.Name = base.ChessPieceInformation[code].Item1;
            this.Icon = base.ChessPieceInformation[code].Item2;
        }

        /// <summary>
        /// Validates the move for king
        /// Possible position differences and directions
        /// UP: -8
        /// UP DIAGONALLY LEFT: -9
        /// UP DIAGONALLY RIGHT: -7
        /// LEFT: -1
        /// RIGHT: 1
        /// DOWN: 8
        /// DOWN DIAGONALLY LEFT: 7
        /// DOWN DIAGONALLY RIGHT: 9
        /// SPECIAL DOUBLE MOVE RIGHT: 2
        /// SPECIAL DOUBLE MOVE LEFT: -2
        /// </summary>
        /// <param name="currentPosition">Position of the king</param>
        /// <param name="newPosition">Possible new position to move the king</param>
        /// <param name="chessPieceBoard">Current status of the chess board</param>
        /// <returns>bool true when move is valid, false otherwise</returns>
        public override bool IsValidMove(Position currentPosition, Position newPosition, Dictionary<Position, AChessPiece?> chessPieceBoard)
        {
            int positionDifference = newPosition - currentPosition;
            AChessPiece? pieceOnNewPos = chessPieceBoard[newPosition];
            bool pieceOnPosIsNotOwn = pieceOnNewPos == null || (pieceOnNewPos != null && pieceOnNewPos.Color != base.Color);

            return possibleDifferences.Contains(positionDifference) && pieceOnPosIsNotOwn && ( Math.Abs(AlphabetIndex.GetIndex(currentPosition) - AlphabetIndex.GetIndex(newPosition)) <= 1);
            
        }
    }
}
