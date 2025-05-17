using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
//Console.WriteLine("");
class Program
{
    static List<string> _listOfEntries = new List<string>();
    static string _saveLocation = @"C:\CSE\CSE210\prove\Develop02\Journals";
    static string Entry()
    {
        String _date = DateTime.Now.ToString("yyyy-MM-dd"); //Get's the date of the entry
        List<string> _questionList = new List<string> //List of Questions
        {
            "What was the best part of your day?",
            "What was a hard thing you accomplished today?",
            "What was something you wish you did differently today?",
            "What did you learn today?",
            "What was something funny that happened?",
            "What happened something happen that made your day better?",
            "How did you see the hand of the Lord in your life today?"
        };
        Random rand = new Random();//Selects a random number
        String _questionAsked = _questionList[rand.Next(_questionList.Count)]; // Random question, also saves it for future use
        Console.WriteLine("");
        Console.WriteLine(_questionAsked);
        Console.Write("---> ");
        string _entry = Console.ReadLine();
        Console.WriteLine("");
        return $"|Date: {_date} - Prompt {_questionAsked} \n{_entry}|";
    }

    static void Journal()
    {
        bool repeat = true;
        while (repeat)
        {
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? (Please enter the number): ");
            string _typedIn = Console.ReadLine();
            int choice = int.Parse(_typedIn);
            switch (choice)
            {
                case 1:
                    String _entry = Entry();
                    _listOfEntries.Add(_entry);
                    break;
                case 2:
                    Console.WriteLine("");
                    Console.WriteLine("--Journal Entries--");
                    foreach (var e in _listOfEntries)
                    {
                        Console.WriteLine(e + "\n");
                    }
                    break;
                case 3:
                    Console.Write("Enter filename to load: ");
                    string _loadFile = Console.ReadLine();
                    string _fullLoadFile = Path.Combine(_saveLocation, _loadFile);
                    Console.WriteLine("");
                    string[] lines = File.ReadAllLines(_fullLoadFile);
                    foreach (string line in lines)
                    {
                        Console.WriteLine(line);
                    }
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.Write("What is the file name: ");
                    string _saveFile = Console.ReadLine();
                    string _fullSaveFile = Path.Combine(_saveLocation, _saveFile);
                    File.WriteAllLines(_fullSaveFile, _listOfEntries);
                    Console.WriteLine("Journal saved.\n");
                    break;
                case 5:
                    Console.WriteLine("Goodbye!");
                    repeat = false;
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }

    }
    static void Main()
    {
        Journal();
    }
}