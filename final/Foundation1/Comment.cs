class Comment
{
    private string _name;
    private string _commentWords;
    public Comment(string name, string _comments)
    {
        _name = name;
        _commentWords = _comments;
    }

    public void PrintComments()
    {
        Console.WriteLine($"{_name}: {_commentWords}");
    }
}