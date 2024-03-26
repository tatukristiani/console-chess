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
    /// Abstract class for Chess game
    /// </summary>
    public abstract class AGame
    {
        protected APlayer? PlayerOne = null;
        protected APlayer? PlayerTwo = null;
        protected APlayer? CurrentTurnPlayer = null;
        private List<string> MoveHistory = new List<string>();

        /// <summary>
        /// Empty constructor. Players will be created later on for flexibility.
        /// </summary>
        public AGame()
        {
        }

        /// <summary>
        /// Abstract method to start the game.
        /// </summary>
        public abstract void StartGame();


        /// <summary>
        /// Change the CurrentTurnPlayer
        /// </summary>
        public void ChangeTurn()
        {
            try
            {
                if (CurrentTurnPlayer.Name.Equals(PlayerOne.Name)) CurrentTurnPlayer = PlayerTwo;
                else CurrentTurnPlayer = PlayerOne;
            }
            catch(Exception ex)
            {
                // Gotta catch 'em all
            }
        }

        /// <summary>
        /// Abstract method for making a move
        /// </summary>
        public abstract void PlayerMakeMove();


        /// <summary>
        /// Prints the latest move
        /// </summary>
        public void PrintLastMove()
        {
            if (MoveHistory.Count > 0) Console.WriteLine(MoveHistory[^1]);
        }

        /// <summary>
        /// Adds move to history
        /// </summary>
        /// <param name="piece">Chess piece moved</param>
        /// <param name="player">Player who moved the chess piece</param>
        /// <param name="move">Move that was made</param>
        public void AddMoveToHistory(AChessPiece piece, APlayer player, Move move)
        {
            MoveHistory.Add($"{player.Name} Moved {piece.Name} From {move.OldPosition} to {move.NewPosition}.");
        }

        /// <summary>
        /// Checks for check.
        /// </summary>
        /// <returns>true when CurrentTurnPlayer checked the other player, false otherwise</returns>
        public bool IsCheck()
        {
            return ChessBoard.Instance().IsCheck(CurrentTurnPlayer.Color);
        }

        /// <summary>
        /// Checks for checmate.
        /// </summary>
        /// <returns>true when CurrentTurnPlayer checkmated the other player, false otherwise</returns>
        public bool IsCheckMate()
        {
            return ChessBoard.Instance().IsCheckMate(CurrentTurnPlayer.Color);
        }
    }
}
