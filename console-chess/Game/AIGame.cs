using console_chess.Board;
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
    /// <summary>
    /// Class for Player vs. AI
    /// </summary>
    public class AIGame : AGame
    {
        /// <summary>
        /// Empty constructor.
        /// </summary>
        public AIGame() : base()
        {
            // Initialize chessboard
            ChessBoard.Instance();
        }

        /// <summary>
        /// Method that starts the game & it will go on until the game ends.
        /// </summary>
        public override void StartGame()
        {
            // Create players
            CreatePlayers();

            // Start game until it ends
            while(true)
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
                    if(IsCheckMate())
                    {
                        Console.WriteLine($"Checkmate, {base.CurrentTurnPlayer.Name} WINS!");
                        while(true)
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

        /// <summary>
        /// Player selects a chess piece, possible moves will be displayed and finally moves the chess piece
        /// </summary>
        public override void PlayerMakeMove()
        {
            /**** Get a valid chess piece to move ****/
            ChosenMove chosenMove = base.CurrentTurnPlayer.ChoosePieceToMove();
                
            /**** Display possible moves ****/
            ChessBoard.Instance().DisplayPossibleMoves(chosenMove);

            /**** Move piece on valid move ****/
            base.CurrentTurnPlayer.MoveChessPiece(chosenMove);
        }

        /// <summary>
        /// Creates a player for the user and an AI player
        /// </summary>
        private void CreatePlayers()
        {
            base.PlayerOne = CreateUserPlayer();
            base.PlayerTwo = CreateAIPlayer(base.PlayerOne.Color.Equals(Color.White) ? Color.Black : Color.White);
            base.CurrentTurnPlayer = base.PlayerOne.Color.Equals(Color.White) ? base.PlayerOne : base.PlayerTwo;
        }
        
        /// <summary>
        /// Creates the users player. Name and color are given by the user.
        /// </summary>
        /// <returns>APlayer object, concrete class is RealPlayer</returns>
        private APlayer CreateUserPlayer()
        {
            string? playerName = null;
            Color playerColor = Color.White;

            // Choose a name
            while (true)
            {
                Console.Write($"User Players Name: ");
                playerName = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(playerName))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Name can't be empty give another name.");
                }
            }

            // Choose color
            while(true)
            {
                Console.Write($"User Players Color(White/Black): ");
                string? colorInput = Console.ReadLine();
                if (colorInput != null && (colorInput.ToLower().Equals("white", StringComparison.OrdinalIgnoreCase) || colorInput.ToLower().Equals("black", StringComparison.OrdinalIgnoreCase)))
                {
                    playerColor = colorInput.ToLower().Equals("white", StringComparison.OrdinalIgnoreCase) ? Color.White : Color.Black;
                    break;
                }
                else
                {
                    Console.WriteLine("Please choose either White or Black.");
                }
            }

            return new RealPlayer(playerName, playerColor);
        }

        /// <summary>
        /// Creates the AI player
        /// </summary>
        /// <param name="color">Color of the AI player</param>
        /// <returns>APlayer object, concrete class is ArtificialPlayer</returns>
        private APlayer CreateAIPlayer(Color color)
        {
            return new ArtificalPlayer("AI", color);
        }
    }
}
