class Reference
{
    public string Book;
    public int Chapter;
    public int StartVerse;
    public int? EndVerse;
    public string Text;

    public Reference(string _book, int _chapter, int _startVerse, int _endVerse, string _text)
    {
        Book = _book;
        Chapter = _chapter;
        StartVerse = _startVerse;
        EndVerse = _endVerse;
        Text = _text;
    }

    public void ScripturePrint(Reference _scriptureReference)
    {

        if (EndVerse == 0)
        {
            Console.Write($"{Book} {Chapter}:{StartVerse}   ");
        }
        else
        {
            Console.Write($"{Book} {Chapter}:{StartVerse}-{EndVerse}   ");
        }
        
    }
}