using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
//Console.WriteLine("");

class Entry
{
    public string Date;
    public string Prompt;
    public string JournalEntry;
    public Entry(string _prompt, string _entry)
    {
        Date = DateTime.Now.ToString("yyyy-MM-dd"); //Get's the date of the entry and put it into public variable
        Prompt = _prompt; //Puts the question or writing prompt into a accessable variable
        JournalEntry = _entry; //Same as last things, make entry accessable outside of it's own function 

    }

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
        Console.Write("What is the file name: ");
        string _saveFile = Console.ReadLine();
        File.WriteAllLines(_saveFile, _entries.ConvertAll(_entry => _entry.ConvertToString()));//I had ChatGPT help me with the ConvertAll, 
        // it would have taken me a lot longer to get it to work, so I asked chat for some help with 
        // converting a list of one object type into another
        Console.WriteLine("Journal saved.\n");
    }

    public void LoadEntries() //This code is copied over from my last submission
    ///Loads a file made by the SaveEntries() function for the program to read as a string and print out
    {
         Console.Write("Enter filename to load: ");
        string _loadFile = Console.ReadLine();//Saves name of inputed file as a string
        Console.WriteLine("");
        string[] lines = File.ReadAllLines(_loadFile);//Uses user imput to find the file by using name and saves it as a string
        foreach (string line in lines)//Prints the string so that it can be read by the user
        {
            Console.WriteLine(line);//Prints Line by line
        }
        Console.WriteLine("");
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
        Console.WriteLine("5. Quit");//Print out the menu options
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

            switch (choice)
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