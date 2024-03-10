﻿using console_chess.Board;
using console_chess.ChessPieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_chess.Players
{
    public class RealPlayer : APlayer
    {
        public RealPlayer(string name, ChessBoard board, Color color) : base(name, board, color) { }

        public override void ChoosePieceToMove(AChessPiece piece, Position originalPosition)
        {
            base.board.ChoosePieceToMove(originalPosition);
        }

        public override bool Move(AChessPiece piece, Position originalPosition, Position newPosition)
        {
            return board.MoveChessPieceOnBoard(piece, originalPosition, newPosition);
        }

        public override Position GetChessPiecePositionToMove()
        {
            bool moveFromIsValid = false;
            Position originalPosition = Position.Default;
            string? lockMove = null;

            // Ask which chess piece to move, option to cancel
            while (!moveFromIsValid || lockMove == null || !lockMove.Equals("Y", StringComparison.OrdinalIgnoreCase))
            {
                Console.Write("Move From: ");

                // Rules for moving from the position need to match
                // Position is valid, Position is not Default, selected chess piece is the current players piece, the piece can move somewhere
                if (Enum.TryParse(Console.ReadLine(), out originalPosition)
                    && !originalPosition.Equals(Position.Default)
                    && Color == base.board.GetChessPiece(originalPosition)?.Color
                    && base.board.ChessPieceCanMove(originalPosition)
                    )
                {
                    moveFromIsValid = true;
                }

                // Display the path of the chess piece & option to cancel move
                if (moveFromIsValid)
                {
                    ChoosePieceToMove(base.board.GetChessPiece(originalPosition), originalPosition);

                    Console.Write("Confirm Piece to Move (Y/N): ");
                    lockMove = Console.ReadLine();
                    if (lockMove == null || !lockMove.Equals("Y", StringComparison.OrdinalIgnoreCase)) base.board.UpdateChessBoard(null);
                }

            }

            return originalPosition;
        }

        public override Position GetNewPositionToMoveChessPiece(Position originalPosition)
        {
            bool moveToIsValid = false;
            Position newPosition = Position.Default;

            // Ask where to move the chess piece
            while (!moveToIsValid)
            {
                Console.Write("Move To: ");

                // Rules for moving to a new position need to match
                // Position is valid, Position is not Default, selected chess piece can move to the position
                if (Enum.TryParse(Console.ReadLine(), out newPosition)
                    && newPosition != Position.Default
                    && base.board.ChessPieceCanBeMovedTo(originalPosition, newPosition)
                    )
                {
                    moveToIsValid = true;
                }
            }

            return newPosition;
        }
    }
}
