



using System.Numerics;

Console.WriteLine("Type your name:");

string name = Console.ReadLine();
var date = DateTime.UtcNow;

List<string> history = new List<string>();
int score = 0;
Menu();

void Menu()
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

    if (questionSelected.Trim().ToLower().ToString() == "a")
    {
        AdditionQuestion();
    }
    else if (questionSelected.Trim().ToLower().ToString() == "s")
    {
        SubstractionQuestion();
    }
    else if (questionSelected.Trim().ToLower().ToString() == "m")
    {
        MultiplicationQuestion();
    }
    else if (questionSelected.Trim().ToLower().ToString() == "d")
    {
        DivisionQuestion();
    }
    else if (questionSelected.Trim().ToLower().ToString() == "r")
    {
        RandomQuestion();
    }
    else if (questionSelected.Trim().ToLower().ToString() == "h")
    {
        DisplayHistory();
    }
    else if (questionSelected.Trim().ToLower().ToString() == "q")
    {
        Console.WriteLine("Thank you for playing");
        Environment.Exit(1);
    }
    else
    {
        Console.WriteLine("Invalid input");
        Menu();
    }
}


void AdditionQuestion()
{
    Console.Clear();
    Console.WriteLine("Addition selected");

    var random = new Random();
    int firstNumber;
    int secondNumber;
    

    for (int i=0; i<5; i++)
    {
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} + {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber + secondNumber)
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect...");
        }

    }

    history.Add($"{DateTime.Now} - Addition: Score: {score}");
    Console.WriteLine($"Game finished. Your final score is {score}");
    Menu();
    


}

void SubstractionQuestion()
{
    Console.Clear();
    Console.WriteLine("Substraction selected");

    var random = new Random();
    int firstNumber;
    int secondNumber;


    for (int i = 0; i < 5; i++)
    {
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} - {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber - secondNumber)
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect...");
        }

    }

    Console.WriteLine($"Game finished. Your final score is {score}");
    Menu();
}

void MultiplicationQuestion()
{
    Console.Clear();
    Console.WriteLine("Multiplication selected");

    var random = new Random();
    int firstNumber;
    int secondNumber;


    for (int i = 0; i < 5; i++)
    {
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} * {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber * secondNumber)
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect...");
        }

    }

    Console.WriteLine($"Game finished. Your final score is {score}");
    Menu();
}


int[] GetDivisionNumbers()
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

void DivisionQuestion()
{
    Console.Clear();
    Console.WriteLine("Division selected");

    for (int i = 0; i < 5; i++)
    {
        int[] divisionNumbers = GetDivisionNumbers();
        
        int firstNumber = divisionNumbers[0];
        int secondNumber = divisionNumbers[1];

        Console.WriteLine($"{firstNumber} / {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber / secondNumber)
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect...");
        }

    }

    Console.WriteLine($"Game finished. Your final score is {score}");
    Menu();

}

void RandomQuestion()
{
    throw new NotImplementedException();
}

void DisplayHistory()
{

    Console.WriteLine("Your results:");
    foreach (string results in history)
    {
        Console.WriteLine(results);
    }
}

