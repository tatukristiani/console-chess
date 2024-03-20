using console_chess.Board;
using console_chess.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_chess.ChessPieces
{
    public class Knight : AChessPiece
    {
        private List<int> possibleDifferences = new List<int>()
        {
            6, -6, 10, -10, 15, -15, 17, -17
        };


        public Knight(Color color) : base(color)
        {
            this.Name = "Knight";
            this.Icon = color.Equals(Color.White) ? "♘" : "♞";
        }

        public override List<Move> ListPossibleMoves(Position originalPos)
        {
            List<Move> possibleMoves = new List<Move>();

            foreach(var positionDifference in possibleDifferences)
            {
                try
                {
                    Position newPosition = originalPos + positionDifference;
                    AChessPiece? piece = ChessBoard.Instance().GetChessPiece(newPosition);
                    bool pieceOnNewPosNotOwn = piece == null || (piece.Color != this.Color);

                    if(pieceOnNewPosNotOwn && Math.Abs(AlphabetIndex.GetIndexDiff(new Move(originalPos, newPosition))) <= 2)
                    {
                        possibleMoves.Add(new Move(originalPos, newPosition));
                    }
                }
                catch (Exception ex)
                {
                    //FileLogger.Log("ListPossibleMoves (Knight):\nError: " + ex.Message);
                }
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
                    //FileLogger.Log("ListValidMoves:\nError: " + ex.Message);
                }
            }

            return validMoves;
        }
    }
}
