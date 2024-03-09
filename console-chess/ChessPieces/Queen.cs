using console_chess.Board;
using console_chess.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace console_chess.ChessPieces
{
    public class Queen : AChessPiece
    {
        public Queen(int code) : base(code)
        {
        }
        public Queen(Color color) : base(color)
        {
            int code = this.Color == Color.White ? 5 : -5;
            this.Code = code;
            this.Name = base.ChessPieceInformation[code].Item1;
            this.Icon = base.ChessPieceInformation[code].Item2;
        }

        /// <summary>
        /// Validates the move to the new position.
        /// </summary>
        /// <param name="currentPosition">Current position of the queen</param>
        /// <param name="newPosition">New position to validate</param>
        /// <param name="chessPieceBoard">Current status of the chessboard</param>
        /// <returns>true when valid, false otherwise</returns>
        public override bool IsValidMove(Position currentPosition, Position newPosition, Dictionary<Position, AChessPiece?> chessPieceBoard)
        {
            bool moveIsValid;

            // Check if positions are on the same column
            if (AlphabetIndex.GetIndex(newPosition) == AlphabetIndex.GetIndex(currentPosition))
            {
                // Check is there a chess piece blocking the path
                moveIsValid = NoChessPieceOnSameColumnPath(currentPosition, newPosition, chessPieceBoard);
            }
            // Check if positions are on the same row
            else if (newPosition.ToString().ToCharArray()[1].Equals(currentPosition.ToString().ToCharArray()[1]))
            {
                // Check is there a chess piece blocking the path
                moveIsValid = NoChessPieceOnSameRowPath(currentPosition, newPosition, chessPieceBoard);
            }
            // New position is not on the same row or column = New position is diagonal
            else
            {
                // Create tmp bishop, for validating diagonal movement
                Bishop tmpBishop = new Bishop(base.Color.Equals(Color.White) ? 3 : -3);
                tmpBishop.SetChessBoard(base.ChessBoard);

                // Check that the index difference of the current position and new position matches the position difference
                if (!tmpBishop.PositionDiffMatchesIndexDiff(currentPosition, newPosition)) return false;

                moveIsValid = tmpBishop.ValidateDiagonalMovement(currentPosition, newPosition, chessPieceBoard);
            }

            return moveIsValid && !base.MoveExposesKing(currentPosition, newPosition, chessPieceBoard);
        }

        // Checks if there are chess pieces on the same column as the queen
        private bool NoChessPieceOnSameColumnPath(Position currentPosition, Position newPosition, Dictionary<Position, AChessPiece?> chessPieceBoard)
        {
            int positionDifference = newPosition - currentPosition;

            // Negative difference -> Going up & Positive difference -> Going down
            int diffPerMove = positionDifference < 0 ? -8 : 8;
            int nextPosition = (int)currentPosition + diffPerMove;

            if (positionDifference < 0)
            {
                // Check if there are any chess pieces on the way
                while (nextPosition >= (int)newPosition)
                {
                    AChessPiece? piece = chessPieceBoard[(Position)nextPosition];
                    if ((piece != null && nextPosition != (int)newPosition) || (piece != null && base.Color.Equals(piece.Color))) return false;
                    nextPosition += diffPerMove;
                }
            }
            else
            {
                // Check if there are any chess pieces on the way
                while (nextPosition <= (int)newPosition)
                {
                    AChessPiece? piece = chessPieceBoard[(Position)nextPosition];
                    if ((piece != null && nextPosition != (int)newPosition) || (piece != null && base.Color.Equals(piece.Color))) return false;
                    nextPosition += diffPerMove;
                }
            }

            return true;
        }


        // Checks if there are chess pieces on the same row as the queen
        private bool NoChessPieceOnSameRowPath(Position currentPosition, Position newPosition, Dictionary<Position, AChessPiece?> chessPieceBoard)
        {
            int positionDifference = newPosition - currentPosition;
            int countOfMovesToNewPosition = Math.Abs(positionDifference);

            // Negative difference -> Going left & Positive difference -> Going right
            int diffPerMove = positionDifference < 0 ? -1 : 1;
            int nextPosition = (int)currentPosition + diffPerMove;

            // Check if there are any chess pieces on the way
            for (int i = 0; i < countOfMovesToNewPosition; i++)
            {
                AChessPiece? piece = chessPieceBoard[(Position)nextPosition];
                if ((piece != null && nextPosition != (int)newPosition) || (piece != null && base.Color.Equals(piece.Color))) return false;
                nextPosition += diffPerMove;
            }

            return true;
        }
    }
}
