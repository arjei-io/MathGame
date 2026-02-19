using System;
using System.Collections.Generic;
using System.Text;

namespace MathGame
{
    internal class ChooseGame
    {
        internal void AdditionGame()
        {
            Random random = new Random();




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
                    Console.WriteLine("Thanks for playing. Press 'enter' to return to menu");
                    Console.ReadLine();
                }
            }
        }

        internal void SubtractionGame()
        {
            Random random = new Random();




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
                    Console.WriteLine("Thanks for playing. Press 'enter' to return to menu");
                    Console.ReadLine();
                }
            }
        }

        internal void DivisionGame()
        {

        }

        internal void MultiplyGame()
        {

        }
    }
}