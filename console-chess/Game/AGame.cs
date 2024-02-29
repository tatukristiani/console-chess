﻿using console_chess.Board;
using console_chess.ChessPieces;
using console_chess.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_chess.Game
{
    public abstract class AGame
    {
        protected APlayer? playerOne;
        protected APlayer? playerTwo;
        protected ChessBoard chessBoard;
        protected APlayer currentTurnPlayer;
        protected List<string> moveHistory = new List<string>();

        public AGame(bool useIcons)
        {
            this.chessBoard = new ChessBoard(useIcons);
        }

        public abstract void StartGame();

        public void PrintGameHistory()
        {
            foreach(string move in moveHistory)
            {
                Console.WriteLine(move);
            }
        }

        public void ChangeTurn()
        {
            if(currentTurnPlayer.Name.Equals(playerOne.Name))
            {
                currentTurnPlayer = playerTwo;
            }
            else
            {
                currentTurnPlayer = playerOne;
            }
        }

        public void PrintLastMove()
        {
            if (moveHistory.Count > 0) Console.WriteLine(moveHistory.Last());
        }

        public void AddMoveToHistory(AChessPiece piece, APlayer player, Position originalPosition, Position newPosition)
        {
            moveHistory.Add($"{player.Name} Moved {piece.Name} From {originalPosition} to {newPosition}.");
        }
    }
}
