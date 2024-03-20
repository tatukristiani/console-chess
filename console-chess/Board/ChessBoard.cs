using console_chess.ChessPieces;
using console_chess.Players;
using console_chess.Utility;
using Serilog;
using Serilog.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_chess.Board
{
    public class ChessBoard
    {
        private static ChessBoard? instance;
        private Dictionary<Position, AChessPiece?> Board;
        
        private ChessBoard()
        {
            this.Board = Populate();
        }

        public static ChessBoard Instance()
        {
            if(instance == null)
            {
                instance = new ChessBoard();
            }

            return instance;
        }

        private Dictionary<Position, AChessPiece?> Populate()
        {
            return new Dictionary<Position, AChessPiece?>()
            {
                {Position.A8, new Rook(Color.Black) },  {Position.B8, new Knight(Color.Black)},  {Position.C8, new Bishop(Color.Black)},  {Position.D8, new Queen(Color.Black)},   {Position.E8, new King(Color.Black)},    {Position.F8, new Bishop(Color.Black)},  {Position.G8, new Knight(Color.Black)},  {Position.H8, new Rook(Color.Black)},
                {Position.A7, new Pawn(Color.Black) },   {Position.B7, new Pawn(Color.Black)},    {Position.C7, new Pawn(Color.Black)},    {Position.D7, new Pawn(Color.Black)},    {Position.E7, new Pawn(Color.Black)},    {Position.F7, new Pawn(Color.Black)},    {Position.G7, new Pawn(Color.Black)},    {Position.H7, new Pawn(Color.Black)},
                {Position.A6, null },           {Position.B6, null},            {Position.C6, null},            {Position.D6, null},            {Position.E6, null},            {Position.F6, null},            {Position.G6, null},            {Position.H6, null},
                {Position.A5, null },           {Position.B5, null},            {Position.C5, null},            {Position.D5, null},            {Position.E5, null},            {Position.F5, null},            {Position.G5, null},            {Position.H5, null},
                {Position.A4, null },           {Position.B4, null},            {Position.C4, null},            {Position.D4, null},            {Position.E4, null},            {Position.F4, null},            {Position.G4, null},            {Position.H4, null},
                {Position.A3, null },           {Position.B3, null},            {Position.C3, null},            {Position.D3, null},            {Position.E3, null},            {Position.F3, null},            {Position.G3, null},            {Position.H3, null},
                {Position.A2, new Pawn(Color.White)},    {Position.B2, new Pawn(Color.White)},     {Position.C2, new Pawn(Color.White)},     {Position.D2, new Pawn(Color.White)},     {Position.E2, new Pawn(Color.White)},     {Position.F2, new Pawn(Color.White)},     {Position.G2, new Pawn(Color.White)},     {Position.H2, new Pawn(Color.White)},
                {Position.A1, new Rook(Color.White) },   {Position.B1, new Knight(Color.White)},   {Position.C1, new Bishop(Color.White)},   {Position.D1, new Queen(Color.White)},    {Position.E1, new King(Color.White)},     {Position.F1, new Bishop(Color.White)},   {Position.G1, new Knight(Color.White)},   {Position.H1, new Rook(Color.White)}
            };
        }


        public void Clear()
        {
            this.Board = Populate();
        }

        /**************** Chess Board Logic ***************/

        public void MoveChessPiece(Move move)
        {
            // Check if King & castling move
            AChessPiece? pieceToMove = Board[move.OldPosition];
            if (pieceToMove.GetType().Equals(typeof(King)) && AlphabetIndex.GetAbsoluteIndexDiff(move) == 2)
            {
                Board[move.NewPosition] = Board[move.OldPosition];
                Board[move.OldPosition] = null;
                Position rookOldPos = AlphabetIndex.GetIndexDiff(move) < 0 ? move.OldPosition - 4 : move.OldPosition + 3;
                Position rookNewPos = AlphabetIndex.GetIndexDiff(move) < 0 ? move.NewPosition + 1 : move.NewPosition - 1;
                Board[rookNewPos] = Board[rookOldPos];
                Board[rookOldPos] = null;

                Board[move.NewPosition].HasMoved = true;
                Board[rookNewPos].HasMoved = true;
            }
            else
            {
                Board[move.NewPosition] = Board[move.OldPosition];
                Board[move.OldPosition] = null;
                Board[move.NewPosition].HasMoved = true;
            }
        }

        public void MoveKingForValidation(Move move)
        {
            Board[move.NewPosition] = Board[move.OldPosition];
            Board[move.OldPosition] = null;
        }

        public AChessPiece? GetChessPiece(Position position)
        {
            return Board[position];
        }

        public Dictionary<Position, AChessPiece?> GetChessBoard()
        {
            return Board;
        }

        public bool MoveExposesKing(Move move, Color chessPieceColor)
        {
            bool moveExposesKing = false;
            Dictionary<Position, AChessPiece?> currentBoard = Board;

            try
            {
                // Move the chess piece to the new position
                AChessPiece? pieceOnNewPos = Board[move.NewPosition];
                Board[move.NewPosition] = Board[move.OldPosition];
                Board[move.OldPosition] = null;

                // Check if the move would leave own king exposed
                moveExposesKing = IsCheck(chessPieceColor.Equals(Color.White) ? Color.Black : Color.White);

                // Move chess pieces back to their original positions
                Board[move.OldPosition] = Board[move.NewPosition];
                Board[move.NewPosition] = pieceOnNewPos;
            }
            catch (Exception ex)
            {
                //FileLogger.Log("MoveExposesKing:\nError: " + ex.Message);
                Board = currentBoard;
            }

            return moveExposesKing;
        }

        public bool CastlingExposesKing(Move kingMove, Color chessPieceColor)
        {
            bool moveExposesKing = false;
            Dictionary<Position, AChessPiece?> currentBoard = Board;
            
            try
            {
                // Move the King & Rook to the new positions
                Board[kingMove.NewPosition] = Board[kingMove.OldPosition];
                Board[kingMove.OldPosition] = null;
                Position rookOldPos = AlphabetIndex.GetIndexDiff(kingMove) < 0 ? (Position)((int)kingMove.OldPosition - 4) : (Position)((int)kingMove.OldPosition + 3);
                Position rookNewPos = AlphabetIndex.GetIndexDiff(kingMove) < 0 ? (Position)((int)kingMove.NewPosition + 1) : (Position)((int)kingMove.NewPosition - 1);
                Board[rookNewPos] = Board[rookOldPos];
                Board[rookOldPos] = null;

                // Check if the move would leave own king exposed
                moveExposesKing = IsCheck(chessPieceColor.Equals(Color.White) ? Color.Black : Color.White);

                // Move chess pieces back to their original positions
                Board[kingMove.OldPosition] = Board[kingMove.NewPosition];
                Board[kingMove.NewPosition] = null;
                Board[rookOldPos] = Board[rookNewPos];
                Board[rookNewPos] = null;
            }
            catch (Exception ex)
            {
                //FileLogger.Log("MoveExposesKing:\nError: " + ex.Message);
                Board = currentBoard;
            }
            
            return moveExposesKing;
        }


        public void DisplayPossibleMoves(ChosenMove chosenMove)
        {
            PrintCurrentBoardStatus(chosenMove);
        }

        public void PrintCurrentBoardStatus(ChosenMove? chosenMove)
        {
            int rowCount = 8;
            Console.Clear();
            Console.WriteLine("     A      B      C      D      E      F      G      H   ");
            Console.WriteLine("  +------+------+------+------+------+------+------+------+");

            foreach (var position in Board)
            {
                if (PositionHelper.IsLeftMostPosition(position.Key))
                {
                    Console.Write($"{rowCount} |");
                }

                if (chosenMove != null)
                {
                    if (position.Key.Equals(chosenMove.ChosenChessPiecePosition))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        // Check if the current position is one of the positions of the highlighted chess piece pattern
                        if (chosenMove.PossibleMoves.Any(move => move.NewPosition.Equals(position.Key)))
                        {
                            // Highlight the current position
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                    }

                }

                // Print the chess icon or empty position
                string paddingLeft = "  ";
                string paddingRight = "   ";

                Console.Write($"{paddingLeft}{(position.Value == null ? "-   " : position.Value.Icon + paddingRight)}");
                Console.ForegroundColor = ConsoleColor.White; // Reset color, so other elements don't get highlighted
                Console.Write("|");

                // If current position is the last of the row -> Add row number + other elements
                if (PositionHelper.IsRightMostPosition(position.Key))
                {
                    Console.Write($" {rowCount}");
                    Console.WriteLine();
                    Console.WriteLine("  +------+------+------+------+------+------+------+------+");
                    rowCount--;
                }
            }
            Console.WriteLine("     A      B      C      D      E      F      G      H   ");
        }


        public bool IsCheck(Color currentPlayerColor)
        {
            Position enemyKingPosition = GetKingPosition(currentPlayerColor.Equals(Color.White) ? Color.Black : Color.White);
            // Check if the enemys King is threathened by any of the other players pieces
            foreach (var pos in Board)
            {
                AChessPiece? piece = pos.Value;

                if (piece != null && piece.Color == currentPlayerColor)
                {
                    // Check if the chess piece could move to position of enemy King
                    if (piece.ListPossibleMoves(pos.Key).Any(move => move.NewPosition.Equals(enemyKingPosition)))
                    {
                        return true;
                    }
                }
            }
            
            return false;
        }

        public bool IsCheckMate(Color currentPlayerColor)
        {
            // Check if the other player could move any pieces
            foreach (var pos in Board)
            {
                try
                {
                    AChessPiece? piece = pos.Value;

                    if (piece != null && piece.Color != currentPlayerColor)
                    {
                        if (piece.ListValidMoves(piece.ListPossibleMoves(pos.Key)).Count > 0)
                        {
                            return false;
                        }
                    }
                }
                catch(Exception ex)
                {
                    // Some logging here?
                }
            }

            return true;
        }

        private Position GetKingPosition(Color color)
        {
            return Board.Where(pos => pos.Value != null && pos.Value.GetType().Equals(typeof(King)) && pos.Value.Color.Equals(color)).First().Key;
        }
    }
}
