

namespace MathGame
{
    internal class Helpers
    {
        internal static List<Game> games = new List<Game>() {};

        internal static void AddToList(GameType gameType)
        {
            games.Add(new Game 
            {
                Type = gameType
            });
        }

        internal static void DisplayHistory()
        {

            Console.WriteLine("Your session history:");
            Console.WriteLine("------------------------------------------------");
            foreach (Game game in games)
            {
                Console.WriteLine(game.Type);
            }
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Press 'enter' to return to menu.");
            Console.ReadLine();

        }
    }
}
