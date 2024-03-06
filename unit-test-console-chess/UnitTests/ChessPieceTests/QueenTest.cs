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
    public class QueenTest
    {
        [Theory]
        [ClassData(typeof(QueenDataGenerator))]
        public void IsValidMoveQueen(Queen queen, Position currentPosition, Position newPosition, Dictionary<Position, AChessPiece?> chessBoard, bool expectedResult)
        {
            bool result = queen.IsValidMove(currentPosition, newPosition, chessBoard);
            Assert.True(result == expectedResult);
        }
    }
}
