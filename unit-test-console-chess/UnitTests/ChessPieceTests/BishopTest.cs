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
    //TODO: Add test cases for these and fix logic
    /* F8, nyt voi liikkua oman yli A4, jossa vastus (musta)
     * C1, nyt voi liikkua H5, G6 ja F7 (valkonen)
     * A3, nyt voi liikkua H3, H5, G6 ja F7 (valkonen)
     * 
     */
    public class BishopTest
    {
        [Theory]
        [ClassData(typeof(BishopDataGenerator))]
        public void MoveHorizontalTest(Bishop bishop, Position currentPosition, Position newPosition, Dictionary<Position, AChessPiece?> chessBoard, bool expectedResult)
        {
            bool result = bishop.IsValidMove(currentPosition, newPosition, chessBoard);
            Assert.True(result == expectedResult);
        }
    }
}
