public class Comment
{
    public string _authorComment;
    public string _comment;


    public void Display()
    {
        Console.WriteLine($"Comment: {_comment}\nAuthor: {_authorComment}");
    }

}