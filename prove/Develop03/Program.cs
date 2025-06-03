using System;
using System.Security.Cryptography.X509Certificates;
public class Scripture
{
    private List<Word> Words;
    private Reference ScriptureReference;

    public Scripture(string _text)
    {
        Words = _text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void DisplayScripture(string key)
    {
        
    }

}

class Reference
{
    public string ScriptureReference;

    public Reference(string _reference)
    {
        ScriptureReference = _reference;
    }

    public void ScripturePrint(Scripture _scripture)
    {
        Console.Write(ScriptureReference);
        _scripture.DisplayScripture(ScriptureReference);
    }
}

class Word
{
    public string Text;
    public bool Hidden;

    public Word(string text)
    {
        Text = text;
        Hidden = false;
    }

    public void DisplayText()
    {

        if (Hidden)
        {
            foreach (char c in Text)
            {
                Console.Write("_");
            }

        }
        else
        {
            Console.Write(Text);
        }
    }

    public void Hide()
    {
        Hidden = true;
    }
}

class Program
{
    public static Dictionary<string, string> _scriptures = new Dictionary<string, string>()
        {
            { "John 3:16", "For God so loved the world that he gave his only Son, that whoever believes in him should not perish but have eternal life."},
            { "Proverbs 3:5-6", "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."},
            { "1 Nephi 3:7", "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."}
        };
    static string GetRandomReference()
    {
        Random rand = new Random();
        List<string> _reference = _scriptures.Keys.ToList();
        string _key = _reference[rand.Next(_reference.Count)];
        return _key;
    }
    static void Main(string[] args)
    {
        string _interem = GetRandomReference();
        Reference _reference = new Reference(_interem);
        bool _quiz = true;
        while (_quiz)
        {
            Console.Clear();
            Reference.ScripturePrint(_reference);
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
            string _input = Console.ReadLine();
            if (_input == "quit")
            {
                _quiz = false;
            }
            else
            {
                RemoveLetters();
            }
        }
        Console.WriteLine("Goodbye!");
        }
}