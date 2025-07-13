using System.ComponentModel;

class Video
{
    private string _title;
    private string _creator;
    private int _seconds;
    private List<Comment> _comments;
    public Video(string title, string creator, int seconds, Comment comment1, Comment comment2, Comment comment3)
    {
        _title = title;
        _creator = creator;
        _seconds = seconds;
        _comments = new List<Comment> {comment1, comment2, comment3};   
    }



    public void PrintVideos()
    {
        Console.WriteLine($"Title: {_title}, Creator: {_creator}, Length: {_seconds} seconds or {_seconds/60}:{_seconds%60}\nComments:");
        foreach (Comment c in _comments)
        {
            c.PrintComments();
        } 
    }

}