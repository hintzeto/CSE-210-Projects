public class Menu
{
    public Journal _journal;

    public Menu(Journal journal)
    {
        _journal = journal;
    }

    public void displayMenu()
        {
            string response = "";
            string[] options = {"d","a","s","l","q"};

            while(response != "q")
            {

            Console.Write("[D]isplay journal \n[A]dd new entry \n[S]ave entry \n[L]oad file \n[Q]uit\n");

            response = Console.ReadLine() ?? String.Empty;
            response = response.ToLower();

            if(options.Contains(response) == false)
            {
                Console.WriteLine("Please enter something valid you goon.");
            }

            switch(response){
     
          case "a":

          Entry _entry = new Entry();
         
          _journal.AddEntry(_entry);
          break;

          case "d":

          if(_journal._entries.Count != 0){
           _journal.displayEntries();
            
          }
          else{
           Console.WriteLine("\n------------ Nothing to display you goon ------------ \n");
          
          }

          break;


          case "s":
          if(_journal._entries.Count != 0){
            Journal.saveEntry(_journal._entries);
            Console.WriteLine("file saved!");
            
          }
          else{
            Console.WriteLine("\n------------ Nothing to save you goon ------------ \n\n");
          }
          break;
          
          case "l":
          _journal._entries = Journal.loadEntries();
          break;
          
            }
      }
      Console.WriteLine("Goodbye!");
    }
    
  }