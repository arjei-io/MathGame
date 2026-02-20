using System;
using System.Collections.Generic;
using System.Text;

namespace MathGame
{
    internal class Menu
    {
        internal void ShowMenu()
        {
            ChooseGame chooseGame = new ChooseGame();
            bool displayMenu = true;
            string? userInput;
            string menuMessage = @"Choose an operation and press enter to continue:
+:  Addition
-:  Subtraction
/:  Division
*:  Multiply
H:  Display game history 
Q:  Exit the program";


            Console.WriteLine("Welcome to MathGame.\n-Press 'enter' to show menu-");
            Console.ReadLine();

            do
            {
                Console.Clear();
                Console.WriteLine(menuMessage);
                userInput = Console.ReadLine();

                switch (userInput.Trim().ToLower())
                {
                    case "+":
                        Console.Clear();
                        Console.WriteLine("+ chosen.");
                        chooseGame.AdditionGame();
                        break;

                    case "-":
                        Console.Clear();
                        Console.WriteLine("- chosen.");
                        chooseGame.SubtractionGame();
                        break;

                    case "/":
                        Console.Clear();
                        Console.WriteLine("/ chosen.");
                        chooseGame.DivisionGame();
                        break;

                    case "*":
                        Console.Clear();
                        Console.WriteLine("* chosen.");
                        chooseGame.MultiplyGame();
                        break;

                    case "h":
                        Console.Clear();
                        Console.WriteLine("Displaying history:");
                        Helpers.DisplayHistory();
                        break;

                    case "q":
                        Console.WriteLine("Hope you enjoyed your stay :)");
                        displayMenu = false;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Please type a valid operation: (Enter to show menu)");
                        break;
                }
            } while (displayMenu);
        }

    }
}
