using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

class Program
{
    static string GetRandomReference()
    {
        Random rand = new Random();
        int number = rand.Next(1, 4);
        return $"scripture_{number}";
    }

    static Reference GetReference((string, int, int, int, string) _wholeScripture)
    {
        string _book = _wholeScripture.Item1;
        int _chapter = _wholeScripture.Item2;
        int _startVerse = _wholeScripture.Item3;
        int _endVerse = _wholeScripture.Item4;
        Reference _reference = new Reference(_book, _chapter, _startVerse, _endVerse);
        return _reference;
    }

    static Scripture GetScripture((string, int, int, int, string) _wholeScripture)
    {
        string _text = _wholeScripture.Item5;
        Scripture _scripture = new Scripture(_text);
        return _scripture;
    }

    static string Menu(string _printReference, Scripture _scripture)
    {
        Console.Clear();
        Console.Write(_printReference);
        _scripture.PrintScripture();
        Console.WriteLine("\n\nPress enter to continue or type 'quit' to finish:");
        string _input = Console.ReadLine();
        return _input;
    }
    static void Main(string[] args)
    {
        var scriptures = new Dictionary<string, (string, int, int, int, string)>
        {
            ["scripture_1"] = ("John", 3, 16, 0, "For God so loved the world that he gave his only Son, that whoever believes in him should not perish but have eternal life."),
            ["scripture_2"] = ("Proverbs", 3, 5, 6, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."),
            ["scripture_3"] = ("1 Nephi", 3, 7, 0, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."),
            ["scripture_4"] = ("Mosiah", 2, 41, 0, "And moreover, I would desire that ye should consider on the blessed and happy state of those that keep the commandments of God. For behold, they are blessed in all things, both temporal and spiritual; and if they hold out faithful to the end they are received into heaven, that thereby they may dwell with God in a state of never-ending happiness. O remember, remember that these things are true; for the Lord God hath spoken it."),
            ["scripture_5"] = ("Moroni", 10, 4, 5, "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost. And by the power of the Holy Ghost ye may know the truth of all things.")
        };

        string _interem = GetRandomReference();
        var _median = scriptures[_interem];
        Reference _reference = GetReference(_median);
        string _printReference = _reference.ReferncePrint();
        Scripture _scripture = GetScripture(_median);
        bool _quiz = true;
        while (_quiz)
        {
            string _input = Menu(_printReference, _scripture);
            if (_input == "q" || _input == "quit")
            {
                _quiz = false;
            }
            // else if ()
            // {
            //     _quiz = false;
            // }
            else
            {
                _scripture.HideWords();
                bool _check = _scripture.AllWordsHidden();
                if (_check)
                {
                    Menu(_printReference, _scripture);
                    _quiz = false;
                }
            }
        }
        Console.WriteLine("Goodbye!");
    }
}