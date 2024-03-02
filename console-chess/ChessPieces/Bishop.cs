using console_chess.Board;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_chess.ChessPieces
{
    public class Bishop : AChessPiece
    {
        public Bishop(int code) : base(code)
        {
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
            
            // Moving either up or down diagonally from down left to up right
            if(positionDifference % 7 == 0)
            {
                // Positive difference -> Going diagonally down left
                if(positionDifference > 0)
                {
                    return ValidateMove(currentPosition, newPosition, 7, chessPieceBoard);  
                }

                return ValidateMove(currentPosition, newPosition, -7, chessPieceBoard);
            }
            // Moving either up or down diagonally from down right to up left
            else if(positionDifference % 9 == 0)
            {
                // Positive difference -> Going diagonally down right
                if(positionDifference > 0)
                {
                    return ValidateMove(currentPosition, newPosition, 9, chessPieceBoard);
                }

                return ValidateMove(currentPosition, newPosition, -9, chessPieceBoard);
            }

            return false;
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
