
using console_chess.ChessPieces;
using console_chess.Board;
using unit_test_console_chess.TestDataGenerators;

namespace unit_test_console_chess.UnitTests.ChessPieceTests
{
    public class PawnTest
    {
        [Theory]
        [ClassData(typeof(PawnDataGenerator))]
        public void IsValidMovePawn(Pawn pawn, Position pawnPosition, Position newPosition, Dictionary<Position, AChessPiece?> chessBoard, bool expectedResult)
        {
            ChessBoard board = new ChessBoard(false);
            board.ChessPiecePositions = chessBoard;
            board.SetChessBoardToAllPieces();

            bool result = chessBoard[pawnPosition].IsValidMove(pawnPosition, newPosition, chessBoard);
            Assert.True(result == expectedResult);
        }
    }
}