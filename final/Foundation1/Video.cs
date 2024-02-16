public class Video
{
    public string _title;
    public string _author;
    public int _lengthInSeconds;
    public List<Comment> comments = new List<Comment>();

    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
    }
    public int GetNumberOfComments()
    {
        return comments.Count;
    }
    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }
    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title : {_title}");
        Console.WriteLine($"Author : {_author}");
        Console.WriteLine($"Length : {_lengthInSeconds}s");
        foreach (var comment in comments)
        {
            Console.WriteLine($"Comment by {comment._commenterName}:  {comment._text}");
        }
        Console.WriteLine();
    }
}