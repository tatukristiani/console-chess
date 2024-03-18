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
    public abstract class AGame
    {
        protected APlayer? PlayerOne;
        protected APlayer? PlayerTwo;
        protected APlayer? CurrentTurnPlayer;
        protected List<string> MoveHistory = new List<string>();

        public AGame()
        {
        }

        public abstract void StartGame();

        public void ChangeTurn()
        {
            if(CurrentTurnPlayer.Name.Equals(PlayerOne.Name)) CurrentTurnPlayer = PlayerTwo;
            else CurrentTurnPlayer = PlayerOne;
        }

        public abstract void PlayerMakeMove();

        public void PrintLastMove()
        {
            if (MoveHistory.Count > 0) Console.WriteLine(MoveHistory.Last());
        }

        public void AddMoveToHistory(AChessPiece piece, APlayer player, Move move)
        {
            MoveHistory.Add($"{player.Name} Moved {piece.Name} From {move.OldPosition} to {move.NewPosition}.");
        }

        public bool IsCheck()
        {
            return ChessBoard.Instance().IsCheck(CurrentTurnPlayer.Color);
        }

        public bool IsCheckMate()
        {
            return ChessBoard.Instance().IsCheckMate(CurrentTurnPlayer.Color);
        }
    }
}
