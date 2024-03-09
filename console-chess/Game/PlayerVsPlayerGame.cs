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
        public PlayerVsPlayerGame(bool useIcons) : base(useIcons)
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
                bool moveFromIsValid = false;
                bool moveToIsValid = false;
                Position originalPosition = Position.Default;
                Position newPosition = Position.Default;
                string? lockMove = null;
                
                // Ask which chess piece to move, option to cancel
                while(!moveFromIsValid || lockMove == null || !lockMove.Equals("Y", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("Move From: ");
                    // Rules for moving from the position need to match
                    // Position is valid, Position is not Default, selected chess piece is the current players piece, the piece can move somewhere
                    if(Enum.TryParse(Console.ReadLine(), out originalPosition) 
                        && !originalPosition.Equals(Position.Default) 
                        && base.currentTurnPlayer.Color == base.chessBoard.GetChessPiece(originalPosition)?.Color
                        && base.chessBoard.ChessPieceCanMove(originalPosition)  
                        )
                    {
                        moveFromIsValid = true;
                    }

                    // Display the path of the chess piece & option to cancel move
                    if (moveFromIsValid)
                    {
                        base.currentTurnPlayer.ChoosePieceToMove(base.chessBoard.GetChessPiece(originalPosition), originalPosition);

                        Console.Write("Confirm Piece to Move (Y/N): ");
                        lockMove = Console.ReadLine();
                        if (lockMove == null || !lockMove.Equals("Y", StringComparison.OrdinalIgnoreCase)) base.chessBoard.UpdateChessBoard(null);
                    }

                }

                // Ask where to move the chess piece
                while(!moveToIsValid)
                {
                    Console.Write("Move To: ");

                    // Rules for moving to a new position need to match
                    // Position is valid, Position is not Default, selected chess piece can move to the position
                    if(Enum.TryParse(Console.ReadLine(), out newPosition) 
                        && newPosition != Position.Default
                        && base.chessBoard.ChessPieceCanBeMovedTo(originalPosition, newPosition)
                        )
                    {
                        moveToIsValid = true;
                    }
                }

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
            base.playerOne = CreatePlayer(1);
            base.playerTwo = CreatePlayer(2);
            base.currentTurnPlayer = base.playerOne;
        }

        private APlayer CreatePlayer(int playerNumber)
        {
            while(true)
            {
                Console.Write($"Player {playerNumber} Name: ");
                string? playerName = Console.ReadLine();
                if(!String.IsNullOrWhiteSpace(playerName))
                {
                    return new RealPlayer(playerName, base.chessBoard, playerNumber == 1 ? Color.White : Color.Black);
                }
                else
                {
                    Console.WriteLine("Name can't be empty give another name.");
                }

            }
        }
      
    }
}
