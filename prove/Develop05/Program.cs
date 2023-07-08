using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Would you like to load an existing file? y/n");
        string answer = Console.ReadLine();

        if(answer.ToLower() == "y")
        {
            Console.WriteLine("Which file would you like to load? (Case sensitive)");

            string[] files = Directory.GetFiles(Directory.GetCurrentDirectory());

            foreach(string file in files)
            {
                if (file.Contains(".txt"))
                {
                    Console.WriteLine(file.Remove(0, Directory.GetCurrentDirectory().Length + 1));
                }
            }

            string wanted = Console.ReadLine();
            string readData = File.ReadAllText(Directory.GetCurrentDirectory() + "\\" + wanted);

            string[] values = readData.Split("\n");

            int numSimple = int.Parse(values[0]);
            int numChecklist = int.Parse(values[1]);
            int numEternal = int.Parse(values[2]);

            List<Simple> simpleGoals = new List<Simple>();
            List<Checklist> checklistGoals = new List<Checklist>();
            List<Eternal> eternalGoals = new List<Eternal>();

            
            for(int i = 0; i < numSimple; i++)
            {
                string name = values[3 + (i*4)];
                int points = int.Parse(values[4 + (i*4)]);
                string description = values[5 + (i*4)];
                bool isComplete = bool.Parse(values[6 + (i*4)]);
                Simple simple = new Simple(points, name, description, isComplete);
                simpleGoals.Add(simple);
            }
            for(int i = 0; i < numChecklist; i++)
            {
                string name = values[3 + (numSimple * 4) + (i * 7)];
                int points = int.Parse(values[4 + (numSimple * 4) + (i * 7)]);
                string description = values[5 + (numSimple * 4) + (i * 7)];
                bool isComplete = bool.Parse(values[6 + (numSimple * 4) + (i * 7)]);
                int current = int.Parse(values[7 + (numSimple * 4) + (i * 7)]);
                int target = int.Parse(values[8 + (numSimple * 4) + (i * 7)]);
                int bonus = int.Parse(values[9 + (numSimple * 4) + (i * 7)]);
                Checklist checklist = new Checklist(points, name, description, target, bonus, current, isComplete);
                checklistGoals.Add(checklist);
            }
            for(int i = 0; i < numEternal; i++)
            {
                string name = values[3 + (numSimple * 4) + (numChecklist * 7) + (i * 5)];
                int points = int.Parse(values[4 + (numSimple * 4) + (numChecklist * 7) + (i * 5)]);
                string description = values[5 + (numSimple * 4) + (numChecklist * 7) + (i * 5)];
                bool isComplete = bool.Parse(values[6 + (numSimple * 4) + (numChecklist * 7) + (i * 5)]);
                int current = int.Parse(values[7 + (numSimple * 4) + (numChecklist * 7) + (i * 5)]);
                Eternal eternal = new Eternal(points, name, description, current, isComplete);
                eternalGoals.Add(eternal);

                Menu menu = new Menu(wanted.Remove(wanted.Length - 4), simpleGoals, checklistGoals, eternalGoals);
                menu.DisplayMenu();
            }
        }
        
        else
        {
            Console.WriteLine("What is your name? ");
            string answerName = Console.ReadLine();

            Menu menu = new Menu(answerName);
            menu.DisplayMenu();
        }

        



    }
}