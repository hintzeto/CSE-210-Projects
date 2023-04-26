using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.WriteLine("Enter your name: ");
            string userName = Console.ReadLine();

            return userName;
        }

        static int PromptUserNumber()
        {
            Console.WriteLine("Enter your favorite number: ");
            string number = Console.ReadLine();
            int num = int.Parse(number);

            return num;
        }

        static int SquareNumber(int num)
        {
            int squared = num*num;
            return squared;
        }

        static void DisplayResults(int squared, string userName)
        {
            Console.WriteLine($"The user's name is {userName}");
            Console.Write($"The squared number is {squared}");
        }

        static void Main()
        {
            DisplayWelcome();
            string userName = PromptUserName();
            int num = PromptUserNumber();
            int square = SquareNumber(num);
            DisplayResults(square, userName);
        }

        Main();
    }
}