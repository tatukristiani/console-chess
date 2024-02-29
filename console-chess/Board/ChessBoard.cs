using console_chess.ChessPieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_chess.Board
{
    /// <summary>
    /// Class that hold logic for the chess board.
    /// </summary>
    public class ChessBoard
    {
        // Dictionary that holds the chessboard positions and chess pieces on them
        private Dictionary<Position, AChessPiece?> ChessPiecePositions;
        private bool UseIcons;

        /// <summary>
        /// Constructor populates chessboard with chess pieces
        /// </summary>
        public ChessBoard(bool useIcons)
        {
            this.ChessPiecePositions = Populate();
            this.UseIcons = useIcons;
        }

        /// <summary>
        /// Moves chess piece on the board
        /// </summary>
        /// <param name="piece">Chess piece to move</param>
        /// <param name="originalPosition">From where to move the chess piece</param>
        /// <param name="newPosition">Where to move the chess piece</param>
        /// <returns>boolean value false when the chess piece wasn't found from the original position, true when the piece was successfully moved</returns>
        public bool MoveChessPieceOnBoard(AChessPiece piece, Position originalPosition, Position newPosition)
        {
            // Find chess piece on the board to move
            AChessPiece? pieceToMove = ChessPiecePositions[originalPosition];

            // Check if the chess piece was found = valid input
            if(pieceToMove != null )
            {
                ChessPiecePositions[newPosition] = pieceToMove;
                ChessPiecePositions[originalPosition] = null;
                return true;
                
            }

            return false;

        }

        /// <summary>
        /// Chooses a chess piece to move.
        /// Used to highlight the chess pieces pattern on the board.
        /// Simply updates the board highlighting the chess piece on the given position
        /// </summary>
        /// <param name="originalPosition">Position of the chess piece to move</param>
        public void ChoosePieceToMove(Position originalPosition)
        {
            if (UseIcons) PrintBoardWithIcons(originalPosition);
            else PrintBoardWithCodes(originalPosition);
        }

        /// <summary>
        /// Return a chess piece on the position
        /// </summary>
        /// <param name="position">Position where to get the chess piece</param>
        /// <returns></returns>
        public AChessPiece? GetChessPiece(Position position)
        {
            return ChessPiecePositions[position];
        }


        /// <summary>
        /// Populates the chess board positions with Chess Pieces
        /// </summary>
        /// <returns>Dictionary<Position, AChessPiece?></returns>
        private static Dictionary<Position, AChessPiece?> Populate()
        {
            return new Dictionary<Position, AChessPiece?>()
            {
                {Position.A8, new Tower(-4) },  {Position.B8, new Knight(-2)},  {Position.C8, new Bishop(-3)},  {Position.D8, new Queen(-5)},   {Position.E8, new King(-6)},    {Position.F8, new Bishop(-3)},  {Position.G8, new Knight(-2)},  {Position.H8, new Tower(-4)},
                {Position.A7, new Pawn(-1) },   {Position.B7, new Pawn(-1)},    {Position.C7, new Pawn(-1)},    {Position.D7, new Pawn(-1)},    {Position.E7, new Pawn(-1)},    {Position.F7, new Pawn(-1)},    {Position.G7, new Pawn(-1)},    {Position.H7, new Pawn(-1)},
                {Position.A6, null },           {Position.B6, null},            {Position.C6, null},            {Position.D6, null},            {Position.E6, null},            {Position.F6, null},            {Position.G6, null},            {Position.H6, null},
                {Position.A5, null },           {Position.B5, null},            {Position.C5, null},            {Position.D5, null},            {Position.E5, null},            {Position.F5, null},            {Position.G5, null},            {Position.H5, null},
                {Position.A4, null },           {Position.B4, null},            {Position.C4, null},            {Position.D4, null},            {Position.E4, null},            {Position.F4, null},            {Position.G4, null},            {Position.H4, null},
                {Position.A3, null },           {Position.B3, null},            {Position.C3, null},            {Position.D3, null},            {Position.E3, null},            {Position.F3, null},            {Position.G3, null},            {Position.H3, null},
                {Position.A2, new Pawn(1) },    {Position.B2, new Pawn(1)},     {Position.C2, new Pawn(1)},     {Position.D2, new Pawn(1)},     {Position.E2, new Pawn(1)},     {Position.F2, new Pawn(1)},     {Position.G2, new Pawn(1)},     {Position.H2, new Pawn(1)},
                {Position.A1, new Tower(4) },   {Position.B1, new Knight(2)},   {Position.C1, new Bishop(3)},   {Position.D1, new Queen(5)},    {Position.E1, new King(6)},     {Position.F1, new Bishop(3)},   {Position.G1, new Knight(2)},   {Position.H1, new Tower(4)}
            };
        }

        /// <summary>
        /// Prints the current status of the chess board with chess piece code values.
        /// Optionally a Position enum parameter can be given to highlight the chess pieces pattern on the given Position.
        /// </summary>
        /// <param name="highlightedPosition">Optional Position enum parameter</param>
        private void PrintBoardWithCodes(Position? highlightedPosition)
        {
            int rowCount = 8;
            Console.Clear();
            Console.WriteLine("     A     B     C     D     E     F     G     H   ");
            Console.WriteLine("  +-----+-----+-----+-----+-----+-----+-----+-----+");

            // Print all chess pieces & other elements of the chess board
            foreach (var position in ChessPiecePositions)
            {
                // Add row number and divider on the first element of the row
                if (PositionIsFirstOfTheRow(position.Key))
                {
                    Console.Write($"{rowCount} |");
                }

                // If position param is given & the current position is the param value -> Highlight the chess piece
                if(highlightedPosition != null)
                {
                    if (position.Key.Equals(highlightedPosition))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        // Check if the current position is one of the positions of the highlighted chess piece pattern
                        if (PositionIsInsideOfChessPiecePattern(ChessPiecePositions[(Position)highlightedPosition], (Position)highlightedPosition, position.Key))
                        {
                            // Highlight the current position
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                    }
                    
                }



                // If no chess piece on the position OR the positions chess piece code is positive code -> Add more padding
                if (position.Value == null || position.Value.Code > 0) Console.Write($"  {(position.Value == null ? 0 : position.Value.Code)}  ");
                else Console.Write($" {position.Value.Code}  "); // Otherwise add less padding on negative codes
                Console.ForegroundColor = ConsoleColor.DarkRed; // Reset color, so other elements don't get highlighted
                Console.Write("|");
                
                // If current position is the last of the row -> Add row number + other elements
                if(PositionIsLastOfTheRow(position.Key))
                {
                    Console.Write($" {rowCount}");
                    Console.WriteLine();
                    Console.WriteLine("  +-----+-----+-----+-----+-----+-----+-----+-----+");
                    rowCount--;
                }
            }
            Console.WriteLine("     A     B     C     D     E     F     G     H   ");
        }

        /// <summary>
        /// Prints the current status of the chess board with chess icons.
        /// Optionally a Position enum parameter can be given to highlight the chess pieces pattern on the given Position.
        /// </summary>
        /// <param name="highlightedPosition">Position of a chess piece which pattern is to be highlighted</param>
        private void PrintBoardWithIcons(Position? highlightedPosition)
        {
            int rowCount = 8;
            Console.Clear();
            Console.WriteLine("     A      B      C      D      E      F      G      H   ");
            Console.WriteLine("  +------+------+------+------+------+------+------+------+");

            // Print all chess pieces & other elements of the chess board
            foreach (var position in ChessPiecePositions)
            {
                // Add row number and divider on the first element of the row
                if (PositionIsFirstOfTheRow(position.Key))
                {
                    Console.Write($"{rowCount} |");
                }

                // If position param is given & the current position is the param value -> Highlight the chess piece pattern
                if (highlightedPosition != null && position.Key.Equals(highlightedPosition))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }

                // Print the chess icon or empty position
                string paddingLeft = "  ";
                string paddingRight = "   ";

                Console.Write($"{paddingLeft}{(position.Value == null ? " " : position.Value.Icon)}{paddingRight}");
                Console.ForegroundColor = ConsoleColor.DarkRed; // Reset color, so other elements don't get highlighted
                Console.Write("|");

                // If current position is the last of the row -> Add row number + other elements
                if (PositionIsLastOfTheRow(position.Key))
                {
                    Console.Write($" {rowCount}");
                    Console.WriteLine();
                    Console.WriteLine("  +------+------+------+------+------+------+------+------+");
                    rowCount--;
                }
            }
            Console.WriteLine("     A      B      C      D      E      F      G      H   ");
        }

        public void UpdateChessBoard(Position? highlightedPosition)
        {
            if (UseIcons) PrintBoardWithIcons(highlightedPosition);
            else PrintBoardWithCodes(highlightedPosition);
        }

        /// <summary>
        /// Checks if the Position enum is the first of the row (AX)
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        private bool PositionIsFirstOfTheRow(Position position)
        {
            Position[] firstPositions = new Position[] { Position.A8, Position.A7, Position.A6, Position.A5, Position.A4, Position.A3, Position.A2, Position.A1 };
            return firstPositions.Contains(position);
        }

        /// <summary>
        /// Checks if the Position enum is the last of the row (HX)
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        private bool PositionIsLastOfTheRow(Position position)
        {
            Position[] lastPositions = new Position[] { Position.H8, Position.H7, Position.H6, Position.H5, Position.H4, Position.H3, Position.H2, Position.H1 };
            return lastPositions.Contains(position);
        }

        private bool PositionIsInsideOfChessPiecePattern(AChessPiece piece, Position currentChessPiecePosition, Position possibleNewChessPiecePosition)
        {
            return piece.IsValidMove(currentChessPiecePosition, possibleNewChessPiecePosition);
        }
    }
}
