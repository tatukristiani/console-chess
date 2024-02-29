using console_chess.ChessPieces;
using console_chess.Board;
using console_chess.Game;
using System.Text;

namespace console_chess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            AGame game = new PlayerVsPlayerGame(false);

            game.StartGame();

        }
    }
}