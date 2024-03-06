using console_chess.Board;
using console_chess.Utility;

namespace console_chess.ChessPieces
{
    /// <summary>
    /// Class for Rook chess piece
    /// </summary>
    public class Tower : AChessPiece
    {
        public Tower(int code) : base(code)
        {
        }

        public Tower(Color color) : base(color)
        {
            int code = this.Color == Color.White ? 4 : -4;
            this.Code = code;
            this.Name = base.ChessPieceInformation[code].Item1;
            this.Icon = base.ChessPieceInformation[code].Item2;
        }

        /// <summary>
        /// Check if the move for Tower is a valid one.
        /// </summary>
        /// <param name="currentPosition">Current position of the tower to be validated</param>
        /// <param name="newPosition">New position that is validated for the pawn</param>
        /// <param name="chessPieceOnNewPosition">Nullable chess piece residing on the new position</param>
        /// <returns>bool true when move is valid, false otherwise</returns>
        public override bool IsValidMove(Position currentPosition, Position newPosition, Dictionary<Position, AChessPiece?> chessPieceBoard)
        {
            
            int positionDifference = newPosition - currentPosition;
            
            // Max 7 moves horizontally, Max 7 vertically, cant move if there is own piece in front

            // Check horizontal
            if(positionDifference <= 7 && positionDifference >= -7)
            {
                // Move to right sections
                if(positionDifference > 0 && AlphabetIndex.GetIndex(currentPosition) < AlphabetIndex.GetIndex(newPosition))
                {
                    return ValidateMove(currentPosition, newPosition, 1, chessPieceBoard);
                }
                // Move to left section
                else if(positionDifference < 0 && AlphabetIndex.GetIndex(currentPosition) > AlphabetIndex.GetIndex(newPosition))
                {
                    return ValidateMove(currentPosition, newPosition, -1, chessPieceBoard);
                }

                return false;
            }

            // Check vertical
            if (positionDifference % 8 == 0)
            {
                // Check if difference is positive or negative
                if (positionDifference > 0)
                {
                    return ValidateMove(currentPosition, newPosition, 8, chessPieceBoard);
                }
                else
                {
                    return ValidateMove(currentPosition, newPosition, -8, chessPieceBoard);
                }
            }
            return false;
        }

        /// <summary>
        /// Validates the rooks move.
        /// Addend number is used to determine the direction where the chess piece is trying to go.
        ///  8: Going down
        /// -8: Going up
        ///  1: Going right
        /// -1: Going left
        /// </summary>
        /// <param name="startingPosition">Starting position of the rook</param>
        /// <param name="newPosition">Position to check if it can be executed</param>
        /// <param name="addend">int number that determine the direction where the rooks is going. 8: Down, -8: Up, 1: Right and -1: Left</param>
        /// <param name="board">Current chess board status</param>
        /// <returns>bool true when move is valid, false otherwise</returns>
        private bool ValidateMove(Position startingPosition, Position newPosition, int addend, Dictionary<Position, AChessPiece?> board)
        {
            int currentCheckPosition = (int)startingPosition + addend;

            // Move to right or up section when addend number is negative
            if(addend < 0)
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
    }
}
