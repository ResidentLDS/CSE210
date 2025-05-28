using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
//https://www.c-sharpcorner.com/article/convert-string-to-json-in-c-sharp/
//I used this website to help me with JSON

class Entry
{
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string JournalEntry{ get; set; } //I couldn't get the JSON to work and I noticed it had this on the website and it worked, so I have the {get; set;} now
    public Entry(string _prompt, string _entry)
    {
        Date = DateTime.Now.ToString("yyyy-MM-dd"); //Get's the date of the entry and put it into public variable
        Prompt = _prompt; //Puts the question or writing prompt into a accessable variable
        JournalEntry = _entry; //Same as last things, make entry accessable outside of it's own function 

    }
    public Entry(){ } // I couldn't get it to read the files until I added this, I don't know why. ChatGPT actually suggested it after I was troublshooting it for around 40 minutes.

    public string ConvertToString()
    {
        return ($"|Date: {Date} - Prompt: {Prompt} \n- {JournalEntry}|");
    }

}
class Journal//For almost all the code I copied over from my previous program with some minor tweaks. This was most of what I had in my menu on the original code but organized differently
{
    private List<Entry> _entries = new List<Entry>(); //Creates a list of entries that can be added to under the Entry type
    public static List<string> _questionList = new List<string> //List of Questions
    {
        "What was the best part of your day?",
        "What was a hard thing you accomplished today?",
        "What was something you wish you did differently today?",
        "What did you learn today?",
        "What was something funny that happened?",
        "What happened something happen that made your day better?",
        "How did you see the hand of the Lord in your life today?"
    };
    public void CreateEntry()
    ///Allows the user to create an journal entry to be saved or read later
    {
        Random rand = new Random();//Selects a random number
        string _questionAsked = _questionList[rand.Next(_questionList.Count)]; // Random question, also saves it for future use
        Console.WriteLine();
        Console.WriteLine($"{_questionAsked}");
        Console.Write("---> ");
        string _jounralEntry = Console.ReadLine(); //I realized I spelled this wrong but it was funny
        Entry _entry = new Entry(_questionAsked, _jounralEntry); //Converts the string into the Entry type using the Class
        _entries.Add(_entry);//Saves the new entry into a list of entries
        Console.WriteLine();
    }

    public void DisplayEntries()
    ///Displays the entries made in this instance of the program
    {
        Console.WriteLine();//the empty lines help the spacing so that it is easier to navigate the program

        foreach (Entry _entry in _entries)
        {
            Console.WriteLine(_entry.ConvertToString());
            Console.WriteLine();
        }
    }

    public void SaveEntries()
    ///Allows the entries made by the user to be saved into a file that can be read later
    {
        Console.WriteLine();
        Console.WriteLine("All files are saved in a json file");
        Console.Write("What is the file name: ");
        string _saveFile = Console.ReadLine();
        string _converted = JsonSerializer.Serialize(_entries);
        if (File.Exists(_saveFile + ".json"))
        {
            Console.Write($"'{_saveFile}.json' already exists, combine files? (y/n) ");
            string answer = Console.ReadLine();
            if (answer == "y")
            {
                File.WriteAllText("temporary.json", _converted);
                CombineJournals2(_saveFile + ".json", "temporary.json", _saveFile + ".json");
            }
            else
            {
                File.WriteAllText(_saveFile + ".json", _converted);
            }
        }

        else
        {
            File.WriteAllText(_saveFile + ".json", _converted);
        }                

        _entries.Clear(); //Clears out the entries from the instance once they're saved
        Console.WriteLine("Journal saved.\n");
        Console.WriteLine();
    }

    public void LoadEntries() //This code is copied over from my last submission
    ///Loads a file made by the SaveEntries() function for the program to read as a string and print out
    {
        Console.WriteLine();
        Console.Write("Enter filename to load: ");
        string _loadFile = Console.ReadLine();//Saves name of inputed file as a string
        Console.WriteLine();
        string _convert = File.ReadAllText(_loadFile + ".json");//Uses user input to find the file by using name and saves it as a string
        List<Entry> lines = JsonSerializer.Deserialize<List<Entry>>(_convert);
        foreach (var line in lines)//Prints the string so that it can be read by the user
        {
            Console.WriteLine(line.ConvertToString());//Prints Line by line
            Console.WriteLine();
        }
    }

    public void CombineJournals()//I thought it was weird how it would just overwrite previous entries so I figured make a way to combine them
    ///Combines 2 files created by SaveEntries() into one file
    {
        Console.WriteLine();
        Console.Write("Enter the first filename: ");
        string _loadFile1 = Console.ReadLine();//Saves name of inputed file as a string
        Console.Write("Enter the second filename: ");
        string _loadFile2 = Console.ReadLine();//Saves name of inputed file as a string
        Console.Write("Enter the name of the combined journal: ");
        string _nameOfFile = Console.ReadLine();
        CombineJournals2(_loadFile1 + ".json", _loadFile2 + ".json", _nameOfFile + ".json");
        Console.WriteLine("Journals combined.");

    }
    public void CombineJournals2(string _loadFile1, string _loadFile2, string _nameOfFile) //I was adding it into the creating a save file so it would check and making this part 2 was much easier than just copying
    {
        string _lines1 = File.ReadAllText(_loadFile1);//Uses user imput to find the file by using name and saves it as a string
        string _lines2 = File.ReadAllText(_loadFile2);//Uses user imput to find the file by using name and saves it as a string
        List<Entry> _entries1 = JsonSerializer.Deserialize<List<Entry>>(_lines1);
        List<Entry> _entries2 = JsonSerializer.Deserialize<List<Entry>>(_lines2);
        List<Entry> _fullJournal = _entries1.Concat(_entries2).ToList();//Chat helped me with this as well.
        File.Delete(_loadFile1);
        File.Delete(_loadFile2);
        string _converted = JsonSerializer.Serialize(_fullJournal);
        File.WriteAllText(_nameOfFile, _converted);
    }

}

class Program
{
    static int PrintMenu() //The menu was super long and messy, so I put it into the function so I could shrink it down.
    ///Prints out the menu choices for the journal and allows them to make a decision from numbers 1-5
    {
        Console.WriteLine("Please select one of the following choices");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Combine Journals");
        Console.WriteLine("6. Quit");//Print out the menu options
        Console.Write("What would you like to do? (Please enter the number): ");
        string _typedIn = Console.ReadLine();//Get the integer selected by the user
        int choice = int.Parse(_typedIn);
        return choice;//Return the int
    }
    static void Main()
    {
        bool repeat = true;
        Journal _myJournal = new Journal();
        while (repeat)
        {
            int choice = PrintMenu();//Uses function to display menu and get user choice

            switch (choice)//Selection list that accesses the journal functions so that it works. It just works!!
            {
                case 1:
                    _myJournal.CreateEntry();
                    break;
                case 2:
                    _myJournal.DisplayEntries();
                    break;
                case 3:
                    _myJournal.LoadEntries();
                    break;
                case 4:
                    _myJournal.SaveEntries();
                    break;
                case 5:
                    _myJournal.CombineJournals();
                    break;
                case 6:
                    Console.WriteLine("\nGoodbye!");
                    repeat = false;
                    break; 
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}