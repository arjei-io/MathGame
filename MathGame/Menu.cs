namespace MathGame
{
    internal class Menu
    {
        GameEngine gameEngine = new();
       internal void ShowMenu(string name, DateTime date)
        {
            bool isGameOn = true;

            do
            {
                Console.Clear();
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine($"Hello {name}. This is our math game");
                Console.WriteLine($@"What type of question would you like to start with? Choose from below:
A - Addition
S - Substraction
M - Multiplication
D - Division
R - Random question
H - History
Q - Quit the game");
                Console.WriteLine("----------------------------------------------------");
                string questionSelected = Console.ReadLine();

                switch (questionSelected.Trim().ToLower())
                {
                    case "a":
                        gameEngine.AdditionQuestion();
                        break;
                    case "s":
                        gameEngine.SubtractionQuestion();
                        break;
                    case "m":
                        gameEngine.MultiplicationQuestion();
                        break;
                    case "d":
                        gameEngine.DivisionQuestion();
                        break;
                    case "r":
                        gameEngine.RandomQuestion();
                        break;
                    case "h":
                        Helpers.DisplayHistory();
                        break;
                    case "q":
                        Console.WriteLine($"Thank you for playing!");
                        isGameOn = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Input.");
                        break;
                }
            } while (isGameOn);
            
        }


    }
}
