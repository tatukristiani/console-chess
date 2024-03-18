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
    public class ArtificalPlayer : APlayer
    {
        public ArtificalPlayer(string name, Color color) : base(name, color)
        {
        }

        public override ChosenMove ChoosePieceToMove()
        {
            Position chosenPosition;
            List<Move> possibleMoves = new List<Move>();
            while (true)
            {
                try
                {
                    Random rnd = new Random();
                    int num = rnd.Next(60);
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
                    FileLogger.Log("ChoosePieceToMove (AI):\nError: " + ex.Message);
                }
            }
            
            return new ChosenMove(chosenPosition, possibleMoves);
        }

        public override void MoveChessPiece(Position oldPosition)
        {
            Position newPosition = ChessBoard.Instance().GetChessPiece((Position)oldPosition).ListPossibleMoves(oldPosition).First().NewPosition;
            ChessBoard.Instance().MoveChessPiece(new Move(oldPosition, newPosition));
        }
    }
}
