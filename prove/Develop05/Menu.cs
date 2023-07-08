public class Menu
{
  private User _user;
  public Menu(string name)
  {
    _user = new User($"{name}");
  }

  public Menu(string name, List<Simple> simple, List<Checklist> checklist, List<Eternal> eternal)
  {
    _user = new User($"{name}", simple, checklist, eternal);
  }

    public void DisplayMenu()
        {
            
            string response = "";
            string[] options = {"v","r","a","s","c","q"};

            while(response != "q")
            {

            Console.WriteLine("[V]iew score\n[R]ecord goal\n[A]dd goal\n[S]ave\n[C]urrent goals\n[Q]uit");

            response = Console.ReadLine() ?? String.Empty;
            response = response.ToLower();

            if(options.Contains(response) == false)
            {
                Console.WriteLine("Please enter something valid you goon.");
            }

            switch(response.ToLower()){
     
          case "v":
            Console.WriteLine($"You have {_user.GetScore()} points!!");
        


          break;

          case "r":
            Console.WriteLine("What kind of goal would you like to record? ");
            string answer = Console.ReadLine();
            if(answer.ToLower() == "simple"){
                _user.ViewSimpleGoals(false, true);

                Console.WriteLine("Select the ID number of the goal you would like to record.");
                string toRecord = Console.ReadLine();
                int toRecord1 = int.Parse(toRecord);

                _user.AddScore(_user.RecordSimpleGoal(toRecord1));

            }

            else if(answer.ToLower() == "checklist"){
                _user.ViewChecklistGoals(false, true);

                Console.WriteLine("Select the ID number of the goal you would like to record.");
                string toRecord = Console.ReadLine();
                int toRecord1 = int.Parse(toRecord);

                _user.AddScore(_user.RecordChecklistGoal(toRecord1));
            }

            else{
                _user.ViewEternalGoals(true);

                Console.WriteLine("Select the ID number of the goal you would like to record.");
                string toRecord = Console.ReadLine();
                int toRecord1 = int.Parse(toRecord);

                _user.AddScore(_user.RecordEternalGoal(toRecord1));
            }

        

          break;


          case "a":
            Console.WriteLine("What kind of goal would you like to add?");
            string type = Console.ReadLine();

            Console.WriteLine("What is the name of the goal?");
            string goalName = Console.ReadLine();

            Console.WriteLine("Write a brief description of your goal.");
            string goalDescription = Console.ReadLine();

            Console.WriteLine("How many points is the goal worth? ");
            string point = Console.ReadLine();
            int points = int.Parse(point);

            

            if(type.ToLower() == "simple"){
                _user.AddGoal(new Simple(points, goalName, goalDescription));
            }
            else if(type.ToLower() == "checklist"){
                Console.WriteLine("How many times would you like to complete this goal? ");
                string tar = Console.ReadLine();
                int target = int.Parse(tar);

                Console.WriteLine("How many bonuse points will you receive for hitting your target? ");
                string bonus = Console.ReadLine();
                int bonusPoints = int.Parse(bonus);

                _user.AddGoal(new Checklist(points, goalName, goalDescription, target, bonusPoints));
            }
            else{
                _user.AddGoal(new Eternal(points, goalName, goalDescription));
            }



          break;
            
          case "s":
            string filePath = Directory.GetCurrentDirectory() + "\\" + _user.GetName() + ".txt";
            string toSave = _user.GetSaveData();
            File.WriteAllText(filePath, toSave);

          break;

          case "c":
            _user.ViewAllGoals(false);
          break;
            }
      }
      Console.WriteLine("Goodbye!");
    }
    
  }