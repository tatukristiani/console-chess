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
        public King(Color color) : base(color)
        {
            this.Name = "King";
            this.Icon = color.Equals(Color.White) ? "♔" : "♚";
        }

        public override List<Move> ListPossibleMoves(Position originalPos)
        {
            List<Move> possibleMoves = new List<Move>();

            // Check if up is valid
            if (CanMoveUp(originalPos)) possibleMoves.Add(new Move(originalPos, originalPos + 8));

            // Check if down is valid
            if (CanMoveDown(originalPos)) possibleMoves.Add(new Move(originalPos, originalPos - 8));

            // Check if left is valid
            if (CanMoveLeft(originalPos)) possibleMoves.Add(new Move(originalPos, originalPos - 1));

            // Check if right is valid
            if (CanMoveRight(originalPos)) possibleMoves.Add(new Move(originalPos, originalPos + 1));

            // Get possible diagonal moves  
            possibleMoves.AddRange(GetPossibleDiagonalMoves(originalPos));

            return possibleMoves;
        }

        private bool CanMoveUp(Position originalPosition)
        {
            try
            {
                Position newPos = originalPosition + 8;
                AChessPiece? piece = ChessBoard.Instance().GetChessPiece(newPos);

                if (piece == null || piece.Color != this.Color) return true;
            }
            catch(Exception ex)
            {
               // FileLogger.Log("CanMoveUp (King):\nError: " + ex.Message);
            }

            return false;
        }

        private bool CanMoveDown(Position originalPosition)
        {
            try
            {
                Position newPos = originalPosition - 8;
                AChessPiece? piece = ChessBoard.Instance().GetChessPiece(newPos);

                if (piece == null || piece.Color != this.Color) return true;
            }
            catch (Exception ex)
            {
                //FileLogger.Log("CanMoveDown (King):\nError: " + ex.Message);
            }

            return false;
        }

        private bool CanMoveLeft(Position originalPosition)
        {
            try
            {
                Position newPos = originalPosition - 1;

                if (!AlphabetIndex.PositionNumbersMatch(originalPosition, newPos)) return false;

                AChessPiece? piece = ChessBoard.Instance().GetChessPiece(newPos);

                if (piece == null || piece.Color != this.Color) return true;
            }
            catch (Exception ex)
            {
                //FileLogger.Log("CanMoveDown (King):\nError: " + ex.Message);
            }

            return false;
        }

        private bool CanMoveRight(Position originalPosition)
        {
            try
            {
                Position newPos = originalPosition + 1;

                if (!AlphabetIndex.PositionNumbersMatch(originalPosition, newPos)) return false;

                AChessPiece? piece = ChessBoard.Instance().GetChessPiece(newPos);

                if (piece == null || piece.Color != this.Color) return true;
            }
            catch (Exception ex)
            {
               // FileLogger.Log("CanMoveDown (King):\nError: " + ex.Message);
            }

            return false;
        }


        private List<Move> GetPossibleDiagonalMoves(Position originalPosition)
        {
            List<Move> moves = new List<Move>();

            // Here cant move down
            if(PositionHelper.IsOnBottomRow(originalPosition))
            {
                if(PositionHelper.IsLeftMostPosition(originalPosition))
                {
                    AChessPiece? piece = ChessBoard.Instance().GetChessPiece(originalPosition - 7);
                    if(piece == null || piece.Color != this.Color)
                    {
                        moves.Add(new Move(originalPosition, originalPosition - 7));
                    }
                }
                else if(PositionHelper.IsRightMostPosition(originalPosition))
                {
                    AChessPiece? piece = ChessBoard.Instance().GetChessPiece(originalPosition - 9);
                    if (piece == null || piece.Color != this.Color)
                    {
                        moves.Add(new Move(originalPosition, originalPosition - 9));
                    }
                }
                else
                {
                    AChessPiece? pieceOnRightSide = ChessBoard.Instance().GetChessPiece(originalPosition - 7);
                    AChessPiece? pieceOnLeftSide = ChessBoard.Instance().GetChessPiece(originalPosition - 9);

                    if (pieceOnRightSide == null || pieceOnRightSide.Color != this.Color) moves.Add(new Move(originalPosition, originalPosition - 7));
                    if (pieceOnLeftSide == null || pieceOnLeftSide.Color != this.Color) moves.Add(new Move(originalPosition, originalPosition - 9));
                }
            }
            // Here cant move up
            else if(PositionHelper.IsOnTopRow(originalPosition))
            {
                if (PositionHelper.IsLeftMostPosition(originalPosition))
                {
                    AChessPiece? piece = ChessBoard.Instance().GetChessPiece(originalPosition + 9);
                    if (piece == null || piece.Color != this.Color)
                    {
                        moves.Add(new Move(originalPosition, originalPosition + 9));
                    }
                }
                else if (PositionHelper.IsRightMostPosition(originalPosition))
                {
                    AChessPiece? piece = ChessBoard.Instance().GetChessPiece(originalPosition + 7);
                    if (piece == null || piece.Color != this.Color)
                    {
                        moves.Add(new Move(originalPosition, originalPosition + 7));
                    }
                }
                else
                {
                    AChessPiece? pieceOnRightSide = ChessBoard.Instance().GetChessPiece(originalPosition + 9);
                    AChessPiece? pieceOnLeftSide = ChessBoard.Instance().GetChessPiece(originalPosition + 7);

                    if (pieceOnRightSide == null || pieceOnRightSide.Color != this.Color) moves.Add(new Move(originalPosition, originalPosition + 9));
                    if (pieceOnLeftSide == null || pieceOnLeftSide.Color != this.Color) moves.Add(new Move(originalPosition, originalPosition + 7));
                }
            }
            // Here could move anywhere
            else
            {
                if (PositionHelper.IsLeftMostPosition(originalPosition))
                {
                    AChessPiece? pieceUpward = ChessBoard.Instance().GetChessPiece(originalPosition - 7);
                    AChessPiece? pieceDownward = ChessBoard.Instance().GetChessPiece(originalPosition + 9);

                    if (pieceUpward == null || pieceUpward.Color != this.Color) moves.Add(new Move(originalPosition, originalPosition - 7));
                    if (pieceDownward == null || pieceDownward.Color != this.Color) moves.Add(new Move(originalPosition, originalPosition + 9));
                }
                else if (PositionHelper.IsRightMostPosition(originalPosition))
                {
                    AChessPiece? pieceUpward = ChessBoard.Instance().GetChessPiece(originalPosition - 9);
                    AChessPiece? pieceDownward = ChessBoard.Instance().GetChessPiece(originalPosition + 7);

                    if (pieceUpward == null || pieceUpward.Color != this.Color) moves.Add(new Move(originalPosition, originalPosition - 9));
                    if (pieceDownward == null || pieceDownward.Color != this.Color) moves.Add(new Move(originalPosition, originalPosition + 7));
                }
                else
                {
                    AChessPiece? northWestPiece = ChessBoard.Instance().GetChessPiece(originalPosition - 9);
                    AChessPiece? southWestPiece = ChessBoard.Instance().GetChessPiece(originalPosition + 7);
                    AChessPiece? southEastPiece = ChessBoard.Instance().GetChessPiece(originalPosition + 9);
                    AChessPiece? northEastPiece = ChessBoard.Instance().GetChessPiece(originalPosition - 7);

                    if (northWestPiece == null || northWestPiece.Color != this.Color) moves.Add(new Move(originalPosition, originalPosition - 9));
                    if (southWestPiece == null || southWestPiece.Color != this.Color) moves.Add(new Move(originalPosition, originalPosition + 7));
                    if (southEastPiece == null || southEastPiece.Color != this.Color) moves.Add(new Move(originalPosition, originalPosition + 9));
                    if (northEastPiece == null || northEastPiece.Color != this.Color) moves.Add(new Move(originalPosition, originalPosition - 7));
                }
            }

            return moves;
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
            /*
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
            */
            return false;
        }
    }
}
