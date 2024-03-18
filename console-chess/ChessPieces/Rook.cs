using console_chess.Board;
using console_chess.Utility;

namespace console_chess.ChessPieces
{
    /// <summary>
    /// Class for Rook chess piece
    /// </summary>
    public class Rook : AChessPiece
    {
        public Rook(Color color) : base(color)
        {
            this.Name = "Rook";
            this.Icon = color.Equals(Color.White) ? "♖" : "♜";
        }

        public override List<Move> ListPossibleMoves(Position originalPos)
        {
            List<Move> possibleMoves = new List<Move>();

            possibleMoves.AddRange(PositionHelper.GetVerticalPossibleMovesUp(originalPos, this.Color));
            possibleMoves.AddRange(PositionHelper.GetVerticalPossibleMovesDown(originalPos, this.Color));
            possibleMoves.AddRange(PositionHelper.GetHorizontalPossibleMovesLeft(originalPos, this.Color));
            possibleMoves.AddRange(PositionHelper.GetHorizontalPossibleMovesRight(originalPos, this.Color));

            return possibleMoves;
        }
    }
}
