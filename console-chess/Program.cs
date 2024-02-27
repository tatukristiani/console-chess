using console_chess.ChessPieces;
using console_chess.Board;

namespace console_chess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TODO: Create chess board
            ChessBoard board = new ChessBoard();
            board.PrintBoardWithCodes();

        }
    }
}