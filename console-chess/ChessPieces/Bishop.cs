using console_chess.Board;
using console_chess.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace console_chess.ChessPieces
{
    public class Bishop : AChessPiece
    {
        public Bishop(int code) : base(code)
        {
        }

        public Bishop(Color color) : base(color)
        {
            int code = this.Color == Color.White ? 3 : -3;
            this.Code = code;
            this.Name = base.ChessPieceInformation[code].Item1;
            this.Icon = base.ChessPieceInformation[code].Item2;
        }
            


        /// <summary>
        /// Validates the move of bishop
        /// Possible differences and directions
        /// DIAGONALLY DOWN LEFT: Increase by 7 per move
        /// DIAGONALLY DOWN RIGHT: Increase by 9 per move
        /// DIAGONALLY UP LEFT: Decrease by -9
        /// DIAGONALLY UP RIGHT: Descrease by -7
        /// </summary>
        /// <param name="currentPosition"></param>
        /// <param name="newPosition"></param>
        /// <param name="chessPieceBoard"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override bool IsValidMove(Position currentPosition, Position newPosition, Dictionary<Position, AChessPiece?> chessPieceBoard)
        {
            int positionDifference = newPosition - currentPosition;

            // Check if position is on the same row -> invalid move
            if (currentPosition.ToString().ToCharArray()[1] == newPosition.ToString().ToCharArray()[1]) return false;

            // Check if position is on the same column -> invalid move
            if(Math.Abs(AlphabetIndex.GetIndex(currentPosition) - AlphabetIndex.GetIndex(newPosition)) == 0) return false;

            // Check that the index difference of the current position and new position matches the position difference
            if(!PositionDiffMatchesIndexDiff(currentPosition, newPosition)) return false;


            return ValidateDiagonalMovement(currentPosition, newPosition, chessPieceBoard);
            
           
        }

        /// <summary>
        /// Validates the bishops move.
        /// Addend number is used to determine the direction where the chess piece is trying to go.
        ///  7: Going diagonally down left
        /// -7: Going diagonally up right
        ///  9: Going diagonally down right
        /// -9: Going diagonally up left
        /// </summary>
        /// <param name="startingPosition">Starting position of the bishop</param>
        /// <param name="newPosition">Position to check if it can be executed</param>
        /// <param name="addend">int number that determine the direction where the bishop is going</param>
        /// <param name="board">Current chess board status</param>
        /// <returns>bool true when move is valid, false otherwise</returns>
        private bool ValidateMove(Position startingPosition, Position newPosition, int addend, Dictionary<Position, AChessPiece?> board)
        {
            int currentCheckPosition = (int)startingPosition + addend;
            
            if (addend < 0)
            {
                // Loop while all areas have been checked or enemy is blocking path
                while (currentCheckPosition >= (int)newPosition)
                {
                    AChessPiece? pieceOnPosition = board[(Position)currentCheckPosition];
                    if (pieceOnPosition != null && pieceOnPosition.Color == base.Color) return false;

                    if (pieceOnPosition != null && pieceOnPosition.Color != base.Color && currentCheckPosition != (int)newPosition) return false;


                    currentCheckPosition += addend;
                }
                return true;
            }

            // Move to left or down when addend number is positive
            while (currentCheckPosition <= (int)newPosition)
            {
                AChessPiece? pieceOnPosition = board[(Position)currentCheckPosition];
                if (pieceOnPosition != null && pieceOnPosition.Color == base.Color) return false;

                if (pieceOnPosition != null && pieceOnPosition.Color != base.Color && currentCheckPosition != (int)newPosition) return false;
                currentCheckPosition += addend;
            }

            return true;
        }

        /// <summary>
        /// Validates if the position index difference matches the positional difference.
        /// Example: Position difference from D4 to E5 is -7 and the index difference is 1 = Valid move
        /// Example 2: Position difference from D4 to E6 is -15 and the index difference is 1 = Not valid
        /// </summary>
        /// <param name="originalPosition">Original position of the chess piece</param>
        /// <param name="newPosition">New position to be validated</param>
        /// <returns>true when new position is valid, false otherwise</returns>
        public bool PositionDiffMatchesIndexDiff(Position originalPosition, Position newPosition)
        {
            int positionDiff = newPosition - originalPosition;

            // Check which direction the bishop is going (positive: Right, negative: Left)
            int posIndexDiff = AlphabetIndex.GetIndex(newPosition) - AlphabetIndex.GetIndex(originalPosition);

            // Bishop is going down to left or rigth
            if (positionDiff > 0)
            {
                
                // Right down
                if (posIndexDiff > 0)
                {
                    if(posIndexDiff * 9 + originalPosition != newPosition) return false;
                }
                // Left down
                else
                {
                    if (posIndexDiff * -1 * 7 + originalPosition != newPosition) return false;
                } 
            }
            // Bishop is going up to left or right
            else
            {
                
                // Right up
                if (posIndexDiff > 0)
                {
                    if (originalPosition - posIndexDiff * 7 != newPosition) return false;
                }
                // Left up
                else
                {
                    if (originalPosition - posIndexDiff * -1 * 9 != newPosition) return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Validates whether the move is diagonally valid
        /// </summary>
        /// <param name="originalPosition">Original position of the chess piece</param>
        /// <param name="newPosition">Position which to validate</param>
        /// <param name="chessBoard">Current status of the chessboard</param>
        /// <returns>true when move is valid, false otherwise</returns>
        public bool ValidateDiagonalMovement(Position originalPosition, Position newPosition, Dictionary<Position, AChessPiece?> chessBoard)
        {
            int positionDifference = newPosition - originalPosition;

            // Moving either up or down diagonally from down left to up right
            if (positionDifference % 7 == 0)
            {
                // Positive difference -> Going diagonally down left
                if (positionDifference > 0)
                {
                    return ValidateMove(originalPosition, newPosition, 7, chessBoard);
                }

                return ValidateMove(originalPosition, newPosition, -7, chessBoard);
            }
            // Moving either up or down diagonally from down right to up left
            else if (positionDifference % 9 == 0)
            {
                // Positive difference -> Going diagonally down right
                if (positionDifference > 0)
                {
                    return ValidateMove(originalPosition, newPosition, 9, chessBoard);
                }

                return ValidateMove(originalPosition, newPosition, -9, chessBoard);
            }

            return false;
        }
    }
}
