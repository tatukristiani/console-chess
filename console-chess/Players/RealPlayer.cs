using console_chess.Board;
using console_chess.ChessPieces;
using console_chess.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_chess.Players
{
    public class RealPlayer : APlayer
    {
        public RealPlayer(string name, Color color) : base(name, color) { }

        public override ChosenMove ChoosePieceToMove()
        {
            List<Move> possibleMoves = new List<Move>();
            Position chosenPosition;
            while (true)
            {
                Console.WriteLine("Choose piece to move: ");
                string? piecePos = Console.ReadLine();

                if (Enum.TryParse(piecePos, out chosenPosition) && chosenPosition != Position.Default)
                {
                    AChessPiece? piece = ChessBoard.Instance().GetChessPiece(chosenPosition);
                    if (piece != null && piece.Color.Equals(this.Color))
                    {
                        possibleMoves = piece.ListValidMoves(piece.ListPossibleMoves(chosenPosition));
                        if (possibleMoves.Count > 0) break;
                    }
                }
            }

            return new ChosenMove(chosenPosition, possibleMoves);
        }

        public override void MoveChessPiece(Position oldPosition)
        {
            List<Move> possibleMoves = ChessBoard.Instance().GetChessPiece(oldPosition).ListPossibleMoves(oldPosition);

            string? newPos = null;
            Position newPosition = Position.Default;
            while (true)
            {
                Console.WriteLine("Where to move: ");
                newPos = Console.ReadLine();

                if (Enum.TryParse(newPos, out newPosition) && newPosition != Position.Default && possibleMoves.Any(move => move.NewPosition.Equals(newPosition)))
                {
                    ChessBoard.Instance().MoveChessPiece(new Move(oldPosition, newPosition));
                    break;
                }
            }
        }
    }
}
