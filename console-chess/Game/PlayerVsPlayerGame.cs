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
    public class PlayerVsPlayerGame : AGame
    {
        public PlayerVsPlayerGame() : base()
        {
        }

        public override void StartGame()
        {
            /*
            // Create players
            CreatePlayers();

            // Start game until it ends
            while(true)
            {
                // Update chess board
                base.ChessBoard.UpdateChessBoard(null);
               
                // Print last move
                base.PrintLastMove();

                Console.WriteLine($"{base.CurrentTurnPlayer.Name}'s turn!");

                // Get input from player which piece to move
                Position originalPosition = base.CurrentTurnPlayer.GetChessPiecePositionToMove();

                // Get input from player where to move the piece
                Position newPosition = base.CurrentTurnPlayer.GetNewPositionToMoveChessPiece(originalPosition);

                // Move the chess piece
                AChessPiece pieceToMove = base.ChessBoard.GetChessPiece(originalPosition);
                base.CurrentTurnPlayer.Move(originalPosition, newPosition);

                base.ChessBoard.UpdateChessBoard(null);

                // Add move to history
                base.AddMoveToHistory(pieceToMove, base.CurrentTurnPlayer, originalPosition, newPosition);

                // Check for check
                if(IsCheck())
                {
                    Console.WriteLine($"{base.CurrentTurnPlayer.Name} checked {(base.CurrentTurnPlayer.Color == base.playerOne.Color ? base.PlayerTwo.Name : base.playerOne.Name)}");

                    if(IsCheckMate())
                    {
                        Console.WriteLine($"Checkmate, {base.CurrentTurnPlayer.Name} WINS!");
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
            */
        }

        private void CreatePlayers()
        {
            base.PlayerOne = CreatePlayer(Color.White);
            base.PlayerTwo = CreatePlayer(Color.Black);
            base.CurrentTurnPlayer = base.PlayerOne;
        }

        private APlayer CreatePlayer(Color color)
        {
            while(true)
            {
                Console.Write($"{color} Players Name: ");
                string? playerName = Console.ReadLine();
                if(!String.IsNullOrWhiteSpace(playerName))
                {
                    return new RealPlayer(playerName, color);
                }
                else
                {
                    Console.WriteLine("Name can't be empty give another name.");
                }

            }
        }

        public override void PlayerMakeMove()
        {
            throw new NotImplementedException();
        }
    }
}
