using console_chess.Board;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_chess.ChessPieces
{
    public class Pawn : AChessPiece
    {
        //TODO: Refactor
        public Pawn(int code) : base(code)
        {
        }

        /// <summary>
        /// Check if the move for Pawn is a valid one.
        /// Rules:
        /// 1. Pawn can move two forward, if not moved yet
        /// 2. Pawn can move sideways if there is a enemy chess piece
        /// 3. Pawn can move normally one forward if there is no chess piece on the way
        /// </summary>
        /// <param name="currentPosition">Current position of the pawn to be validated</param>
        /// <param name="newPosition">New position that is validated for the pawn</param>
        /// <param name="chessPieceOnNewPosition">Nullable chess piece residing on the new position</param>
        /// <returns>bool true when move is valid, false otherwise</returns>
        public override bool IsValidMove(Position currentPosition, Position newPosition, Dictionary<Position, AChessPiece?> chessPieceBoard)
        {
            int positionDifference = newPosition - currentPosition;
            AChessPiece? chessPieceOnNewPosition = chessPieceBoard[newPosition];

            // White pawn check section
            if (base.Color == Color.White)
            {
                // Pawn has not moved yet
                if (currentPosition.ToString().Contains("2"))
                {
                    // Pawn is on the left most position
                    if (currentPosition.ToString().Contains("A2")) return ValidateSidePawnMove(chessPieceBoard, currentPosition, newPosition, -7, true);

                    // Pawn is on the right most position
                    else if (currentPosition.ToString().Contains("H2")) return ValidateSidePawnMove(chessPieceBoard, currentPosition, newPosition, -9, true);
                    
                    // Pawn is not on the right/left most position
                    return ValidateNormalMove(chessPieceBoard, newPosition, currentPosition, true);
                }
                // Pawn has moved at least once
                else
                {
                    // Pawn is on the left most position
                    if (currentPosition.ToString().Contains("A")) return ValidateSidePawnMove(chessPieceBoard, currentPosition, newPosition, - 7, false);
                    
                    // Pawn is on the right most position
                    else if (currentPosition.ToString().Contains("H")) return ValidateSidePawnMove(chessPieceBoard, currentPosition, newPosition, -9, false);
                    
                    // Pawn is not on the right/left most position
                    return ValidateNormalMove(chessPieceBoard, newPosition, currentPosition, false);
                }


            }
            // Black pawn check section
            else
            {

                // Pawn has not moved yet
                if (currentPosition.ToString().Contains("7"))
                {
                    // Pawn is on the left most position
                    if (currentPosition.ToString().Contains("A7")) return ValidateSidePawnMove(chessPieceBoard, currentPosition, newPosition, 9, true);
                    
                    // Pawn is on the right most position
                    else if (currentPosition.ToString().Contains("H7")) return ValidateSidePawnMove(chessPieceBoard, currentPosition, newPosition, 7, true);

                    // Pawn is not on the right/left most position
                    return ValidateNormalMove(chessPieceBoard, newPosition, currentPosition, true);
                }
                else
                {
                    // Pawn is on the left most position
                    if (currentPosition.ToString().Contains("A")) return ValidateSidePawnMove(chessPieceBoard, currentPosition, newPosition, 9, false);
                    
                    // Pawn is on the right most position
                    else if (currentPosition.ToString().Contains("H")) return ValidateSidePawnMove(chessPieceBoard,currentPosition, newPosition, 7, false);

                    // Pawn is not on the right/left most position
                    return ValidateNormalMove(chessPieceBoard, newPosition, currentPosition, false);
                }
            }
               
        }

        /// <summary>
        /// Validates pawn on the right or left most position.
        /// White pawn eat to right: -7 validPositionDifferenceToEat
        /// White pawn eat to left: -9 validPositionDifferenceToEat
        /// Black pawn eat to right: 9 validPositionDifferenceToEat
        /// Black pawn eat to left: 7 validPositionDifferenceToEat
        /// </summary>
        /// <param name="chessPieceOnNewPosition">Chess piece that might be on the new position</param>
        /// <param name="positionDifference">Difference between original position and the new position</param>
        /// <param name="validPositionDifferenceToEat">int number indicating whether its valid to eat sideways to right or left</param>
        /// <param name="pawnNotMovedYet">bool true when pawn has not moved yet, false otherwise</param>
        /// <returns>bool true when move is valid, false otherwise</returns>
        private bool ValidateSidePawnMove(Dictionary<Position, AChessPiece?> chessBoard, Position currentPosition, Position newPosition, int validPositionDifferenceToEat, bool pawnNotMovedYet)
        {
            int positionDifference = newPosition - currentPosition;
            int oneForward = base.Color.Equals(Color.Black) ? 8 : -8;
            int twoForward = base.Color.Equals(Color.Black) ? 16 : -16;

            if (pawnNotMovedYet)
            {
                return
                    (positionDifference == oneForward && chessBoard[newPosition] == null)
                    ||
                    (positionDifference == twoForward && chessBoard[newPosition] == null && chessBoard[currentPosition + oneForward] == null)
                    ||
                    (positionDifference == validPositionDifferenceToEat && (chessBoard[newPosition] != null && chessBoard[newPosition].Color != base.Color));
            }

            return
                    (positionDifference == oneForward && chessBoard[newPosition] == null)
                    ||
                    (positionDifference == validPositionDifferenceToEat && (chessBoard[newPosition] != null && chessBoard[newPosition].Color != base.Color))
                    ;

        }

        /// <summary>
        /// Validates pawn move that is not on the right or left most position.
        /// </summary>
        /// <param name="chessPieceOnNewPosition">Chess piece that might be on the new position</param>
        /// <param name="positionDifference">Difference between original position and the new position</param>
        /// <param name="pawnNotMovedYet">bool true when pawn has not moved yet, false otherwise</param>
        /// <returns>bool true when move is valid, false otherwise</returns>
        private bool ValidateNormalMove(Dictionary<Position, AChessPiece?> chessBoard, Position newPosition, Position currentPosition, bool pawnNotMovedYet)
        {
            int positionDifference = newPosition - currentPosition;
            int oneForward = base.Color.Equals(Color.Black) ? 8 : -8;
            int twoForward = base.Color.Equals(Color.Black) ? 16 : -16;
            int sideWayEatDifferenceOne = base.Color.Equals(Color.Black) ? 7 : -7;
            int sideWayEatDifferenceTwo = base.Color.Equals(Color.Black) ? 9 : -9;

            if (pawnNotMovedYet)
            {
                return 
                    (positionDifference == oneForward && chessBoard[newPosition] == null)
                    ||
                    (positionDifference == twoForward && chessBoard[newPosition] == null && chessBoard[currentPosition + oneForward] == null)
                    ||
                    (chessBoard[newPosition] != null && positionDifference == sideWayEatDifferenceOne && chessBoard[newPosition].Color != base.Color)
                    ||
                    (chessBoard[newPosition] != null && positionDifference == sideWayEatDifferenceTwo && chessBoard[newPosition].Color != base.Color);
            }

            return
                    (positionDifference == oneForward && chessBoard[newPosition] == null)
                    ||
                    (chessBoard[newPosition] != null && positionDifference == sideWayEatDifferenceOne && chessBoard[newPosition].Color != base.Color)
                    ||
                    (chessBoard[newPosition] != null && positionDifference == sideWayEatDifferenceTwo && chessBoard[newPosition].Color != base.Color);

        }

        public override void Move()
        {
            throw new NotImplementedException();
        }

        public override void Print()
        {
            throw new NotImplementedException();
        }
    }
}
