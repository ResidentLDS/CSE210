using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
//Console.WriteLine("");
class Program
{
    static List<string> ListOfEntries = new List<string>();
    static string Entry()
    {
        String Date = DateTime.Now.ToString("yyyy-MM-dd"); //Get's the date of the entry
        List<string> question_list = new List<string> //List of Questions
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
        String Question_Asked = question_list[rand.Next(question_list.Count)]; // Random question, also saves it for future use
        Console.WriteLine("");
        Console.WriteLine(Question_Asked);
        Console.Write("---> ");
        string Entry = Console.ReadLine();
        Console.WriteLine("");
        return $"Date: {Date} - Prompt {Question_Asked} \n{Entry}";
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
            string typed_in = Console.ReadLine();
            int choice = int.Parse(typed_in);
            switch (choice)
            {
                case 1:
                    String entry = Entry();
                    ListOfEntries.Add(entry);
                    break;
                case 2:
                    Console.WriteLine("");
                    Console.WriteLine("--Journal Entries--");
                    foreach (var e in ListOfEntries)
                    {
                        Console.WriteLine(e + "\n");
                    }
                    break;
                case 3:
                    Console.Write("Enter filename to load: ");
                    Console.WriteLine("");
                    string loadFile = Console.ReadLine();
                    string[] lines = File.ReadAllLines(loadFile);
                    foreach (string line in lines)
                    {
                        Console.WriteLine(line);
                    }
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.Write("What is the file name: ");
                    string SaveFile = Console.ReadLine();;
                    File.WriteAllLines(SaveFile, ListOfEntries);
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