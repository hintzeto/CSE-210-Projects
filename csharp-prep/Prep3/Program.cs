using System;

class Program
{
    static void Main(string[] args)
    {
        string run = "y";
        do
        {
            Random randomGenerator = new Random();
            int magic_number = randomGenerator.Next(1, 100);

            int magic_guess;
            int num_guesses = 1;

            do
            {

            Console.Write("Take a guess: ");
            string guess = Console.ReadLine();
            magic_guess = int.Parse(guess);

            if (magic_guess > magic_number)
                {Console.WriteLine("Lower");
                num_guesses += 1;}
            else if (magic_guess < magic_number)
                {Console.WriteLine("Higher");
                num_guesses += 1;}
            else
                {num_guesses += 1;
                Console.Write($"Good guess! It took you {num_guesses} guesses to get it right.");}
                Console.Write("Would you like to play again? (y/n)");
                run = Console.ReadLine().ToLower();

            

            } while (magic_guess != magic_number);
            } while(run != "n");
        } 
}