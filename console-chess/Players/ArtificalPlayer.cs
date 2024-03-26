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
    /// Class for AI player
    /// </summary>
    public class ArtificalPlayer : APlayer
    {
        /// <summary>
        /// Inherent constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="color"></param>
        public ArtificalPlayer(string name, Color color) : base(name, color)
        {
        }

        /// <summary>
        /// TODO: Make more of an AI, currently just random move.
        /// </summary>
        /// <returns>ChosenMove object</returns>
        public override ChosenMove ChoosePieceToMove()
        {
            Position chosenPosition;
            List<Move> possibleMoves = new List<Move>();
            while (true)
            {
                try
                {
                    Random rnd = new Random();
                    int num = rnd.Next(63);
                    AChessPiece? piece = ChessBoard.Instance().GetChessPiece((Position)num);
                    if (piece != null && piece.Color.Equals(this.Color))
                    {
                        List<Move> moves = piece.ListValidMoves(piece.ListPossibleMoves((Position)num));

                        if(moves.Count > 0)
                        {
                            chosenPosition = (Position)num;
                            possibleMoves = moves;
                            break;
                        }
                    } 
                }
                catch(Exception ex)
                {
                    // zzzz
                }
            }
            
            FileLogger.Log($"Valid moves ({this.Color}, {ChessBoard.Instance().GetChessPiece(chosenPosition)?.Name}):\n{String.Join("\n",possibleMoves.Select(move => $"{move.OldPosition} to {move.NewPosition}"))}");
            return new ChosenMove(chosenPosition, possibleMoves);
        }

        /// <summary>
        /// Moves the chess piece chosen on the chess board.
        /// </summary>
        /// <param name="move">ChosenMove object</param>
        public override void MoveChessPiece(ChosenMove move)
        {
            Position newPosition = move.PossibleMoves[0].NewPosition;
            ChessBoard.Instance().MoveChessPiece(new Move(move.ChosenChessPiecePosition, newPosition));
            FileLogger.Log($"{this.Color} moved {move.ChosenChessPiecePosition} to {newPosition}");
        }
    }
}
