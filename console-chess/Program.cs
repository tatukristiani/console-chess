using console_chess.ChessPieces;
using console_chess.Board;
using console_chess.Game;

namespace console_chess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AGame game = new PlayerVsPlayerGame();

            game.StartGame();

        }
    }
}