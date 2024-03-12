using console_chess.Board;
using console_chess.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace console_chess.ChessPieces
{
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

            // First validate normal moves
            bool normalMoveIsValid = (possibleDifferences.Contains(positionDifference) && pieceOnPosIsNotOwn && ( Math.Abs(AlphabetIndex.GetIndex(currentPosition) - AlphabetIndex.GetIndex(newPosition)) <= 1)) && !MoveExposesKing(currentPosition, newPosition, chessPieceBoard);

            // After that check if castling is possibl
            bool castlingCanBeDone = ValidateCastling(currentPosition, newPosition, chessPieceBoard);

            return normalMoveIsValid || castlingCanBeDone;
        }

        /// <summary>
        /// Castling rules.
        /// 1. Neither the king nor the rook has previously moved.
        /// 2. There are no pieces between the king and the rook.
        /// 3. The king is not currently in check.
        /// 4. The king does not pass through or finish on a square that is attacked by an enemy piece.
        /// </summary>
        /// <param name="currentPosition">Current position of the king</param>
        /// <param name="newPosition">New position to validate</param>
        /// <param name="chessPieceBoard">Current status of the chess board</param>
        /// <returns>true when castling is valid, false otherwise</returns>
        private bool ValidateCastling(Position currentPosition, Position newPosition, Dictionary<Position, AChessPiece?> chessPieceBoard)
        {
            if (base.HasMoved) return false; // First part of the rule 1.

            // Get the move difference to the new position
            int moveDifference = AlphabetIndex.GetIndex(newPosition) - AlphabetIndex.GetIndex(currentPosition);

            // Validate that it is exacly 2 moves (left or right)
            if(moveDifference == 2 || moveDifference == -2)
            {
                bool newPosOnTheRight = moveDifference == 2;

                // Get the rook and its position
                var rookInformation = chessPieceBoard
                .Where(pos =>
                    pos.Value != null &&
                    pos.Value.HasMoved == false && // Second part of the rule 1.
                    pos.Value.Color == base.Color &&
                    pos.Value.GetType() == typeof(Tower) &&
                        (
                            AlphabetIndex.GetIndex(pos.Key) - AlphabetIndex.GetIndex(currentPosition) > 0 && newPosOnTheRight
                        )
                        ||
                        (
                            AlphabetIndex.GetIndex(pos.Key) - AlphabetIndex.GetIndex(currentPosition) < 0 && !newPosOnTheRight
                        )
                    )
                    .Select(pos => new
                    {
                        position = pos.Key,
                        piece = pos.Value
                    }).FirstOrDefault();

                if ( rookInformation != null )
                {
                    int direction = moveDifference == 2 ? 1 : -1;
                    int nextPos = (int)currentPosition + direction;
                    // Check rule 2.
                    while(true)
                    {
                        if (nextPos == (int)rookInformation.position) break;
                        AChessPiece? piece = chessPieceBoard[(Position)nextPos];
                        if (piece != null) return false;

                        nextPos += direction;
                    }

                    // Check rule 3.
                    if (base.ChessBoard.IsCheck(base.Color.Equals(Color.White) ? Color.Black : Color.White)) return false;

                    // Check rule 4.
                    int nextPosRuleFour = (int)currentPosition + direction;
                    for(int i = 0; i < 2; i++)
                    {
                        // Check all the enemy pieces if they could move to the positition
                        foreach(var pos in chessPieceBoard)
                        {
                            AChessPiece? piece = pos.Value;
                            if(piece != null && piece.Color != base.Color)
                            {
                                if (pos.Value.IsValidMove(pos.Key, (Position)nextPosRuleFour, chessPieceBoard)) return false;
                            }
                        }
                        nextPosRuleFour += direction;
                    }

                    return true;
                }
            }

            return false;
        }
    }
}
