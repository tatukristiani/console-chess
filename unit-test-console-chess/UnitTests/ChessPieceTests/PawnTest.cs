
using console_chess.ChessPieces;
using console_chess.Board;
using unit_test_console_chess.TestDataGenerators;

namespace unit_test_console_chess.UnitTests.ChessPieceTests
{
    // TODO: Add test cases for these and fix logic
    /*
     *  B7, nyt voi liikkua vastuksen yli joka on yhden moven p‰‰ss‰ (musta)
     */
    public class PawnTest
    {
        [Theory]
        [ClassData(typeof(PawnDataGenerator))]
        public void IsValidMovePawn(Pawn pawn, Position pawnPosition, Position newPosition, Dictionary<Position, AChessPiece?> chessBoard, bool expectedResult)
        {
            bool result = pawn.IsValidMove(pawnPosition, newPosition, chessBoard);
            Assert.True(result == expectedResult);
        }
    }
}