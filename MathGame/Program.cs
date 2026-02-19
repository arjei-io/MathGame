namespace MathGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();

            Console.WriteLine("Welcome to MathGame.\n-Press 'enter' to show menu-");
            Console.ReadLine();
            menu.ShowMenu();

        }
    }


}


