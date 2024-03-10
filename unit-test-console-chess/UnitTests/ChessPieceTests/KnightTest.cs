using console_chess.Board;
using console_chess.ChessPieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unit_test_console_chess.TestDataGenerators;

namespace unit_test_console_chess.UnitTests.ChessPieceTests
{
    public class KnightTest
    {
        [Theory]
        [ClassData(typeof(KnightDataGenerator))]
        public void IsValidMoveKnight(Knight knight, Position originalPosition, Position newPosition, Dictionary<Position, AChessPiece?> chessBoard, bool expectedResult)
        {
            ChessBoard board = new ChessBoard(false);
            board.ChessPiecePositions = chessBoard;
            board.SetChessBoardToAllPieces();

            bool result = chessBoard[originalPosition].IsValidMove(originalPosition, newPosition, chessBoard);
            Assert.True(result == expectedResult);
        }
    }
}
