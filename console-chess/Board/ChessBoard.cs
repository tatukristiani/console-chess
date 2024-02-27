using console_chess.ChessPieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_chess.Board
{
    public class ChessBoard
    {
        private Dictionary<Position, AChessPiece?> ChessPiecePositions;

        public ChessBoard()
        {
            this.ChessPiecePositions = Populate();
        }

        // Populates the chess board positions with Chess Pieces
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

        // Prints the current chess board with chess piece code values
        public void PrintBoardWithCodes()
        {
            Console.Clear();
            Console.WriteLine("+----+----+----+----+----+----+----+----+");
            foreach (var position in ChessPiecePositions)
            {
                if (PositionIsFirstOfTheRow(position.Key)) Console.Write("|");

                if (position.Value == null || position.Value.Code > 0) Console.Write($"  {(position.Value == null ? 0 : position.Value.Code)} ");
                else Console.Write($" {position.Value.Code} ");
                Console.Write("|");
                
                if(PositionIsLastOfTheRow(position.Key))
                {
                    Console.WriteLine();
                    Console.WriteLine("+----+----+----+----+----+----+----+----+");
                }
            }
        }

        // Checks if the Position enum is the first of the row (AX)
        private bool PositionIsFirstOfTheRow(Position position)
        {
            Position[] firstPositions = new Position[] { Position.A8, Position.A7, Position.A6, Position.A5, Position.A4, Position.A3, Position.A2, Position.A1 };
            return firstPositions.Contains(position);
        }

        // Chesk if the Position enum is the last of the row (HX)
        private bool PositionIsLastOfTheRow(Position position)
        {
            Position[] lastPositions = new Position[] { Position.H8, Position.H7, Position.H6, Position.H5, Position.H4, Position.H3, Position.H2, Position.H1 };
            return lastPositions.Contains(position);
        }
    }
}
