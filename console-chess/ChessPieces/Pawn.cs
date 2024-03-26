using console_chess.Board;
using console_chess.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_chess.ChessPieces
{
    public class Pawn : AChessPiece
    {
        private readonly int WhiteAdvanceForward = -8;
        private readonly int WhiteEatRight = -7;
        private readonly int WhiteEatLeft = -9;

        private readonly int BlackAdvanceForward = 8;
        private readonly int BlackEatRight = 9;
        private readonly int BlackEatLeft = 7;

        public Pawn(Color color) : base(color)
        {
            this.Name = "Pawn";
            this.Icon = color.Equals(Color.White) ? "♙" : "♟";
        }

        public override List<Move> ListPossibleMoves(Position originalPos)
        {
            List<Move> possibleMoves = new List<Move>();

            if(!this.HasMoved && NoBlockersForDoubleMove(originalPos))
            {
                possibleMoves.Add(new Move(originalPos, originalPos + GetForwardAdvance() * 2));
            }

            if (NoBlockersForSingleMoveForward(originalPos))
            {
                possibleMoves.Add(new Move(originalPos, originalPos + GetForwardAdvance()));
            }

            if (CanEatRight(originalPos))
            {
                possibleMoves.Add(new Move(originalPos, originalPos + GetEatRighAdvance()));
            }

            if (CanEatLeft(originalPos))
            {
                possibleMoves.Add(new Move(originalPos, originalPos + GetEatLeftAdvance()));
            }

            return possibleMoves;
        }

        public override List<Move> ListValidMoves(List<Move> possibleMoves)
        {
            List<Move> validMoves = new List<Move>();
            foreach (Move move in possibleMoves)
            {
                try
                {
                    if (!ChessBoard.Instance().MoveExposesKing(move, this.Color))
                    {
                        validMoves.Add(move);
                    }
                }
                catch (Exception ex)
                {
                    //no valid moves for you
                }
            }

            return validMoves;
        }

        private bool NoBlockersForDoubleMove(Position originalPosition)
        {
            int advance = this.Color.Equals(Color.White) ? WhiteAdvanceForward : BlackAdvanceForward;
            Position fistMovePos = (Position) (int)originalPosition + advance;
            Position secondMovePos = (Position)(int)fistMovePos + advance;

            AChessPiece? firstPiece = ChessBoard.Instance().GetChessPiece(fistMovePos);
            AChessPiece? secondPiece = ChessBoard.Instance().GetChessPiece(secondMovePos);

            return firstPiece == null && secondPiece == null;
        }

        private bool NoBlockersForSingleMoveForward(Position originalPosition)
        {
            int advance = this.Color.Equals(Color.White) ? WhiteAdvanceForward : BlackAdvanceForward;

            try
            {
                Position newPosition = originalPosition + advance;
                AChessPiece? pieceOnNewPos = ChessBoard.Instance().GetChessPiece(newPosition);

                return pieceOnNewPos == null;
            }
            catch(Exception e)
            {
                //no valid moves for you
            }

            return false;
        }

        private bool CanEatRight(Position originalPosition)
        {
            if (PositionHelper.IsRightMostPosition(originalPosition)) return false;

            int advanceRight = this.Color.Equals(Color.White) ? WhiteEatRight : BlackEatRight;
            Position eatPosition = originalPosition + advanceRight;
            AChessPiece? pieceToEat = ChessBoard.Instance().GetChessPiece(eatPosition);

            return pieceToEat != null && pieceToEat.Color != this.Color;
        }

        private bool CanEatLeft(Position originalPosition)
        {
            if (PositionHelper.IsLeftMostPosition(originalPosition)) return false;

            int advanceLeft = this.Color.Equals(Color.White) ? WhiteEatLeft : BlackEatLeft;
            Position eatPosition = originalPosition + advanceLeft;
            AChessPiece? pieceToEat = ChessBoard.Instance().GetChessPiece(eatPosition);

            return pieceToEat != null && pieceToEat.Color != this.Color;
        }

        private int GetForwardAdvance()
        {
            if(this.Color.Equals(Color.White)) return WhiteAdvanceForward;
            else return BlackAdvanceForward;
        }

        private int GetEatRighAdvance()
        {
            if(this.Color.Equals(Color.White)) return WhiteEatRight;
            else return BlackEatRight;
        }

        private int GetEatLeftAdvance()
        {
            if (this.Color.Equals(Color.White)) return WhiteEatLeft;
            else return BlackEatLeft;
        }
    }
}
