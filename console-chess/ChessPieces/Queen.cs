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
        public Queen(Color color) : base(color)
        {
            this.Name = "Queen";
            this.Icon = color.Equals(Color.White) ? "♕" : "♛";
        }

        public override List<Move> ListPossibleMoves(Position originalPos)
        {
            List<Move> possibleMoves = new List<Move>();

            possibleMoves.AddRange(PositionHelper.GetHorizontalPossibleMovesLeft(originalPos, this.Color));
            possibleMoves.AddRange(PositionHelper.GetHorizontalPossibleMovesRight(originalPos, this.Color));
            possibleMoves.AddRange(PositionHelper.GetVerticalPossibleMovesUp(originalPos, this.Color));
            possibleMoves.AddRange(PositionHelper.GetVerticalPossibleMovesDown(originalPos, this.Color));
            possibleMoves.AddRange(PositionHelper.GetPossibleNorthEastMoves(originalPos, this.Color));
            possibleMoves.AddRange(PositionHelper.GetPossibleNorthWestMoves(originalPos, this.Color));
            possibleMoves.AddRange(PositionHelper.GetPossibleSouthEastMoves(originalPos, this.Color));
            possibleMoves.AddRange(PositionHelper.GetPossibleSouthWestMoves(originalPos, this.Color));

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
    }
}
