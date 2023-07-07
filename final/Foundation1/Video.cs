public class Video
{
    public string _title;
    public string _author;
    public double _length;
    public List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, double length){
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(int count)
    {
        for(int i = count; i > 0; i--){
            Console.WriteLine("Add comment...");
            string comment = Console.ReadLine();
            Console.WriteLine("Author...");
            string author = Console.ReadLine();

            Comment newComment = new Comment{_authorComment = author, _comment = comment};

            _comments.Add(newComment);
        }
    }

    public void Display()
    {
        foreach(Comment comment in _comments)
        {
            Console.WriteLine($"Title: {_title}     Author: {_author}       Length: {_length}");
            comment.Display();
        }
    }
}