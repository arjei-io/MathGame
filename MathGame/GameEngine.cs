

using static System.Net.Mime.MediaTypeNames;

namespace MathGame
{
    internal class GameEngine
    {
        
        internal void AdditionQuestion()
        {


            int score = 0;
            var random = new Random();
            int firstNumber;
            int secondNumber;


            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine("Addition selected");
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} + {secondNumber}");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);



                if (int.Parse(result) == firstNumber + secondNumber)
                {
                    Console.WriteLine("Correct! Type any key for next question.");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Incorrect... Type any key to continue");
                    Console.ReadLine();
                }
                if (i == 4)
                {
                    Console.Clear();
                    Console.WriteLine($"Game over. Your final score is {score}. Press any key to return to main menu.");
                    Helpers.AddToHistory(score, "Addition");
                    Console.ReadLine();
                }

            }

        }

        internal void SubtractionQuestion()
        {


            int score = 0;
            var random = new Random();
            int firstNumber;
            int secondNumber;


            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine("Substraction selected");
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} - {secondNumber}");
                var result = Console.ReadLine();
                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber - secondNumber)
                {
                    Console.WriteLine("Correct! Type any key for next question.");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Incorrect... Type any key to continue");
                    Console.ReadLine();
                }
                if (i == 4)
                {
                    Console.Clear();
                    Console.WriteLine($"Game over. Your final score is {score}. Press any key to return to main menu.");
                    Helpers.AddToHistory(score, "Subtraction");
                    Console.ReadLine();
                }

            }

        }

        internal void MultiplicationQuestion()
        {


            int score = 0;
            var random = new Random();
            int firstNumber;
            int secondNumber;


            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine("Multiplication selected");
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} * {secondNumber}");
                var result = Console.ReadLine();
                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber * secondNumber)
                {
                    Console.WriteLine("Correct! Type any key for next question.");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Incorrect... Type any key to continue");
                    Console.ReadLine();
                }
                if (i == 4)
                {
                    Console.Clear();
                    Console.WriteLine($"Game over. Your final score is {score}. Press any key to return to main menu.");
                    Helpers.AddToHistory(score, "Multiplication");
                    Console.ReadLine();
                }
            }
        }

        internal void DivisionQuestion()
        {
            int score = 0;


            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine("Division selected");
                int[] divisionNumbers = Helpers.GetDivisionNumbers();

                int firstNumber = divisionNumbers[0];
                int secondNumber = divisionNumbers[1];

                Console.WriteLine($"{firstNumber} / {secondNumber}");
                var result = Console.ReadLine();
                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber / secondNumber)
                {
                    Console.WriteLine("Correct! Type any key for next question.");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Incorrect... Type any key to continue");
                    Console.ReadLine();
                }
                if (i == 4)
                {
                    Console.Clear();
                    Console.WriteLine($"Game over. Your final score is {score}. Press any key to return to main menu.");
                    Helpers.AddToHistory(score, "Division");
                    Console.ReadLine();
                }
            }
        }

        internal void RandomQuestion()
        {

            //TODO: Random question
            Console.Clear();
            Console.WriteLine("Fooled ya! This is still WIP... \nPress any key to return to main menu");
            Console.ReadLine();
        }

    }
}
