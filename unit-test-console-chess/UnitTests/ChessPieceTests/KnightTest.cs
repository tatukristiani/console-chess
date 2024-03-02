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
    // TODO: Add testcases for these and fix logic
    /*
     * A1, nyt voi liikkua H3 (valkonen)
     * H3, nyt voi liikkua B1, B3 ja A4 (valkonen)
     * G7, nyt voi liikkua A6 (musta)
     */
    public class KnightTest
    {
        [Theory]
        [ClassData(typeof(KnightDataGenerator))]
        public void IsValidMoveKnight(Knight knight, Position originalPosition, Position newPosition, Dictionary<Position, AChessPiece?> chessBoard, bool expectedResult)
        {
            bool result = knight.IsValidMove(originalPosition, newPosition, chessBoard);
            Assert.True(result == expectedResult);
        }
    }
}
