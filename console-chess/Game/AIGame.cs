using console_chess.Board;
using console_chess.ChessPieces;
using console_chess.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_chess.Game
{
    public class AIGame : AGame
    {
        public AIGame(bool useIcons) : base(useIcons)
        {
        }

        public override void StartGame()
        {
            // Create players
            CreatePlayers();

            // Start game until it ends
            while(true)
            {
                // Update chess board
                base.chessBoard.UpdateChessBoard(null);
               
                // Print last move
                base.PrintLastMove();

                Console.WriteLine($"{base.currentTurnPlayer.Name}'s turn!");

                // Get input from player which piece to move
                Position originalPosition = base.currentTurnPlayer.GetChessPiecePositionToMove();

                // Get input from player where to move the piece
                Position newPosition = base.currentTurnPlayer.GetNewPositionToMoveChessPiece(originalPosition);

                // Move the chess piece
                AChessPiece pieceToMove = base.chessBoard.GetChessPiece(originalPosition);
                base.currentTurnPlayer.Move(pieceToMove, originalPosition, newPosition);

                base.chessBoard.UpdateChessBoard(null);

                // Add move to history
                base.AddMoveToHistory(pieceToMove, base.currentTurnPlayer, originalPosition, newPosition);

                // Check for check
                if(IsCheck())
                {
                    Console.WriteLine($"{base.currentTurnPlayer.Name} checked {(base.currentTurnPlayer.Color == base.playerOne.Color ? base.playerTwo.Name : base.playerOne.Name)}");

                    if(IsCheckMate())
                    {
                        Console.WriteLine($"Checkmate, {base.currentTurnPlayer.Name} WINS!");
                        while(true)
                        {
                            Console.WriteLine("Press anything to leave the game...");
                            var endgame = Console.ReadLine();
                            Console.WriteLine("Ending game...");
                            Thread.Sleep(5000);
                            break;
                        }
                        break;
                    }
                    Thread.Sleep(5000);            
                }

                // Change players turn
                base.ChangeTurn();
            }
        }

        private void CreatePlayers()
        {
            base.playerOne = CreateUserPlayer();
            base.playerTwo = CreateAIPlayer();
            base.currentTurnPlayer = base.playerOne;
        }
        
        private APlayer CreateUserPlayer()
        {
            while (true)
            {
                Console.Write($"User Players Name: ");
                string? playerName = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(playerName))
                {
                    return new RealPlayer(playerName, base.chessBoard, Color.White);
                }
                else
                {
                    Console.WriteLine("Name can't be empty give another name.");
                }

            }
        }

        private APlayer CreateAIPlayer()
        {
            return new ArtificalPlayer("AI", base.chessBoard, Color.Black);
        }
    }
}
