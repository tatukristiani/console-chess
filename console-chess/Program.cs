using console_chess.ChessPieces;
using console_chess.Board;
using console_chess.Game;
using System.Text;
using console_chess.Players;

namespace console_chess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.OutputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.White;
            AGame? game = null;
            string? gameMode;

            while (true)
            {
                Console.Write("PvP or AI Game? (PvP/AI): ");
                string? input = Console.ReadLine();
                gameMode = String.IsNullOrWhiteSpace(input) ? String.Empty : input;

                if (gameMode.Equals("PvP", StringComparison.OrdinalIgnoreCase) || gameMode.Equals("AI", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
            }

            string? useIcons;
            while (true)
            {
                Console.Write("Use icons? (Y/N): ");
                string? input = Console.ReadLine();
                useIcons = String.IsNullOrWhiteSpace(input) ? String.Empty : input;

                if (useIcons.Equals("Y", StringComparison.OrdinalIgnoreCase) || useIcons.Equals("N", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
            }

            if (gameMode.Equals("PvP", StringComparison.OrdinalIgnoreCase))
            {
                game = new PlayerVsPlayerGame(useIcons.Equals("Y", StringComparison.OrdinalIgnoreCase));
            }
            else if(gameMode.Equals("AI", StringComparison.OrdinalIgnoreCase))
            {
                game = new AIGame(useIcons.Equals("Y", StringComparison.OrdinalIgnoreCase));
            }


            game?.StartGame();
            

        }
    }
}