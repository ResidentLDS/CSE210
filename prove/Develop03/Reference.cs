class Reference
{
    private string Book;
    private int Chapter;
    private int StartVerse;
    private int EndVerse;

    public Reference(string _book, int _chapter, int _startVerse, int _endVerse)
    {
        Book = _book;
        Chapter = _chapter;
        StartVerse = _startVerse;
        EndVerse = _endVerse;
    }

    public string ReferncePrint()
    {

        if (EndVerse == 0)
        {
            return ($"{Book} {Chapter}:{StartVerse} ");
        }
        else
        {
            return ($"{Book} {Chapter}:{StartVerse}-{EndVerse} ");
        }
         // I want to freaking slam my head into the wall. This was far simpler than I was making it out to be in my head.
    }
}