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
    /// <summary>
    /// Class for real player AKA human.
    /// </summary>
    public class RealPlayer : APlayer
    {
        public RealPlayer(string name, Color color) : base(name, color) { }

        /// <summary>
        /// Method for the player to choose a chess piece to move.
        /// </summary>
        /// <returns>ChosenMove object</returns>
        public override ChosenMove ChoosePieceToMove()
        {
            List<Move> possibleMoves = new List<Move>();
            Position chosenPosition;
            while (true)
            {
                Console.WriteLine("Choose piece to move: ");
                string? piecePos = Console.ReadLine();

                // If the position selected by the user is valid -> Continue
                if (Enum.TryParse(piecePos, out chosenPosition) && chosenPosition != Position.Default)
                {
                    AChessPiece? piece = ChessBoard.Instance().GetChessPiece(chosenPosition);

                    // Check that the piece on that position is current players chess piece
                    if (piece != null && piece.Color.Equals(this.Color))
                    {
                        // List valid moves & break the loop if at least one valid move was found
                        possibleMoves = piece.ListValidMoves(piece.ListPossibleMoves(chosenPosition));
                        if (possibleMoves.Count > 0) break;
                    }
                }
            }
            FileLogger.Log($"Valid moves ({this.Color}, {ChessBoard.Instance().GetChessPiece(chosenPosition)?.Name}):\n{String.Join("\n", possibleMoves.Select(move => $"{move.OldPosition} to {move.NewPosition}"))}");

            return new ChosenMove(chosenPosition, possibleMoves);
        }

        /// <summary>
        /// Method for the user to select the target position where to move the selected chess piece.
        /// </summary>
        /// <param name="move">ChosenMove object</param>
        public override void MoveChessPiece(ChosenMove move)
        {
            List<Move> possibleMoves = move.PossibleMoves;

            string? newPos = null;
            Position newPosition = Position.Default;
            while (true)
            {
                Console.WriteLine("Where to move: ");
                newPos = Console.ReadLine();

                // Check that the selected target position is a valid one
                if (Enum.TryParse(newPos, out newPosition) && newPosition != Position.Default && possibleMoves.Any(move => move.NewPosition.Equals(newPosition)))
                {
                    ChessBoard.Instance().MoveChessPiece(new Move(move.ChosenChessPiecePosition, newPosition));
                    FileLogger.Log($"{this.Color} moved {move.ChosenChessPiecePosition} to {newPosition}");
                    break;
                }
            }
        }
    }
}
