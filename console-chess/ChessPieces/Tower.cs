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
            bool isValidMove = false;

            // Check if positions are on the same column
            if (AlphabetIndex.GetIndex(newPosition) == AlphabetIndex.GetIndex(currentPosition))
            {
                // Check is there a chess piece blocking the path
                isValidMove = NoChessPieceOnSameColumnPath(currentPosition, newPosition, chessPieceBoard);
            }
            // Check if positions are on the same row
            else if (newPosition.ToString().ToCharArray()[1].Equals(currentPosition.ToString().ToCharArray()[1]))
            {
                // Check is there a chess piece blocking the path
                isValidMove = NoChessPieceOnSameRowPath(currentPosition, newPosition, chessPieceBoard);
            }

            return isValidMove && !MoveExposesKing(currentPosition, newPosition, chessPieceBoard);
        }

       
        // Checks if there are chess pieces on the same column as the queen
        private bool NoChessPieceOnSameColumnPath(Position currentPosition, Position newPosition, Dictionary<Position, AChessPiece?> chessPieceBoard)
        {
            int positionDifference = newPosition - currentPosition;

            if (positionDifference == 0) return false;

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
            if(positionDifference == 0) return false;

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
