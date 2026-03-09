

using System.Diagnostics;

namespace MathGame
{
    internal class Helpers
    {
        Stopwatch StopWatch = new Stopwatch();
        internal static List<Game> games = new List<Game>() { };

        internal static void AddToList(int gameScore, GameType gameType, string gameTime)
        {
            games.Add(new Game
            {
                Score = gameScore,
                Type = gameType,
                Seconds = gameTime
            });
        }

        internal static void DisplayHistory()
        {

            Console.WriteLine("Your session history:");
            Console.WriteLine("------------------------------------------------");
            foreach (Game game in games)
            {
                Console.WriteLine($"Score: {game.Score} - Mode: {game.Type} - Completion time: {game.Seconds} seconds.");
            }
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Press 'enter' to return to menu.");
            Console.ReadLine();

        }
    }
}
