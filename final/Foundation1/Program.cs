using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Video 1", "Author 1", 10.21);
        Video video2 = new Video("Video 2", "Author 2", 15.85);
        Video video3 = new Video("Video 3", "Author 3", 5.12);
        Video video4 = new Video("Video 4", "Author 4", 10.1);

        video1.AddComment(3);
        video2.AddComment(3);
        video3.AddComment(3);
        video4.AddComment(3);

        video1.Display();
        video2.Display();
        video3.Display();
        video4.Display();
        
    }
}