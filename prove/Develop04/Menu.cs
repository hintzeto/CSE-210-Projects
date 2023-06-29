public class Menu
{
    public void DisplayMenu()
        {
            string response = "";
            string[] options = {"b","l","r",""};

            while(response != "q")
            {

            Console.Write("[B]reathing \n[L]isting \n[R]eflection \n[Q]uit\n");

            response = Console.ReadLine() ?? String.Empty;
            response = response.ToLower();

            if(options.Contains(response) == false)
            {
                Console.WriteLine("Please enter something valid you goon.");
            }

            switch(response){
     
          case "b":

        Breathing breathing = new Breathing("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        breathing.Display();
        Thread.Sleep(2000);
        breathing.Breathe();
        breathing.End();


          break;

          case "l":

        Listing listing = new Listing("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Thread.Sleep(1000);
        listing.GetRandomPrompt();
        listing.Timer();
        listing.GetResponse();

          break;


          case "r":
        
        Reflection reflection = new Reflection("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Thread.Sleep(1000);
        reflection.Display();
        Thread.Sleep(5000);
        reflection.GetRandomPrompt();
        Thread.Sleep(1000);
        Console.WriteLine("Regarding the above prompt, please answer the following questions:");
        Thread.Sleep(3000);
        reflection.GetRandomQuestion();
        Thread.Sleep(2000);
        reflection.End();

          break;
            }
      }
      Console.WriteLine("Goodbye!");
    }
    
  }