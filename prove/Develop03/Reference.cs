class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public string ReferncePrint()
    {

        if (_endVerse == 0)
        {
            return ($"{_book} {_chapter}:{_startVerse} ");
        }
        else
        {
            return ($"{_book} {_chapter}:{_startVerse}-{_endVerse} ");
        }
         // I want to freaking slam my head into the wall. This was far simpler than I was making it out to be in my head.
    }
}