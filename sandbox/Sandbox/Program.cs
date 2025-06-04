class Reference
{
    public string Book;
    public int Chapter;
    public int StartVerse;
    public int? EndVerse;

    public Reference(string _book, int _chapter, int _startVerse, int? _endVerse, string _text)
    {
        Book = _book;
        Chapter = _chapter;
        StartVerse = _startVerse;
        EndVerse = _endVerse;
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
class Program
{
    static string GetRandomReference()
    {
        Random rand = new Random();
        int number = rand.Next(1, 4);
        return $"_scripture_{number}";
    }
    static void Main(string[] args)
    {
        var scriptures = new Dictionary<string, (string, int, int, int?, string)>
        {
            ["_scripture_1"] = ("John", 3, 16, 0, "For God so loved the world that he gave his only Son, that whoever believes in him should not perish but have eternal life."),
            ["_scripture_2"] = ("Proverbs", 3, 5, 6, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."),
            ["_scripture_3"] = ("1 Nephi", 3, 7, 0, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."),
        };

        string _interem = GetRandomReference();
        Console.WriteLine(_interem);
        // string _book = 
        // Console.WriteLine(_median);
        // Reference reference = new Reference(_median);
    }
}