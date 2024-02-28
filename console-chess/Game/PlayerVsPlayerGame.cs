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
        public override void StartGame()
        {
            // Create players
            CreatePlayers();

            // Start game until it ends
            while(true)
            {
                // Update chess board
                base.chessBoard.PrintBoardWithCodes(null);

                // Print last move
                base.PrintLastMove();

                Console.WriteLine($"{base.currentTurnPlayer.Name}'s turn!");
                bool moveFromIsValid = false;
                bool moveToIsValid = false;
                Position originalPosition = Position.Default;
                Position newPosition = Position.Default;
                string? lockMove = null;
                
                // Ask which chess piece to move, option to cancel
                while(!moveFromIsValid || lockMove == null || !lockMove.Equals("Y", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("Move From: ");
                    moveFromIsValid = Enum.TryParse(Console.ReadLine(), out originalPosition) && !originalPosition.Equals(Position.Default);

                    if (moveFromIsValid)
                    {
                        base.currentTurnPlayer.ChoosePieceToMove(base.chessBoard.GetChessPiece(originalPosition), originalPosition);

                        Console.Write("Confirm Piece to Move (Y/N): ");
                        lockMove = Console.ReadLine();
                        if (lockMove == null || !lockMove.Equals("Y", StringComparison.OrdinalIgnoreCase)) base.chessBoard.PrintBoardWithCodes(null);
                    }

                }

                // Ask where to move the chess piece
                while(!moveToIsValid)
                {
                    Console.Write("Move To: ");
                    moveToIsValid = Enum.TryParse(Console.ReadLine(), out newPosition) && newPosition != Position.Default;
                }

                // Move the chess piece
                AChessPiece pieceToMove = base.chessBoard.GetChessPiece(originalPosition);
                base.currentTurnPlayer.Move(pieceToMove, originalPosition, newPosition);

                // Add move to history
                base.AddMoveToHistory(pieceToMove, base.currentTurnPlayer, originalPosition, newPosition);

                // Change players tun
                base.ChangeTurn();
            }
        }

        private void CreatePlayers()
        {
            base.playerOne = CreatePlayer("One");
            base.playerTwo = CreatePlayer("Two");
            base.currentTurnPlayer = base.playerOne;
        }

        private APlayer CreatePlayer(string playerNumber)
        {
            while(true)
            {
                Console.Write($"Player {playerNumber} Name: ");
                string? playerName = Console.ReadLine();
                if(!String.IsNullOrWhiteSpace(playerName))
                {
                    return new RealPlayer(playerName, base.chessBoard);
                }
                else
                {
                    Console.WriteLine("Name can't be empty give another name.");
                }

            }
        }
    }
}
