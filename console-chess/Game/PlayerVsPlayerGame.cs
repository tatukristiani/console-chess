﻿using console_chess.Board;
using console_chess.ChessPieces;
using console_chess.Players;
using console_chess.Utility;
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
            // Create players
            CreatePlayers();

            // Start game until it ends
            while (true)
            {
                // Update chess board
                ChessBoard.Instance().PrintCurrentBoardStatus(null);

                // Print last move
                base.PrintLastMove();
                Console.WriteLine($"{base.CurrentTurnPlayer.Name}'s turn!");

                // Current player makes a move
                PlayerMakeMove();

                // Update board
                ChessBoard.Instance().PrintCurrentBoardStatus(null);

                // Check for check
                if (IsCheck())
                {
                    Console.WriteLine($"{base.CurrentTurnPlayer.Name} checked {(base.CurrentTurnPlayer.Color == base.PlayerOne.Color ? base.PlayerTwo.Name : base.PlayerOne.Name)}");

                    // Check for check mate
                    if (IsCheckMate())
                    {
                        Console.WriteLine($"Checkmate, {base.CurrentTurnPlayer.Name} WINS!");
                        while (true)
                        {
                            Console.WriteLine("Press anything to leave the game...");
                            Console.ReadLine();
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
            /**** Get a valid chess piece to move ****/
            ChosenMove chosenMove = base.CurrentTurnPlayer.ChoosePieceToMove();

            /**** Display possible moves ****/
            ChessBoard.Instance().DisplayPossibleMoves(chosenMove);

            /**** Move piece on valid move ****/
            base.CurrentTurnPlayer.MoveChessPiece(chosenMove);
        }
    }
}
