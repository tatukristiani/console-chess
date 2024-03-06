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
                        && ChessPieceCanBeMovedFrom(originalPosition)  
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
                        && ChessPieceCanBeMovedTo(originalPosition, newPosition)
                        )
                    {
                        moveToIsValid = true;
                    }
                }

                // Move the chess piece
                AChessPiece pieceToMove = base.chessBoard.GetChessPiece(originalPosition);
                base.currentTurnPlayer.Move(pieceToMove, originalPosition, newPosition);

                // Add move to history
                base.AddMoveToHistory(pieceToMove, base.currentTurnPlayer, originalPosition, newPosition);

                // TODO: Check for check
                if(IsCheck(base.currentTurnPlayer, base.chessBoard))
                {
                    // TODO: Check for checkmate
                    if(IsCheckMate(base.currentTurnPlayer, base.chessBoard))
                    {
                        // TODO: END GAME
                    }

                    // TODO: Add movement disable to chess pieces if their move won't remove the check
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

        // Check if the chess piece can be moved anywhere (used when selecting a chess piece to move)
        private bool ChessPieceCanBeMovedFrom(Position currentPosition)
        {
            // Gather all possible position where the chess piece can move
            List<Position> possiblePositionToMove = new List<Position>();
            foreach(var position in base.chessBoard.ChessPiecePositions)
            {
                // Check if the move for the chess piece is valid from current position to the position in question
                if (base.chessBoard.GetChessPiece(currentPosition).IsValidMove(currentPosition, position.Key, base.chessBoard.ChessPiecePositions))
                {
                    possiblePositionToMove.Add(position.Key); 
                }
            }

            return possiblePositionToMove.Any();
        }

        // Check if the chess piece can be moved to the new position from its current position (used when moving chess piece to a new position)
        private bool ChessPieceCanBeMovedTo(Position currentPosition, Position positionToMove)
        {
            // Check first if the move is valid for the chess piece
            return base.chessBoard.GetChessPiece(currentPosition).IsValidMove(currentPosition, positionToMove, base.chessBoard.ChessPiecePositions);
        }

        // Checks for check
        public override bool IsCheck(APlayer playerWhoMadeTheMove, ChessBoard chessBoard)
        {
            return false;
        }

        // Checks for checkmate
        public override bool IsCheckMate(APlayer playerWhoMadeTheMove, ChessBoard chessBoard)
        {
            return false;
        }
    }
}
