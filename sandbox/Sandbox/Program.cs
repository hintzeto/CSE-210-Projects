using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        string filePath = "C:/School/Semester 3/CSE 210/CSE-210-Projects/Testing/test.txt";

        string str = "This is a test string";
        int integer = 5;
        double doub = 5.5433;

        string data = integer + "\n" + str + "\n" + doub;
        File.WriteAllText(filePath, data);

        string readData = File.ReadAllText(filePath);
        string[] values = readData.Split('\n');

        string strRead = values[1];
        int integerRead = int.Parse(values[0]);
        double doubRead = double.Parse(values[2]);

        Console.WriteLine(strRead + integerRead + doubRead);
        
    }
}