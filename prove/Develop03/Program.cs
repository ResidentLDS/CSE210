using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;


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
    static string GetRandomReference()
    {
        Random rand = new Random();
        int number = rand.Next(1, 4);
        return $"_scripture_{number}";
    }

    static Reference GetReference((string, int, int, int, string) _wholeScripture)
    {
        string _book =
    }
    static void Main(string[] args)
    {
        var scriptures = new Dictionary<string, (string, int, int, int, string)>
        {
            ["_scripture_1"] = ("John", 3, 16, 0, "For God so loved the world that he gave his only Son, that whoever believes in him should not perish but have eternal life."),
            ["_scripture_2"] = ("Proverbs", 3, 5, 6, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."),
            ["_scripture_3"] = ("1 Nephi", 3, 7, 0, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."),
        };

        string _interem = GetRandomReference();
        var _median = scriptures[_interem];
        
        Reference _reference = new Reference();
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

            }
        }
        Console.WriteLine("Goodbye!");
    }
}