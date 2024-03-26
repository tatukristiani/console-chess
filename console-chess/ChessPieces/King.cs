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

            // Get castling move to right
            if (CanCastleRight(originalPos)) possibleMoves.Add(new Move(originalPos, originalPos + 2));

            // Get castling move to left
            if (CanCastleLeft(originalPos)) possibleMoves.Add(new Move(originalPos, originalPos - 2));
            
            FileLogger.Log($"{this.Color} King ListPossibleMoves done");

            return possibleMoves;
        }

        public override List<Move> ListValidMoves(List<Move> possibleMoves)
        {
            List<Move> validMoves = new List<Move>();
            foreach (Move move in possibleMoves)
            {
                try
                {
                    if(AlphabetIndex.GetAbsoluteIndexDiff(move) == 2)
                    {
                        validMoves.Add(move);
                    }
                    else
                    {
                        if (!ChessBoard.Instance().MoveExposesKing(move, this.Color))
                        {
                            validMoves.Add(move);
                        }
                    }    
                }
                catch (Exception ex)
                {
                    //no valid moves for you
                }
            }

            return validMoves;
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
                //no valid moves for you
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
                //no valid moves for you
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
                //no valid moves for you
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
                //no valid moves for you
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

        private bool CanCastleRight(Position originalPosition)
        {
            if (this.HasMoved) return false;

            AChessPiece? piece = ChessBoard.Instance().GetChessPiece(this.Color.Equals(Color.White) ? Position.H1 : Position.H8);

            if (piece != null && piece.GetType().Equals(typeof(Rook)) && piece.Color.Equals(this.Color))
            {
                // Check that there are no pieces between the king and the rook
                for (int i = 1; i <= 2; i++)
                {
                    AChessPiece? pieceOnPath = ChessBoard.Instance().GetChessPiece((Position)((int)originalPosition + i));
                    if (pieceOnPath != null) return false;
                }

                // Check that the king is not in check currently
                if (ChessBoard.Instance().IsCheck(this.Color.Equals(Color.White) ? Color.Black : Color.White)) return false;

                // Check that enemy pieces are not attacking a square that the king passes or finishes at
                for (int j = 1; j <= 2; j++)
                {
                    Position positionToCheck = originalPosition + j;
                    ChessBoard.Instance().MoveKingForValidation(new Move(originalPosition, positionToCheck));
                    if (ChessBoard.Instance().IsCheck(this.Color.Equals(Color.White) ? Color.Black : Color.White))
                    {
                        ChessBoard.Instance().MoveKingForValidation(new Move(positionToCheck, originalPosition));
                        return false;
                    }
                    ChessBoard.Instance().MoveKingForValidation(new Move(positionToCheck, originalPosition));
                }

                // Check that after the castling the king is not in check
                if (ChessBoard.Instance().CastlingExposesKing(new Move(originalPosition, originalPosition + 2), this.Color)) return false;

                return true;
            }

            return false;
        }

        private bool CanCastleLeft(Position originalPosition)
        {
            if(this.HasMoved) return false;

            AChessPiece? piece = ChessBoard.Instance().GetChessPiece(this.Color.Equals(Color.White) ? Position.A1 : Position.A8);

            if(piece != null && piece.GetType().Equals(typeof(Rook)) && piece.Color.Equals(this.Color))
            {
                // Check that there are no pieces between the king and the rook
                for(int i = 1; i <= 3; i++)
                {
                    AChessPiece? pieceOnPath = ChessBoard.Instance().GetChessPiece(originalPosition - i);
                    if (pieceOnPath != null) return false;
                }

                // Check that the king is not in check currently
                if (ChessBoard.Instance().IsCheck(this.Color.Equals(Color.White) ? Color.Black : Color.White)) return false;

                // Check that enemy pieces are not attacking a square that the king passes or finishes at
                for(int j = 1; j <= 2; j++)
                {
                    Position positionToCheck = originalPosition - j;
                    ChessBoard.Instance().MoveKingForValidation(new Move(originalPosition, positionToCheck));
                    if (ChessBoard.Instance().IsCheck(this.Color.Equals(Color.White) ? Color.Black : Color.White))
                    {
                        ChessBoard.Instance().MoveKingForValidation(new Move(positionToCheck, originalPosition));
                        return false;
                    }
                    ChessBoard.Instance().MoveKingForValidation(new Move(positionToCheck, originalPosition));
                }

                // Check that after the castling the king is not in check
                if (ChessBoard.Instance().CastlingExposesKing(new Move(originalPosition, originalPosition - 2), this.Color)) return false;

                return true;
            }

            return false;
        }
    }
}
