using System;
public class Scripture
{
    public string Reference;
    private List<Word> Words;
    private Random rand = new Random();

    public Scripture(string _reference, string _text)
    {
        Reference = _reference;
        Words = _text.Split(' ').Select(word => new Word(word)).ToList()
    }

    public DisplayScripture()
    {
        Console.Write(Reference);
        DisplayText();
    }

}

class Reference
{
    public string Reference;
}

class Word
{
    public string Text;
    public bool Hidden;

    public Word(string text)
    {
        Text = text
    }

    public DisplayText()
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
}

class Program
{
    static void Main()
    {
        Scripture _newScripture = new Scripture("Proverbs 3:5-6", 
        "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy way awknowledge him and he shall direct thy paths.")

        bool _quiz = true
        while (quiz)
        {
            Console.Clear()
            DisplayScripture()
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:")
            string _input = Console.ReadLine();
            if (_input == "quit")
            {
                _quiz = false
            }
            else if (_words == 0)
            {
                _quiz = false
            }
            else
            {
                RemoveLetters()
            }
        }
        Console.WriteLine("Goodbye!");
        }
}