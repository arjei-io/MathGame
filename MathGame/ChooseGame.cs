using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace MathGame
{
    internal class ChooseGame
    {
        internal void AdditionGame()
        {
            int score = 0;
            Random random = new Random();
            Stopwatch StopWatch = new Stopwatch();
            StopWatch.Start();

            for (int i = 0; i < 5; i++)
            {
                int num1 = random.Next(0, 9);
                int num2 = random.Next(0, 9);

                Console.Clear();
                Console.WriteLine($"What's {num1} + {num2}");
                var result = Console.ReadLine();

                while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
                {
                    Console.WriteLine("Please enter an integer");
                    result = Console.ReadLine();
                }

                if (int.Parse(result) == num1 + num2)
                {
                    score++;
                    Console.WriteLine("Correct! Press 'enter' to continue");
                    Console.ReadLine();
                }
                else if (int.Parse(result) != num1 + num2)
                {
                    Console.WriteLine("Incorrect! Press 'enter' to continue");
                    result = Console.ReadLine();
                }

                if (i == 4)
                {
                    StopWatch.Stop();
                    TimeSpan ts = StopWatch.Elapsed;
                    string elapsedTime = String.Format("{0}", ts.Seconds);
                    Console.Clear();
                    Console.WriteLine("Thanks for playing. Press 'enter' to return to menu");
                    Console.WriteLine($"Completion time: {elapsedTime} seconds.");
                    Console.ReadLine();
                    Helpers.AddToList(score, GameType.Multiplication, elapsedTime);
                }
            }
            //Helpers.AddToList(score, GameType.Addition);
        }

        internal void SubtractionGame()
        {
            int score = 0;
            Random random = new Random();
            Stopwatch StopWatch = new Stopwatch();
            StopWatch.Start();



            for (int i = 0; i < 5; i++)
            {
                int num1 = random.Next(0, 9);
                int num2 = random.Next(0, 9);

                Console.Clear();
                Console.WriteLine($"What's {num1} - {num2}");
                var result = Console.ReadLine();

                while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
                {
                    Console.WriteLine("Please enter an integer");
                    result = Console.ReadLine();
                }

                if (int.Parse(result) == num1 - num2)
                {
                    score++;
                    Console.WriteLine("Correct! Press 'enter' to continue");
                    Console.ReadLine();
                }
                else if (int.Parse(result) != num1 - num2)
                {
                    Console.WriteLine("Incorrect! Press 'enter' to continue");
                    result = Console.ReadLine();
                }

                if (i == 4)
                {
                    StopWatch.Stop();
                    TimeSpan ts = StopWatch.Elapsed;
                    string elapsedTime = String.Format("{0}", ts.Seconds);
                    Console.Clear();
                    Console.WriteLine("Thanks for playing. Press 'enter' to return to menu");
                    Console.WriteLine($"Completion time: {elapsedTime} seconds.");
                    Console.ReadLine();
                    Helpers.AddToList(score, GameType.Multiplication, elapsedTime);
                }
            }
            //Helpers.AddToList(score, GameType.Subtraction);
        }

        internal void DivisionGame()
        {
            int score = 0;
            Stopwatch StopWatch = new Stopwatch();
            StopWatch.Start();
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                int num1 = random.Next(1, 100);
                int num2 = random.Next(1, 100);

               

                while (num1 % num2 != 0)
                {
                    num1 = random.Next(1, 100);
                    num2 = random.Next(1, 100);
                }

                int validNum1 = num1;
                int validNum2 = num2;

                Console.Clear();
                Console.WriteLine($"What's {validNum1} / {validNum2}");
                var result = Console.ReadLine();

                while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
                {
                    Console.WriteLine("Please enter an integer");
                    result = Console.ReadLine();
                }

                if (int.Parse(result) == validNum1 / validNum2)
                {
                    score++;
                    Console.WriteLine("Correct! Press 'enter' to continue");
                    Console.ReadLine();
                }
                else if (int.Parse(result) != validNum1 / validNum2)
                {
                    Console.WriteLine("Incorrect! Press 'enter' to continue");
                    result = Console.ReadLine();
                }

                if (i == 4)
                {
                    StopWatch.Stop();
                    TimeSpan ts = StopWatch.Elapsed;
                    string elapsedTime = String.Format("{0}", ts.Seconds);
                    Console.Clear();
                    Console.WriteLine("Thanks for playing. Press 'enter' to return to menu");
                    Console.WriteLine($"Completion time: {elapsedTime} seconds.");
                    Console.ReadLine();
                    Helpers.AddToList(score, GameType.Multiplication, elapsedTime);
                }
            }

            //Helpers.AddToList(score, GameType.Division);

        }

        internal void MultiplyGame()
        {
            int score = 0;
            Random random = new Random();
            Stopwatch StopWatch = new Stopwatch();
            StopWatch.Start();

            for (int i = 0; i < 5; i++)
            {
                int num1 = random.Next(0, 9);
                int num2 = random.Next(0, 9);

                Console.Clear();
                Console.WriteLine($"What's {num1} * {num2}");
                var result = Console.ReadLine();

                while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
                {
                    Console.WriteLine("Please enter an integer");
                    result = Console.ReadLine();
                }

                if (int.Parse(result) == num1 * num2)
                {
                    score++;
                    Console.WriteLine("Correct! Press 'enter' to continue");
                    Console.ReadLine();
                }
                else if (int.Parse(result) != num1 * num2)
                {
                    Console.WriteLine("Incorrect! Press 'enter' to continue");
                    result = Console.ReadLine();
                }

                if (i == 4)
                {
                    StopWatch.Stop();
                    TimeSpan ts = StopWatch.Elapsed;
                    string elapsedTime = String.Format("{0}", ts.Seconds);
                    Console.Clear();
                    Console.WriteLine("Thanks for playing. Press 'enter' to return to menu");
                    Console.WriteLine($"Completion time: {elapsedTime} seconds.");
                    Console.ReadLine();
                    Helpers.AddToList(score, GameType.Multiplication, elapsedTime);
                }
            }
            
        }
    }
}