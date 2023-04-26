using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int num;


        do
        {
            Console.Write("Enter a number (0 to stop): ");
            string number = Console.ReadLine();
            num = int.Parse(number);
            numbers.Add(num);
        } while (num != 0);

        int sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");

        double mean = numbers.Average();
        Console.WriteLine($"The average is: {mean}");

        int max = numbers.Max();
        Console.WriteLine($"The max is: {max}");
    }
}