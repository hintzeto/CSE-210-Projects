public class Journal
{

    public List<Entry> _entries = new List<Entry>();
    private string _fileName;

 public void AddEntry(Entry newEntry)
 {  
     _entries.Add(newEntry);
 } 

 
 public void displayEntries()
 {
   foreach (Entry ent in _entries)
   {
    
     Console.WriteLine(ent.stringTheory());
   }
 }

 public static void saveEntry(List<Entry> entries)
 {
   Console.WriteLine($"What is the file name?");
    string _fileName = Console.ReadLine() ?? string.Empty;
    string _filePath = $"./savedFiles/{_fileName.ToLower().Trim()}.txt";

    using (StreamWriter writer = new StreamWriter(_filePath))
    {
      foreach (Entry entry in entries)
      {
        writer.WriteLine(entry.stringTheory());
      }
    }
   
 }
 public static List<Entry> loadEntries()
 {
  List<Entry> _entries = new List<Entry>();

  Console.WriteLine($"What is the file name?");
  string _fileName = Console.ReadLine() ?? string.Empty;

  string[] lines = System.IO.File.ReadAllLines($"./savedFiles/{_fileName.ToLower().Trim()}.txt");

  foreach (string line in lines)
  {
     Console.WriteLine($"{line}");
     
  }Console.WriteLine("Goodbye!");
 
 return _entries;
 }
}
