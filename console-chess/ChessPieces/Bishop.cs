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
        public Bishop(Color color) : base(color)
        {
            this.Name = "Bishop";
            this.Icon = color.Equals(Color.White) ? "♗" : "♝";
        }

        public override List<Move> ListPossibleMoves(Position originalPos)
        {
            List<Move> possibleMoves = new List<Move>();

            // Get possible north west moves
            possibleMoves.AddRange(PositionHelper.GetPossibleNorthWestMoves(originalPos, this.Color));

            // Get possible north east moves
            possibleMoves.AddRange(PositionHelper.GetPossibleNorthEastMoves(originalPos, this.Color));

            // Get possible south west moves
            possibleMoves.AddRange(PositionHelper.GetPossibleSouthWestMoves(originalPos, this.Color));

            // Get possible south east moves
            possibleMoves.AddRange(PositionHelper.GetPossibleSouthEastMoves(originalPos, this.Color));

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
