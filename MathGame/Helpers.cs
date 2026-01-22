using System.Collections.Generic;
using MathGame.Models;

namespace MathGame
{
    internal class Helpers
    {
        //internal static List<string> histories;
        internal static List<History> histories = new List<History>
        {
            
        };




        internal static void AddToHistory(int gameScore, string gameType)
        {
            histories.Add(new History
            {
                Date = DateTime.Now,
                Score = gameScore,
                Type = gameType
            });
        }

        internal static void DisplayHistory()
        {
            Console.Clear();
            Console.WriteLine("Your results:");
            foreach (var history in histories)
            {
                Console.WriteLine($"{history.Date} - {history.Type}: {history.Score}pts");
            }
            Console.WriteLine("Press any button to return to Menu:");
            Console.Read();
        }

        internal static int[] GetDivisionNumbers()
        {
            var random = new Random();
            int firstNumber = random.Next(0, 100);
            int secondNumber = random.Next(0, 100);

            var result = new int[2];

            while (firstNumber % secondNumber != 0)
            {
                firstNumber = random.Next(0, 100);
                secondNumber = random.Next(0, 100);
            }

            result[0] = firstNumber;
            result[1] = secondNumber;



            return result;
        }

        internal static string? ValidateResult(string result)
        {
            while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
            {
                Console.WriteLine("Your answer needs to be a number. Try again.");
                result = Console.ReadLine();
            }
            return result;
        }

        internal static string GetName()
        {
            Console.WriteLine("Type your name:");
            string name = Console.ReadLine();
            return name;
        }
    }
}
