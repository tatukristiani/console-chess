using console_chess.Board;
using console_chess.ChessPieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_chess.Utility
{
    public static class PositionHelper
    {
        private static readonly Position[] LeftMostPositions = { Position.A8, Position.A7, Position.A6, Position.A5, Position.A4, Position.A3, Position.A2, Position.A1 };
        private static readonly Position[] RightMostPositions = { Position.H8, Position.H7, Position.H6, Position.H5, Position.H4, Position.H3, Position.H2, Position.H1 };
        private static readonly Position[] TopRow = { Position.A8, Position.B8, Position.C8, Position.D8, Position.E8, Position.F8, Position.G8, Position.H8 };
        private static readonly Position[] BottomRow = { Position.A1, Position.B1, Position.C1, Position.D1, Position.E1, Position.F1, Position.G1, Position.H1 };

        public static bool IsLeftMostPosition(Position position)
        {
            return LeftMostPositions.Contains(position);
        }

        public static bool IsRightMostPosition(Position position)
        {
           return RightMostPositions.Contains(position);
        }

        public static bool IsOnTopRow(Position position)
        {
            return TopRow.Contains(position);
        }

        public static bool IsOnBottomRow(Position position)
        {
            return BottomRow.Contains(position);
        }

        public static List<Move> GetVerticalPossibleMovesUp(Position originalPosition, Color currentPlayerColor)
        {
            List<Move> moves = new List<Move>();
            int nextPos = (int)originalPosition - 8;

            try
            {
                while (true)
                {
                    AChessPiece? piece = ChessBoard.Instance().GetChessPiece((Position)nextPos);
                    if (piece != null && piece.Color != currentPlayerColor)
                    {
                        moves.Add(new Move(originalPosition, (Position)nextPos));
                        break;

                    }
                    else if (piece == null)
                    {
                        moves.Add(new Move(originalPosition, (Position)nextPos));
                    }
                    else if (piece != null && piece.Color.Equals(currentPlayerColor))
                    {
                        break;
                    }

                    nextPos -= 8;
                }
            }
            catch (Exception e)
            {
                FileLogger.Log("GetVerticalPossibleMovesUp Error: " + e.Message);
            }

            return moves;
        }

        public static List<Move> GetVerticalPossibleMovesDown(Position originalPosition, Color currentPlayerColor)
        {
            List<Move> moves = new List<Move>();
            int nextPos = (int)originalPosition + 8;

            try
            {
                while (true)
                {
                    AChessPiece? piece = ChessBoard.Instance().GetChessPiece((Position)nextPos);
                    if (piece != null && piece.Color != currentPlayerColor)
                    {
                        moves.Add(new Move(originalPosition, (Position)nextPos));
                        break;

                    }
                    else if (piece == null)
                    {
                        moves.Add(new Move(originalPosition, (Position)nextPos));
                    }
                    else if (piece != null && piece.Color.Equals(currentPlayerColor))
                    {
                        break;
                    }

                    nextPos += 8;
                }
            }
            catch (Exception e)
            {
                FileLogger.Log("GetVerticalPossibleMovesDown Error: " + e.Message);
            }

            return moves;
        }

        public static List<Move> GetHorizontalPossibleMovesRight(Position originalPos, Color currentPlayerColor)
        {
            List<Move> moves = new List<Move>();
            int nextPos = (int)originalPos + 1;

            try
            {
                while (true)
                {
                    if (!AlphabetIndex.PositionNumbersMatch(originalPos, (Position)nextPos)) break;

                    AChessPiece? piece = ChessBoard.Instance().GetChessPiece((Position)nextPos);
                    if (piece != null && piece.Color != currentPlayerColor)
                    {
                        moves.Add(new Move(originalPos, (Position)nextPos));
                        break;

                    }
                    else if (piece == null)
                    {
                        moves.Add(new Move(originalPos, (Position)nextPos));
                    }
                    else if (piece != null && piece.Color.Equals(currentPlayerColor))
                    {
                        break;
                    }

                    nextPos += 1;
                }
            }
            catch (Exception e)
            {
                FileLogger.Log("GetHorizontalPossibleMovesRight Error: " + e.Message);
            }

            return moves;
        }

        public static List<Move> GetHorizontalPossibleMovesLeft(Position originalPos, Color currentPlayerColor)
        {
            List<Move> moves = new List<Move>();
            int nextPos = (int)originalPos - 1;

            try
            {
                while (true)
                {
                    if (!AlphabetIndex.PositionNumbersMatch(originalPos, (Position)nextPos)) break;

                    AChessPiece? piece = ChessBoard.Instance().GetChessPiece((Position)nextPos);
                    if (piece != null && piece.Color != currentPlayerColor)
                    {
                        moves.Add(new Move(originalPos, (Position)nextPos));
                        break;

                    }
                    else if (piece == null)
                    {
                        moves.Add(new Move(originalPos, (Position)nextPos));
                    }
                    else if (piece != null && piece.Color.Equals(currentPlayerColor))
                    {
                        break;
                    }

                    nextPos -= 1;
                }
            }
            catch (Exception e)
            {
                FileLogger.Log("GetHorizontalPossibleMovesLeft Error: " + e.Message);
            }

            return moves;
        }

        public static List<Move> GetPossibleNorthWestMoves(Position originalPosition, Color currentPlayerColor)
        {
            List<Move> moves = new List<Move>();
            int nextPos = (int)originalPosition - 9;
            Position previousPos = originalPosition;

            try
            {
                while (true)
                {

                    if (AlphabetIndex.GetAbsoluteIndexDiff(new Move(previousPos, (Position)nextPos)) != 1) break;

                    AChessPiece? piece = ChessBoard.Instance().GetChessPiece((Position)nextPos);

                    if (piece == null) moves.Add(new Move(originalPosition, (Position)nextPos));
                    else if (piece.Color.Equals(currentPlayerColor)) break;
                    else
                    {
                        moves.Add(new Move(originalPosition, (Position)nextPos));
                        break;
                    }
                    previousPos = (Position)nextPos;
                    nextPos -= 9;
                }
            }
            catch (Exception ex)
            {
                FileLogger.Log("GetPossibleNorthWestMoves:\nError: " + ex.Message);
            }

            return moves;
        }

        public static List<Move> GetPossibleNorthEastMoves(Position originalPosition, Color currentPlayerColor)
        {
            List<Move> moves = new List<Move>();
            int nextPos = (int)originalPosition - 7;
            Position previousPos = originalPosition;

            try
            {
                while (true)
                {
                    if (AlphabetIndex.GetAbsoluteIndexDiff(new Move(previousPos, (Position)nextPos)) != 1) break;

                    AChessPiece? piece = ChessBoard.Instance().GetChessPiece((Position)nextPos);

                    if (piece == null) moves.Add(new Move(originalPosition, (Position)nextPos));
                    else if (piece.Color.Equals(currentPlayerColor)) break;
                    else
                    {
                        moves.Add(new Move(originalPosition, (Position)nextPos));
                        break;
                    }
                    previousPos = (Position)nextPos;
                    nextPos -= 7;
                }
            }
            catch (Exception ex)
            {
                FileLogger.Log("GetPossibleNorthEastMoves:\nError: " + ex.Message);
            }

            return moves;
        }

        public static List<Move> GetPossibleSouthWestMoves(Position originalPosition, Color currentPlayerColor)
        {
            List<Move> moves = new List<Move>();
            int nextPos = (int)originalPosition + 7;
            Position previousPos = originalPosition;

            try
            {
                while (true)
                {
                    if (AlphabetIndex.GetAbsoluteIndexDiff(new Move(previousPos, (Position)nextPos)) != 1) break;

                    AChessPiece? piece = ChessBoard.Instance().GetChessPiece((Position)nextPos);

                    if (piece == null) moves.Add(new Move(originalPosition, (Position)nextPos));
                    else if (piece.Color.Equals(currentPlayerColor)) break;
                    else
                    {
                        moves.Add(new Move(originalPosition, (Position)nextPos));
                        break;
                    }
                    previousPos = (Position)nextPos;
                    nextPos += 7;
                }
            }
            catch (Exception ex)
            {
                FileLogger.Log("GetPossibleSourthWestMoves:\nError: " + ex.Message);
            }

            return moves;
        }

        public static List<Move> GetPossibleSouthEastMoves(Position originalPosition, Color currentPlayerColor)
        {
            List<Move> moves = new List<Move>();
            int nextPos = (int)originalPosition + 9;
            Position previousPos = originalPosition;

            try
            {
                while (true)
                {
                    if (AlphabetIndex.GetAbsoluteIndexDiff(new Move(previousPos, (Position)nextPos)) != 1) break;

                    AChessPiece? piece = ChessBoard.Instance().GetChessPiece((Position)nextPos);

                    if (piece == null) moves.Add(new Move(originalPosition, (Position)nextPos));
                    else if (piece.Color.Equals(currentPlayerColor)) break;
                    else
                    {
                        moves.Add(new Move(originalPosition, (Position)nextPos));
                        break;
                    }
                    previousPos = (Position)nextPos;
                    nextPos += 9;
                }
            }
            catch (Exception ex)
            {
                FileLogger.Log("GetPossibleSouthEastMoves:\nError: " + ex.Message);
            }

            return moves;
        }
    }
}
