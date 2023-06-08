Console.WriteLine("Please enter your scripture reference in the following format: Alma 13:21-22");
string reference = Console.ReadLine();

char[] delimiters = { ' ', '-', ':' };
List<string> splitReference = reference.Split(delimiters).ToList();

string book = splitReference[0];
int chapter = int.Parse(splitReference[1]);
int firstVerse = int.Parse(splitReference[2]);
int lastVerse = firstVerse;
if(splitReference.Count > 3){
    lastVerse = int.Parse(splitReference[3]);
}

Reference realReference = new Reference(book, chapter, firstVerse, lastVerse);
realReference.Display();

Console.WriteLine("Please enter your scripture: ");
string userScripture = Console.ReadLine();
Console.WriteLine();
Scripture Scripture = new Scripture(userScripture, realReference);

while(true){
Console.Clear();
Scripture.HideWords();
Scripture.Display();

Console.WriteLine("\nPress enter to continue\nType 'show' to show all\nType 'exit' to end");
string answer = Console.ReadLine().ToLower();

if(answer == "exit"){
    break;
}
else if(answer == "show"){
    Scripture.ShowAll();
}
}