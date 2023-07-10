using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("These are the messages for the lecture!!");
        Lecture lecture = new Lecture("Lecture test", "Lecture test description", "test date", "test time", new Address("12648 S. Sonora Ave", "Kuna", "ID"), "Porter", 500);
        Console.WriteLine("Standard message:");
        lecture.StandardMessage();
        Console.WriteLine("Short message:");
        lecture.ShortMessage();
        Console.WriteLine("Full message:");
        lecture.FullMessage();
        Console.WriteLine();


        Console.WriteLine("These are the messages for the reception!!");
        Reception reception = new Reception("email@email.test", "Reception test", "Reception test desc", "test date", "test time", new Address("12648 S. Sonora Ave", "Kuna", "ID"));
        Console.WriteLine("Standard message:");
        reception.StandardMessage();
        Console.WriteLine("Short message:");
        reception.ShortMessage();
        Console.WriteLine("Full message:");
        reception.FullMessage();
        Console.WriteLine();

        Console.WriteLine("These are the messages for the outdoor!!");
        Outdoor outdoor = new Outdoor("The weather is fine", "Outdoor test", "Outdoor test desc","test date", "test time", new Address("12648 S. Sonora Ave", "Kuna", "ID"));
        Console.WriteLine("Standard message:");
        outdoor.StandardMessage();
        Console.WriteLine("Short message:");
        outdoor.ShortMessage();
        Console.WriteLine("Full message:");
        outdoor.FullMessage();
        Console.WriteLine();
    }
}