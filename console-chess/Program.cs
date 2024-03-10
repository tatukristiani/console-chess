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
            Console.ForegroundColor = ConsoleColor.White;
            AGame game = null;

            Console.WriteLine("PvP or AI Game? (PvP/AI): ");
            string? gameSelect = Console.ReadLine();

            Console.WriteLine("Use icons? (Y/N): ");
            string? useIcons = Console.ReadLine();

            if(gameSelect.Equals("PvP", StringComparison.OrdinalIgnoreCase))
            {
                game = new PlayerVsPlayerGame(useIcons.Equals("Y", StringComparison.OrdinalIgnoreCase));
            }
            else if(gameSelect.Equals("AI", StringComparison.OrdinalIgnoreCase))
            {
                game = new AIGame(useIcons.Equals("Y", StringComparison.OrdinalIgnoreCase));
            }


            if (game != null) game.StartGame();

        }
    }
}