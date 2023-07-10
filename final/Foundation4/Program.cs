using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running(5.1, "10 July 2023", 69);
        running.GetSummary();

        Cycling cycling = new Cycling(30, "10 July 2023", 120);
        cycling.GetSummary();

        Swimming swimming = new Swimming(10, "10 July 2023", 30);
        swimming.GetSummary();
    }
}